using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampı.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        KategoriManager km = new KategoriManager(new EFKategoriDAL());
        BaslikManager bm = new BaslikManager(new EFBaslikDAL());
        EntryManager em = new EntryManager(new EFEntryDAL());

        public ActionResult Basliklar()
        {
            var deger = km.KategoriListele();
            ViewBag.dgr = bm.BaslikListele();
            return View(deger);
        }
        
        public PartialViewResult Index(int id = 12)
        {
            var entryList = em.Basliktakiler(id);
            ViewBag.baslik = bm.BaslikListele().Where(x => x.BaslikID == id).Select(y => y.BaslikAd).FirstOrDefault().ToString();
            ViewBag.baslikID = id;
            return PartialView(entryList);
        }
    }
}