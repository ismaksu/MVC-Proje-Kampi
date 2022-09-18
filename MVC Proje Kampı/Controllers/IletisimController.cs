using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampı.Controllers
{
    public class IletisimController : Controller
    {
        IletisimManager im = new IletisimManager(new EFIletisimDAL());
        MesajManager mm = new MesajManager(new EFMesajDAL());
        IletisimValidator iv = new IletisimValidator();
        // GET: Iletisim
        [Authorize]
        public ActionResult Index()
        {
            var iletisimDeger = im.IletisimListele();
            return View(iletisimDeger);
        }

        public ActionResult IletisimDetay(int id)
        {
            var deger = im.IDdenBul(id);
            return View(deger);
        }

        public PartialViewResult CardPartial(string p)
        {
            p = (string)Session["YazarMail"];
            //İletişim
            var deger = im.IletisimListele().Count();
            ViewBag.imSayi = deger;

            //Mesaj ~ Gelen
            var gelen = mm.InboxListele(p).Count();
            ViewBag.inSayi = gelen;

            //Mesaj ~ Giden
            var giden = mm.SendboxListele(p).Count();
            ViewBag.outSayi = giden;

            return PartialView();
        }
    }
}