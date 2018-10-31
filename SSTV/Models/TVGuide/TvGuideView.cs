using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSTV.Models.TVGuide
{
    public class TvGuideView
    {
        public List<TablueView> TEST { get; set; }

        public TvGuideView()
        {
            TEST = new List<TablueView>();
        }
    }
}