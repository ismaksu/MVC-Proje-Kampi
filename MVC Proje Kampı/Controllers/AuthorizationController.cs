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
    public class AuthorizationController : Controller
    {
        AdminManager adm = new AdminManager(new EFAdminDAL());

        public ActionResult Index()
        {
            var adminDeger = adm.AdminListele();
            return View(adminDeger);
        }

        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminEkle(Admin p)
        {
            adm.AdminEkle(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AdminGuncelle(int id)
        {
            var adminDeger = adm.IDdenBul(id);
            return View(adminDeger);
        }

        [HttpPost]
        public ActionResult AdminGuncelle(Admin p)
        {
            adm.AdminGuncelle(p);
            return RedirectToAction("Index");
        }
    }
}