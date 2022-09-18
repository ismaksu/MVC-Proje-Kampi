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
    public class HakkindaController : Controller
    {
        HakkindaManager hm = new HakkindaManager(new EFHakkindaDAL());
        public ActionResult Index()
        {
            var hakkindaDeger = hm.HakkindaListele();
            return View(hakkindaDeger);
        }

        [HttpPost]
        public ActionResult HakkindaEkle(Hakkinda h)
        {
            hm.HakkindaEkle(h);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult HakkindaEkle()
        {
            return View();
        }

        public PartialViewResult HakkindaPartial()
        {
            return PartialView();
        }
    }
}