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
        //private TVChannel tvChannel = new TVChannel(); //Tror inte den används
        public ActionResult Index()
        {
            var program = TvChannelList();
            return View(program.ToList());

            //return View(tvChannel.TVPrograms); //Tror inte den används
        }

        [ActionName("Index")]
        [HttpGet]
        public ActionResult GetFiltredPrograms(string category)
        {
            //category = "Thriller";
            List<TVChannel> tvChannels = TvChannelList();

            Search search = new Search();
            var searchResult = search.SearchByCategory(category, tvChannels);
            return View(searchResult.ToList());
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
        //public ActionResult Search()
        //{
        //    string category = "Thriller";
        //    Search search = new Search();
        //    List<TVProgram> searchResult = search.SearchByCategory(category);
        //    return View(searchResult);
        //}


    }
}