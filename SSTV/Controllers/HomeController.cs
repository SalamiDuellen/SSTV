using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSTV.Models;
using SSTV.Models.TestResources.Lists;
using SSTV.Models.TVGuide;


namespace SSTV.Controllers
{
    public class HomeController : Controller
    {
        private TVChannel tvChannel = new TVChannel();

        public ActionResult Index()
        {
            return View(tvChannel.TVPrograms);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}