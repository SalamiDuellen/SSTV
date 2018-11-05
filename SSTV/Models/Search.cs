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
        public List<TVChannel> SearchByCategory(string searchCategory, List<TVChannel> tvChannels)
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
                        if (c.Name == searchCategory)
                        {
                            if (tempTvChannel.Name != channel.Name)
                            {
                                tempTvChannel = channel;

                                tempTvChannel.TVPrograms = new List<Program>
                                {
                                     program
                                };
                            }
                            else tempTvChannel.TVPrograms.Add(program);
                            //programs.Add(program);
                        }

                    }
                }
                //channel.TVPrograms = programs;
                searchResults.Add(tempTvChannel);
            }
            return searchResults;
        }
    }
}