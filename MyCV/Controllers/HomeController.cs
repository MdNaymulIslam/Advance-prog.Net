using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EducationalBackground()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult project()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Reference()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
     
    }
}