using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSTV.Models.TVGuide
{
    public class TVStation
    {//He, hej. Funkar det här?
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Program> TVProgram { get; set; }


    }
}