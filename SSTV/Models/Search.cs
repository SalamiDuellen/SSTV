using SSTV.Models.TVGuide;
using SSTV.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static SSTV.Models.TestResources.Lists.Lists;

namespace SSTV.Models
{
    public class Search
    {
        public List<VMHome> SearchByCategory(string category, List<TVChannel> tvChannels)
        {
            List<VMHome> searchResults = new List<VMHome>();
            VMHome vmHome;
            //List<Program> programs = new List<Program>();
            TVChannel tempTvChannel = new TVChannel();

            foreach (TVChannel channel in tvChannels)
            {
                foreach (var program in channel.TVPrograms)
                {
                    foreach (Category c in program.Categories)
                    {
                        if (c.Name == category)
                        {
                            vmHome = new VMHome
                            {
                                ProgramTitle = program.Title,
                                ProgramStartTime = program.StartTime,
                                ProgramEndTime = program.EndTime,
                                ProgramDetails = program.Details,
                                TVChannelName = channel.Name
                            };
                            searchResults.Add(vmHome);
                        }
                        //programs.Add(program);
                    }

                }
            }
            //channel.TVPrograms = programs;
            //tvChannels.SelectMany(x => x.TVPrograms.Where(y => y.Categories.Any(z => z.Name == category)));
            return searchResults;
        }
    }
}
