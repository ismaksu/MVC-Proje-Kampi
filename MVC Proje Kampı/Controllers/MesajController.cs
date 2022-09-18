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
    public class MesajController : Controller
    {
        MesajManager mm = new MesajManager(new EFMesajDAL());
        MesajValidator mv = new MesajValidator();

        public ActionResult Inbox(string p)
        {
            p = (string)Session["YazarMail"];
            var deger = mm.InboxListele(p);
            return View(deger);
        }

        public ActionResult Sendbox(string p)
        {
            p = (string)Session["YazarMail"];
            var deger = mm.SendboxListele(p);
            return View(deger);
        }

        [HttpGet]
        public ActionResult YeniMesaj()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniMesaj(Mesaj p, string p1)
        {
            p1 = (string)Session["YazarMail"];
            ValidationResult result = mv.Validate(p);
            if (result.IsValid)
            {
                p.GonderenMail = p1;
                p.MesajTarih = DateTime.Now;
                p.MesajOkunmasi = false;
                mm.MesajEkle(p);
                return RedirectToAction("Sendbox");
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

        public ActionResult MesajDetay(int id)
        {
            var deger = mm.IDdenBul(id);
            return View(deger);
        }

        public ActionResult SendboxDetay(int id)
        {
            var deger = mm.IDdenBul(id);
            return View(deger);
        }
    }
}