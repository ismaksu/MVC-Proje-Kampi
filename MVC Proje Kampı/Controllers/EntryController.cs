using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampı.Controllers
{
    [AllowAnonymous]
    public class EntryController : Controller
    {
        EntryManager em = new EntryManager(new EFEntryDAL());
        // GET: Entry
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EntryListele(string p)
        {
            var degerler = em.EntryListele(p);
            return View(degerler);
        }

        public ActionResult EntryByBaslik(int id)
        {
            var degerler = em.Basliktakiler(id);
            return View(degerler);
        }
    }
}