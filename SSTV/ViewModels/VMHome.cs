using SSTV.Models.TVGuide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSTV.ViewModels
{
    public class VMHome
    {
        Program _p;
        TVChannel _tvChannel;

        public Category Category { get; set; }
        public string ProgramTitle { get => _p.Title; set { } }
        public string ProgramStartTime { get => _p.StartTime; set { } }
        public string ProgramEndTime { get => _p.EndTime; set { } }
        public string ProgramDetails { get => _p.Details; set { } }
        public string TVChannelName { get => _tvChannel.Name; set { } }


    }
}