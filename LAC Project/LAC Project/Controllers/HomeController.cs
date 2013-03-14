using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAC_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "I HOPE YOU SEE THIS.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "YAY YOU SAW IT.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "WOOHOO IT WORKED.";

            return View();
        }
    }
}
