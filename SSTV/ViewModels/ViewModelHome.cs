using SSTV.Models.TVGuide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static SSTV.Models.TestResources.Lists.Lists;

namespace SSTV.ViewModels
{
    public class ViewModelHome
    {
       public List<TVChannel> TVChannels { get; set; }
        public List<Category> Categories { get; set; }
        public string SelectedCategory { get; set; }


        public ViewModelHome()
        {
            Categories = AddCategories();
            TVChannels = new List<TVChannel>();
        }

    }
}