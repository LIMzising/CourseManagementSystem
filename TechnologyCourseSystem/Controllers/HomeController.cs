using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechnologyCourseSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Training Tomorrow’s Tech description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Training Tomorrow’s Tech contact page.";

            return View();
        }
    }
}