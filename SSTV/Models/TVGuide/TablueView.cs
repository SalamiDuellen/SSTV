using SSTV.Models.TestResources.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSTV.Models.TVGuide
{
    public class TablueView
    {
        public TVChannel Channel { get; set; }

        public Program Program { get; set; }

        public List<Program> Programs { get;  set; }

    }
}