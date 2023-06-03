using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Anasayfa = "active";
            return View();
        }
        public ActionResult Iletisim()
        {
            ViewBag.Iletisim = "active";
            return View();
        }


        public ActionResult About()
        {
            ViewBag.About = "active";
            return View();
        }
        public ActionResult Hizmetler()
        {
            ViewBag.Hizmetler = "active";
            return View();
        }


        public ActionResult Fiyatlandirma()
        {
            ViewBag.Fiyatlandirma = "active";
            return View();
        }


    }
}