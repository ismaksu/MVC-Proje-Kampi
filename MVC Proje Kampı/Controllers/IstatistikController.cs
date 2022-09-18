using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Concrete;
using System.Data.Entity;
using EntityLayer.Concrete;

namespace MVC_Proje_Kampı.Controllers
{
    public class IstatistikController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            ViewBag.kateSayi = c.Kategoris.Count();
            ViewBag.specKate = c.Basliks.Where(x => x.Kategori.KategoriAd == "Yazılım").Count();
            ViewBag.aGecen = c.Yazars.Where(x => x.YazarAd.Contains("a")).Count();
            int KategoriID = c.Basliks.GroupBy(x => x.KategoriID).OrderByDescending(y => y.Count()).Select(a => a.Key).FirstOrDefault();
            ViewBag.enCokBas = c.Basliks.Where(x => x.Kategori.KategoriID == KategoriID).Select(z => z.Kategori.KategoriAd).FirstOrDefault();

            int kategoriTrue = c.Kategoris.Where(x => x.CategoryStats == true).Count();
            int kategoriFalse = c.Kategoris.Where(x => x.CategoryStats == false).Count();
            ViewBag.kategoriFark = Math.Abs(kategoriTrue - kategoriFalse);
            return View();
        }
    }
}