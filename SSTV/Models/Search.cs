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
        public List<TVChannel> SearchByCategory(Category category, List<TVChannel> tvChannels)
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
                        if (c.Name == category.Name)
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
                //tvChannels.SelectMany(x => x.TVPrograms.Where(y => y.Categories.Any(z => z.Name == category)));
                searchResults.Add(tempTvChannel);
            }
            return searchResults;
        }
    }
}