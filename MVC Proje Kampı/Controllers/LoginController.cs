using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Proje_Kampı.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        YazarManager ym = new YazarManager(new EFYazarDAL());
        AdminManager adm = new AdminManager(new EFAdminDAL());

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var adminUserBilgi = adm.AdminLoginAuthentication(p);
            if (adminUserBilgi)
            {
                FormsAuthentication.SetAuthCookie(p.AdminAd, false);
                Session["AdminAd"] = p.AdminSifre;
                return RedirectToAction("Index", "Iletisim");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult YazarLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YazarLogin(Yazar p)
        {
            var yazarUserBilgi = ym.YazarLoginAuthentication(p);
            
            if (yazarUserBilgi)
            {
                FormsAuthentication.SetAuthCookie(p.YazarMail, false);
                Session["YazarMail"] = p.YazarMail;
                return RedirectToAction("Entrylerim", "YazarPanelEntry");
            }
            else
            {
                return RedirectToAction("YazarLogin");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("YazarLogin");
        }
    }
}