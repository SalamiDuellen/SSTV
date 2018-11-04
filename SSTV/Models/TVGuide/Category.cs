using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSTV.Models.TVGuide
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Program TVProgram { get; set; }

        public override string ToString()
        {
            return Name; 
        }
    }
}