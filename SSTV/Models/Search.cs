using SSTV.Models.TVGuide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static SSTV.Models.TestResources.Lists.Lists;

namespace SSTV.Models
{
    public class Search
    {
        public List<TVChannel> SearchByCategory(string category, List<TVChannel> tvChannels)
        {
            List<TVChannel> searchResults = new List<TVChannel>();
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
                            //tempTvChannel = channel;
                            tempTvChannel.TVPrograms.Add(program);
                            //programs.Add(program);
                            searchResults.Add(tempTvChannel);
                        }

                    }
                }
                //channel.TVPrograms = programs;
                //tvChannels.SelectMany(x => x.TVPrograms.Where(y => y.Categories.Any(z => z.Name == category)));
            }
            return searchResults;
        }
    }
}