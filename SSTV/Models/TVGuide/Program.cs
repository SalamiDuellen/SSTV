using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSTV.Models.TVGuide
{
    public class Program
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Broadcasting { get; set; }
        public int Duration { get; set; }
        public string Informations { get; set; }
        public TVChannel Channel { get; set; }

        public List<Category> Categories { get; set; }

        public Program()
        {
            Categories = new List<Category>();
        }

    }
}