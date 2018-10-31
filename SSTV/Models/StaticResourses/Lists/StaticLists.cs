using SSTV.Models.TVGuide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSTV.Models.StaticResources.Lists
{
    public class StaticLists
    {
        private List<TVChannel> AddTvChannels()
        {
            List<TVChannel> tvChannels = new List<TVChannel>
            {
                new TVChannel{ID=1,Name="SVT1"},
                new TVChannel{ID=2,Name="SVT2"},
                new TVChannel{ID=3,Name="TV3"},
                new TVChannel{ID=4,Name="TV4"},
                new TVChannel{ID=5,Name="Kanal 5"}
            };

            return tvChannels;
        }

        private void AddPrograms()
        {
            Category category = new Category();

            TVChannel channel;
            channel = new TVChannel { ID = 1, Name = "SVT1" };
            channel.TVPrograms = new List<Program>
            {
                new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                 new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                  new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                   new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },
            };

            channel = new TVChannel { ID = 2, Name = "SVT2" };
            channel.TVPrograms = new List<Program>
            {
              new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                 new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                  new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                   new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },
            };

            channel = new TVChannel { ID = 3, Name = "TV3" };
            channel.TVPrograms = new List<Program>
            {
                new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                 new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                  new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                   new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },
            };

            channel = new TVChannel { ID = 4, Name = "TV4" };
            channel.TVPrograms = new List<Program>
            {
               new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                 new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                  new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                   new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },
            };
            channel = new TVChannel { ID = 5, Name = "Kanal 5" };
            channel.TVPrograms = new List<Program>
            {
                new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                 new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                  new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },

                   new Program{Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thiller" }, new Category { ID = 3, Name = "Drama" } } },
            };

        }

        private void AddCategory()
        {
            Category category = new Category();

            List<Category> categories = new List<Category>
            {
                new Category { ID = 1, Name = "Thiller" },
                new Category{ID=2,Name="Komedi"},
                new Category{ID=3,Name="Drama"},
                new Category{ID=4,Name="Nyheter"},
            };
        }
    }
}