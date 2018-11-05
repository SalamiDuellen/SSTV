using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSTV.Models;
using SSTV.Models.TVGuide;
using static SSTV.Models.TestResources.Lists.Lists;
using SSTV.ViewModels;




namespace SSTV.Controllers
{
    public class HomeController : Controller
    {
        // todo - Försöker binda dropdownlistan till propertierserna för kategorisöket.
        // Har skapar en viewModel där listor för tvchannels and categories lies.
        public ViewModelHome vmHome;
        [HttpGet]
        public ActionResult Index(string searchString)
        {
            vmHome = TvChannelList();
            Search search = new Search();


            if (searchString == null)
            {
                vmHome = TvChannelList();
                return View(vmHome);
            }
            else
            vmHome.TVChannels = search.SearchByCategory(searchString, vmHome.TVChannels);

            return View(vmHome);
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
    }
}