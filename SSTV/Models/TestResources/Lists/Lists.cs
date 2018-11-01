using SSTV.Models.TVGuide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSTV.Models.TestResources.Lists
{
    public static class Lists
    {
        #region
        //public static List<TablueView> TvChannelList()
        //{
        //    TvGuideView TEST = new TvGuideView();
        //    List<TablueView> channels = new List<TablueView>();
        //    TablueView test = new TablueView
        //    {
        //        Channel = new TVChannel { ID = 1, Name = "SVT1" },
        //        Programs = new List<Program>
        //          {
        //        new Program{ID= 1,Title = "Bonde söker en fru",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //         new Program{ID= 2,Title = "Mästerkocken",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //          new Program{ID= 3,Title = "Dexter",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //           new Program{ID= 4,Title = "Teletubbies",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },
        //    }
        //    };
        //    channels.Add(test);

        //    test = new TablueView
        //    {
        //        Channel = new TVChannel { ID = 2, Name = "SVT2" },

        //        Programs = new List<Program> {
        //      new Program{ID= 5,Title = "Desperate housewives",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //         new Program{ID= 6,Title = "Glamour",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //          new Program{ID= 7,Title = "Rise and fall of an empire",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Dokumentär" } } },

        //           new Program{ID= 8,Title = "Most evil",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Dokumentär" } } },
        //           }
        //    };
        //    channels.Add(test);


        //    test = new TablueView
        //    {
        //        Channel = new TVChannel { ID = 3, Name = "TV3" },
        //        Programs = new List<Program>
        //        {
        //        new Program{ID= 9,Title = "När lammen tystnar",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //         new Program{ID= 10,Title = "Du är vad du äter",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //          new Program{ID= 11,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //           new Program{ID= 12,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },
        //           }
        //    };
        //    channels.Add(test);


        //    test = new TablueView
        //    {
        //        Channel = new TVChannel { ID = 4, Name = "TV4" },
        //        Programs = new List<Program>
        //        {
        //       new Program{ID= 13,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //         new Program{ID= 14,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //          new Program{ID= 15,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //           new Program{ID= 16,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },
        //           }
        //    };
        //    channels.Add(test);


        //    test = new TablueView
        //    {
        //        Channel = new TVChannel { ID = 5, Name = "Kanal 5" },
        //        Programs = new List<Program>
        //        {
        //        new Program{ID= 17,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //         new Program{ID= 18,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //          new Program{ID= 19,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //           new Program{ID= 20,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },
        //           }
        //    };
        //    channels.Add(test);

        //    return channels;
        //}

        #endregion

        #region
        public static List<TVChannel> TvChannelList()
        {
            List<TVChannel> channels = new List<TVChannel>();
            TVChannel tvChannel;


            tvChannel = new TVChannel
            {
                ID = 1,
                Name = "SVT1",
                TVPrograms = new List<Program>
                  {
                new Program{ID= 1,Title = "Bonde söker en fru",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                 new Program{ID= 2,Title = "Mästerkocken",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                  new Program{ID= 3,Title = "Dexter",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                   new Program{ID= 4,Title = "Teletubbies",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },
            }
            };
            channels.Add(tvChannel);

            tvChannel = new TVChannel
            {
                ID = 2,
                Name = "SVT2",

                TVPrograms = new List<Program> {
              new Program{ID= 5,Title = "Desperate housewives",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                new Program{ID= 6,Title = "Glamour",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                  new Program{ID= 7,Title = "Rise and fall of an empire",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Dokumentär" } } },

                   new Program{ID= 8,Title = "Most evil",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Dokumentär" } } },
                   }
            };
            channels.Add(tvChannel);


            tvChannel = new TVChannel
            {
                ID = 3,
                Name = "TV3",
                TVPrograms = new List<Program>
                {
                new Program{ID= 9,Title = "När lammen tystnar",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                 new Program{ID= 10,Title = "Du är vad du äter",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                  new Program{ID= 11,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                   new Program{ID= 12,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },
                   }
            };
            channels.Add(tvChannel);


            tvChannel = new TVChannel
            {
                ID = 4,
                Name = "TV4",
                TVPrograms = new List<Program>
                {
               new Program{ID= 13,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                 new Program{ID= 14,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                  new Program{ID= 15,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                   new Program{ID= 16,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },
                   }
            };
            channels.Add(tvChannel);


            tvChannel = new TVChannel
            {
                ID = 5,
                Name = "Kanal 5",
                TVPrograms = new List<Program>
                {
                new Program{ID= 17,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                 new Program{ID= 18,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                  new Program{ID= 19,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

                   new Program{ID= 20,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
                    Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },
                   }
            };
            channels.Add(tvChannel);

            return channels;
        }
        #endregion

        private static void AddCategory()
        {
            Category category = new Category();

            List<Category> categories = new List<Category>
            {
                new Category { ID = 1, Name = "Thriller" },
                new Category{ID=2,Name="Komedi"},
                new Category{ID=3,Name="Drama"},
                new Category{ID=4,Name="Nyheter"},
            };
        }
    }
}