using MVC_Proje_Kampı.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampı.Controllers
{
    public class ChartController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KategoriChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }

        public List<KategoriSinif> BlogList()
        {
            List<KategoriSinif> ks = new List<KategoriSinif>();
            ks.Add(new KategoriSinif()
            {
                KategoriAd = "Yazılım",
                KategoriSayi = 9
            });

            ks.Add(new KategoriSinif()
            {
                KategoriAd = "Animeler",
                KategoriSayi = 3
            });

            ks.Add(new KategoriSinif()
            {
                KategoriAd = "Film",
                KategoriSayi = 2
            });

            ks.Add(new KategoriSinif()
            {
                KategoriAd = "Dizi",
                KategoriSayi = 2
            });
            return ks;
        }
    }
}