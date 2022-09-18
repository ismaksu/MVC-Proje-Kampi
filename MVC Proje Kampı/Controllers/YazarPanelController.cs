using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using FluentValidation.Results;
using BusinessLayer.ValidationRules;

namespace MVC_Proje_Kampı.Controllers
{
    public class YazarPanelController : Controller
    {
        BaslikManager bm = new BaslikManager(new EFBaslikDAL());
        KategoriManager km = new KategoriManager(new EFKategoriDAL());
        YazarManager ym = new YazarManager(new EFYazarDAL());

        Context c = new Context();
        
        [HttpGet]
        public ActionResult YazarProfil()
        {
            var p = (string)Session["YazarMail"];
            int id = c.Yazars.Where(x => x.YazarMail == p).Select(y => y.YazarID).FirstOrDefault();
            var yazarDeger = ym.IDdenBul(id);
            return View(yazarDeger);
        }

        YazarValidator validationRules = new YazarValidator();

        [HttpPost]
        public ActionResult YazarProfil(Yazar p)
        {
            ValidationResult result = validationRules.Validate(p);

            if (result.IsValid)
            {
                ym.YazarGuncelle(p);
                return RedirectToAction("YazarProfil");
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

        static int yazarBaslikDeger;

        [Authorize]
        public ActionResult Basliklarim(string p)
        {
            p = (string)Session["YazarMail"];
            yazarBaslikDeger = c.Yazars.Where(x => x.YazarMail == p).Select(y => y.YazarID).FirstOrDefault();
            var deger = bm.YazaraGoreListele(yazarBaslikDeger);
            return View(deger);
        }

        [HttpGet]
        public ActionResult YeniBaslik()
        {
            List<SelectListItem> kategoriDeger = (from x in km.KategoriListele()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.KategoriAd,
                                                      Value = x.KategoriID.ToString()
                                                  }).ToList();

            ViewBag.katDeg = kategoriDeger;
            return View();
        }

        [HttpPost]
        public ActionResult YeniBaslik(Baslik baslik)
        {
            baslik.BaslikTarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            baslik.YazarID = yazarBaslikDeger;
            baslik.BaslikDurum = true;
            bm.BaslikEkle(baslik);
            return RedirectToAction("Basliklarim");
        }

        [HttpGet]
        public ActionResult BaslikDuzenle(int id)
        {
            var kategoriDeger = (from x in km.KategoriListele()
                                 select new SelectListItem
                                 {
                                     Text = x.KategoriAd,
                                     Value = x.KategoriID.ToString()
                                 }).ToList();
            ViewBag.katDeg = kategoriDeger;
            var baslikDeger = bm.IDdenBul(id);
            return View(baslikDeger);
        }

        [HttpPost]
        public ActionResult BaslikDuzenle(Baslik baslik)
        {
            bm.BaslikGuncelle(baslik);
            return RedirectToAction("Basliklarim");
        }

        public ActionResult BaslikSil(int id)
        {
            var deger = bm.IDdenBul(id);
            deger.BaslikDurum = deger.BaslikDurum ? deger.BaslikDurum = false : deger.BaslikDurum = true;
            bm.BaslikSil(deger);
            return RedirectToAction("Basliklarim");
        }

        public ActionResult TumBasliklar(int p = 1)
        {
            var basliklar = bm.BaslikListele().ToPagedList(p, 4);
            return View(basliklar);
        }
    }
}