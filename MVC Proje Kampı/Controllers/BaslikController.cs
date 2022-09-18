using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampı.Controllers
{
    public class BaslikController : Controller
    {
        // GET: Baslik
        BaslikManager bm = new BaslikManager(new EFBaslikDAL());
        KategoriManager km = new KategoriManager(new EFKategoriDAL());
        YazarManager ym = new YazarManager(new EFYazarDAL());

        public ActionResult Index()
        {
            var baslikDegerleri = bm.BaslikListele();
            return View(baslikDegerleri);
        }

        public ActionResult BaslikReport()
        {
            var degerler = bm.BaslikListele();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult BaslikEkle()
        {
            List<SelectListItem> kategoriDeger = (from x in km.KategoriListele()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.KategoriAd,
                                                      Value = x.KategoriID.ToString()
                                                  }).ToList();

            List<SelectListItem> yazarDeger = (from x in ym.YazarListele()
                                               select new SelectListItem
                                               {
                                                   Text = x.YazarAd,
                                                   Value = x.YazarID.ToString()
                                               }).ToList();

            ViewBag.katDeg = kategoriDeger;
            ViewBag.yazDeg = yazarDeger;

            return View();
        }

        [HttpPost]
        public ActionResult BaslikEkle(Baslik p)
        {
            p.BaslikTarih = DateTime.Now;
            bm.BaslikEkle(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult BaslikGuncelle(int id)
        {
            List<SelectListItem> kategoriDeger = (from x in km.KategoriListele()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.KategoriAd,
                                                      Value = x.KategoriID.ToString()
                                                  }).ToList();
            List<SelectListItem> yazarDeger = (from x in ym.YazarListele()
                                               select new SelectListItem
                                               {
                                                   Text = x.YazarAd,
                                                   Value = x.YazarID.ToString()
                                               }).ToList();

            ViewBag.val = kategoriDeger;
            ViewBag.deg = yazarDeger;

            var degerler = bm.IDdenBul(id);
            return View(degerler);
        }

        [HttpPost]
        public ActionResult BaslikGuncelle(Baslik p)
        {
            bm.BaslikGuncelle(p);
            return RedirectToAction("Index");
        }

        public ActionResult BaslikSil(int id)
        {
            var deger = bm.IDdenBul(id);
            deger.BaslikDurum = deger.BaslikDurum ? deger.BaslikDurum = false : deger.BaslikDurum = true;
            bm.BaslikSil(deger);
            return RedirectToAction("Index");
        }
    }
}