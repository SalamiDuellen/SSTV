using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSTV.Models;
using SSTV.Models.TVGuide;
using static SSTV.Models.TestResources.Lists.Lists;



namespace SSTV.Controllers
{
    public class HomeController : Controller
    {
        private TVChannel tvChannel = new TVChannel();

        public ActionResult Index()
        {
            var program = TvChannelList();
            return View(program.ToList());

            //return View(tvChannel.TVPrograms);
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
            public ActionResult Search()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}