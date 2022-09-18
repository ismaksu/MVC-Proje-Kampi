using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampı.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Anasayfa()
        {
            return View();
        }
    }
}