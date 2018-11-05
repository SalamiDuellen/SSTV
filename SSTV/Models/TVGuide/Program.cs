using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSTV.Models.TVGuide
{
    public class Program
    {
        string _endTime;
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Broadcasting { get; set; }
        public string StartTime
        {
            get => Broadcasting.TimeOfDay.ToString().Remove(5);
            set
            {
                Broadcasting.TimeOfDay.ToString().Remove(5);
            }
        }
        public string EndTime
        {
            get { return "Sluttid " + Broadcasting.AddMinutes(Duration).TimeOfDay.ToString().Remove(5); }
            set
            {
                Broadcasting.AddMinutes(Duration).TimeOfDay.ToString().Remove(5);
            }
        }


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