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
        [ActionName("Index")]
        [HttpGet]
        public ActionResult GetFiltredPrograms(string category)
        {
            List<TVChannel> tvChannels = TvChannelList();
            Search search = new Search();

            if (category==null)
            {
                var program = TvChannelList();
                return View(program.ToList());
            }

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