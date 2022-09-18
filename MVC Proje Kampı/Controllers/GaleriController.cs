using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampı.Controllers
{
    public class GaleriController : Controller
    {
        ResimDosyaManager rdy = new ResimDosyaManager(new EFResimDosyaDAL());
        public ActionResult Index()
        {
            var dosyalar = rdy.ResimListele();
            return View(dosyalar);
        }
    }
}