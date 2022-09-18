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
    public class KategoriController : Controller
    {
        KategoriManager manager = new KategoriManager(new EFKategoriDAL());
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KategoriListele()
        {
            var kategoriListesi = manager.KategoriListele();
            return View(kategoriListesi);
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Kategori p)
        {
            KategoriValidator valid = new KategoriValidator();
            ValidationResult result = valid.Validate(p);
            if (result.IsValid)
            {
                manager.KategoriEkle(p);
                return RedirectToAction("KategoriListele");
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
    }
}