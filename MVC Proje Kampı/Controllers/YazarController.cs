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
    public class YazarController : Controller
    {
        YazarValidator validationRules = new YazarValidator();
        YazarManager ym = new YazarManager(new EFYazarDAL());

        public ActionResult Index()
        {
            var yazarListesi = ym.YazarListele();
            return View(yazarListesi);
        }
        [HttpGet]
        public ActionResult YazarEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YazarEkle(Yazar p)
        {
            ValidationResult result = validationRules.Validate(p);

            if (result.IsValid)
            {
                ym.YazarEkle(p);
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

        [HttpGet]
        public ActionResult YazarDuzenle(int id)
        {
            var yazarDeger = ym.IDdenBul(id);
            return View(yazarDeger);
        }

        [HttpPost]
        public ActionResult YazarDuzenle(Yazar p)
        {
            ValidationResult result = validationRules.Validate(p);

            if (result.IsValid)
            {
                ym.YazarGuncelle(p);
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
    }
}