using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampı.Controllers
{
    public class AdminKategoriController : Controller
    {
        KategoriManager cm = new KategoriManager(new EFKategoriDAL());

        [Authorize(Roles = "A")]
        public ActionResult Index()
        {
            var kategoriDeger = cm.KategoriListele();
            return View(kategoriDeger);
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Kategori p)
        {
            KategoriValidator catv = new KategoriValidator();
            ValidationResult result = catv.Validate(p);
            if (result.IsValid)
            {
                cm.KategoriEkle(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult KategoriSil(int id)
        {
            var kategoriDeger = cm.IDdenBul(id);
            cm.KategoriSil(kategoriDeger);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult KategoriDuzenle(int id)
        {
            var kategoriDeger = cm.IDdenBul(id);
            return View(kategoriDeger);
        }

        [HttpPost]
        public ActionResult KategoriDuzenle(Kategori p)
        {
            cm.KategoriGuncelle(p);
            return RedirectToAction("Index");
        }
    }
}