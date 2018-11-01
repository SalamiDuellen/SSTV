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
        public List<Program> SearchByCategory(string category)
        {
            List<TVChannel> tvChannels = TvChannelList();
            List<Program> searchResult = new List<Program>();


            foreach (TVChannel channel in tvChannels)
            {
                foreach (var program in channel.TVPrograms)
                {
                    foreach (Category c in program.Categories)
                    {
                        if (c.Name == category)
                        {
                            searchResult.Add(program);
                        }

                    }
                }
                //tvChannels.SelectMany(x => x.TVPrograms.Where(y => y.Categories.Any(z => z.Name == category)));
            }
            return searchResult;
        }
    }
}