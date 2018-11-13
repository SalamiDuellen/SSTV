using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSTV.Models.TVGuide
{
    public class TVChannel
    {//He, hej. Funkar det här?
        public int ID { get; set; }
        public string Name { get; set; }
        // todo kolla upp om jag ff skapar en ny tvchannellista för kategorisöket. annars ta bort = new List...
        public List<Program> TVPrograms { get; set; } = new List<Program>(); 
        public Program TVProgram { get; set; } // varför är denna här?

        public TVChannel()
        {
            //TVPrograms = new List<Program>();
        }
    }
}