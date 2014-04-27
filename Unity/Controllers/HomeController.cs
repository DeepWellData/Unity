using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Unity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What Is the NA Program?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "24 hr Phone Line";

            return View();
        }

        public ActionResult GettingStarted()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}