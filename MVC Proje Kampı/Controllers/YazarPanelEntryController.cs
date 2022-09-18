using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampı.Controllers
{
    public class YazarPanelEntryController : Controller
    {
        EntryManager em = new EntryManager(new EFEntryDAL());
        static int yazarID;
        public ActionResult Entrylerim(string p)
        {
            Context c = new Context();
            p = (string)Session["YazarMail"];
            yazarID = c.Yazars.Where(x => x.YazarMail == p).Select(y => y.YazarID).FirstOrDefault();
            var degerler = em.YazaraGoreListele(yazarID);
            return View(degerler);
        }

        static int baslikID;

        [HttpGet]
        public ActionResult EntryEkle(int id)
        {
            BaslikManager bm = new BaslikManager(new EFBaslikDAL());
            baslikID = id;
            ViewBag.baslikAd = bm.IDdenBul(id).BaslikAd.ToString();
            return View();
        }

        [HttpPost]
        public ActionResult EntryEkle(Entry p)
        {
            p.BaslikID = baslikID;
            p.EntryTarih = DateTime.Now;
            p.YazarID = yazarID;
            p.EntryDurum = true;
            em.EntryEkle(p);
            return RedirectToAction("Entrylerim");
        }
    }
}