using SSTV.Models.TVGuide;
using SSTV.ViewModels;
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
        //        Programs = new List<TVProgram>
        //          {
        //        new TVProgram{ID= 1,Title = "Bonde söker en fru",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //         new TVProgram{ID= 2,Title = "Mästerkocken",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //          new TVProgram{ID= 3,Title = "Dexter",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //           new TVProgram{ID= 4,Title = "Teletubbies",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },
        //    }
        //    };
        //    channels.Add(test);

        //    test = new TablueView
        //    {
        //        Channel = new TVChannel { ID = 2, Name = "SVT2" },

        //        Programs = new List<TVProgram> {
        //      new TVProgram{ID= 5,Title = "Desperate housewives",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //         new TVProgram{ID= 6,Title = "Glamour",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //          new TVProgram{ID= 7,Title = "Rise and fall of an empire",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Dokumentär" } } },

        //           new TVProgram{ID= 8,Title = "Most evil",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Dokumentär" } } },
        //           }
        //    };
        //    channels.Add(test);


        //    test = new TablueView
        //    {
        //        Channel = new TVChannel { ID = 3, Name = "TV3" },
        //        Programs = new List<TVProgram>
        //        {
        //        new TVProgram{ID= 9,Title = "När lammen tystnar",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //         new TVProgram{ID= 10,Title = "Du är vad du äter",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //          new TVProgram{ID= 11,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //           new TVProgram{ID= 12,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },
        //           }
        //    };
        //    channels.Add(test);


        //    test = new TablueView
        //    {
        //        Channel = new TVChannel { ID = 4, Name = "TV4" },
        //        Programs = new List<TVProgram>
        //        {
        //       new TVProgram{ID= 13,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //         new TVProgram{ID= 14,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //          new TVProgram{ID= 15,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //           new TVProgram{ID= 16,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },
        //           }
        //    };
        //    channels.Add(test);


        //    test = new TablueView
        //    {
        //        Channel = new TVChannel { ID = 5, Name = "Kanal 5" },
        //        Programs = new List<TVProgram>
        //        {
        //        new TVProgram{ID= 17,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //         new TVProgram{ID= 18,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //          new TVProgram{ID= 19,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },

        //           new TVProgram{ID= 20,Title = "",  Broadcasting = new DateTime(2018, 11, 05, 07, 00, 00),  Duration = 30,Informations = "This is some nice informations",
        //            Categories = new List<Category>{ new Category { ID = 1, Name = "Thriller" }, new Category { ID = 3, Name = "Drama" } } },
        //           }
        //    };
        //    channels.Add(test);

        //    return channels;
        //}

        #endregion

        #region
        public static ViewModelHome TvChannelList()
        {
            ViewModelHome vmHome = new ViewModelHome();
            List<TVChannel> channels = new List<TVChannel>();
            TVChannel tvChannel;



            tvChannel = new TVChannel
            {
                ID = 1,
                Name = "SVT1",
                TVPrograms = new List<Program> {
                    new Program{ID=1614,Title="Fresh Prince i Bel Air",Broadcasting = new DateTime(2018,11,10,06,00,00),  Duration = 25,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1615,Title="Texas Flip N Move",Broadcasting = new DateTime(2018,11,10,06,25,00),  Duration = 45,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1616,Title="Hotel Impossible",Broadcasting = new DateTime(2018,11,10,07,10,00),  Duration = 50,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1617,Title="Expedition Unknown",Broadcasting = new DateTime(2018,11,10,08,00,00),  Duration = 55,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1618,Title="Texas Flip N Move",Broadcasting = new DateTime(2018,11,10,08,55,00),  Duration = 55,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1619,Title="SOS Gute",Broadcasting = new DateTime(2018,11,10,09,50,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1620,Title="Deadliest Catch",Broadcasting = new DateTime(2018,11,10,10,50,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1621,Title="Hotel Impossible",Broadcasting = new DateTime(2018,11,10,11,50,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1622,Title="Grand Designs",Broadcasting = new DateTime(2018,11,10,12,50,00),  Duration = 65,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1623,Title="Property Brothers",Broadcasting = new DateTime(2018,11,10,13,55,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1624,Title="Arga snickaren",Broadcasting = new DateTime(2018,11,10,14,55,00),  Duration = 60,Informations = "Anders Öfvergård styr upp havererade byggprojekt och misströstande hemmafixare. Det började med drömmen om det perfekta hemmet - men slutade i ett rop på hjälp.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1625,Title="Deadliest Catch",Broadcasting = new DateTime(2018,11,10,15,55,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1626,Title="Grand Designs",Broadcasting = new DateTime(2018,11,10,16,55,00),  Duration = 65,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1627,Title="SOS Gute",Broadcasting = new DateTime(2018,11,10,18,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1628,Title="Arga snickaren",Broadcasting = new DateTime(2018,11,10,19,00,00),  Duration = 60,Informations = "Anders Öfvergård styr upp havererade byggprojekt och misströstande hemmafixare. Det började med drömmen om det perfekta hemmet - men slutade i ett rop på hjälp.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1629,Title="Gränsbevakarna Australien",Broadcasting = new DateTime(2018,11,10,20,00,00),  Duration = 30,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1630,Title="Gränsbevakarna Australien",Broadcasting = new DateTime(2018,11,10,20,30,00),  Duration = 30,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1631,Title="Criminal Minds: Beyond Borders",Broadcasting = new DateTime(2018,11,10,21,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1632,Title="Criminal Minds: Beyond Borders",Broadcasting = new DateTime(2018,11,10,22,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },
                }
            };
            vmHome.TVChannels.Add(tvChannel);

            tvChannel = new TVChannel
            {
                ID = 2,
                Name = "SVT2",

                TVPrograms = new List<Program> {
                    new Program{ID=1633,Title="Tolv ting om Finland",Broadcasting = new DateTime(2018,11,10,08,30,00),  Duration = 30,Informations = "Träffa den oemotståndliga Greta Gris och hennes fnissande grymtande fantastiska familj på deras vilda lek genom livet. Hennes äventyr slutar alltid lyckligt med grymt(!) höga skratt", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1635,Title="Forum",Broadcasting = new DateTime(2018,11,10,09,00,00),  Duration = 180,Informations = "09:00: Hets mot folkgrupp räcker lagstiftningen till? DIREKT.  Vi har de senaste åren sett en växande extremism öppet antisemitisk och rasistisk propaganda liksom återkommande nazistiska demonstrationer i våra stadskärnor. Bör lagstiftningen skärpas eller finns det oklarheter i tolkning och tillämpning? Första delen av ett längre seminarium. Arrangör: Svenska kommittén mot antisemitism (SKMA).    10:40: #metoo - Ett år senare nu tar vi nästa steg.  I Sverige fick #metoo stort genomslag genom 65 olika upprop i vitt skilda branscher. Vad blir nästa steg? Arrangör: Miljöpartiet. Från 6/11.    11:40: Jakten på den perfekta intervjun.  Vilka knep är tillåtna för att få de mest slipade kändisarna och pr-tränade intervjupersoner att öppna upp och berätta? Anna Hedenmo programledare SVT och ordförande Publicistklubben samtalar med Terje Carlsson journalist. Arrangör: Brombergs bokförlag. Från 27/9.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1638,Title="Rapport",Broadcasting = new DateTime(2018,11,10,12,00,00),  Duration = 3,Informations = "Textat sid. 199.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1639,Title="Forum",Broadcasting = new DateTime(2018,11,10,12,03,00),  Duration = 237,Informations = "12:03: Lönebildning i en ny tid.  Industrin sätter det så kallade märket i avtalsrörelsen. Krävs det en delvis ny modell för att lättare rekrytera personal till kvinnodominerade verksamheter med stor brist på arbetskraft? Nationalekonom Lars Calmfors presenterar en ny rapport som kommenteras av en ekonompanel. Arrangör: 6F och Katalys. Från 15/10.    13:20: EU-parlamentarikernas skattefria ersättning.  EU-parlamentarikerna får varje månad ca 45 000 kr till kontorsutgifter och representation utan att behöva visa upp några kvitton. Det har lett till krav på mer kontroll från vissa håll men de flesta EU-parlamentarikerna vill inte redovisa. EU-parlamentarikern Peter Lundgren SD/SCR) förklarar varför. Från 6/11.   13:35: Aktivism vs journalistik - var går gränsen?  Vad gör man när journalisten blir en del av sin egen berättelse? Annah Björk och Mattias Beijmo berättar om sitt okonventionella grävarbete med boken Båt 370 - Döden på Medelhavet. Från 27/9.   13:55: EU efter Merkel.  Tysklands förbundskansler Angela Merkel slutar som ordförande för sitt parti CDU och ställer inte upp för omval som förbundskansler. Vad händer då med balansen i EU där Tyskland varit en av frontfigurerna tillsammans med Frankrike? Diskussion med EU-parlamentarikerna Jytte Guteland (S/S&amp;D) och Gunnar Hökmark (M/EPP). Programledare: Katia Elliott. Från 6/11.   14:15: Utmaningen att regera och arbetet i opposition.  Med Anders W Jonsson (C) gruppledare i riksdagen och Anna Johansson (S) ordförande i arbetsmarknadsutskottet tidigare infrastrukturminister. Från riksdagens fortbildningsdag för lärare 31/10.   15:45: Politik i bokhyllan: Finlands bortglömda fångläger - DIREKT.  Vårt grannland har i sin moderna historia nära nog upplevt fascismen. Sirpa Kähkönen skildrar de mörka mellankrigsåren då hennes morfar var en av flera som dömdes till fängelse för sina socialistiska åsikter. Vad kan vi lära av vårt grannlands historia i en tid då högerextrema rörelser växer ute i Europa? Anita Kratz intervjuar.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1642,Title="Rapport",Broadcasting = new DateTime(2018,11,10,16,00,00),  Duration = 5,Informations = "Textat sid. 199.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1643,Title="Forum",Broadcasting = new DateTime(2018,11,10,16,05,00),  Duration = 10,Informations = "Hänt i dag.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1646,Title="Korrespondenterna",Broadcasting = new DateTime(2018,11,10,16,15,00),  Duration = 30,Informations = "Utrikesmagasin. Kriget mot sanningen. Falska nyheter skapar motsättningar i demokratiska samhällen och är direkt farliga i krigsområden. I Ukraina får invånarna hjälp att lära sig avslöja desinformation och det råder ingen brist på lögner. HD. Från 6/11 i SVT2. Även i SVT2 10/11. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1647,Title="Plus",Broadcasting = new DateTime(2018,11,10,16,45,00),  Duration = 30,Informations = "Träffa den oemotståndliga Greta Gris och hennes fnissande grymtande fantastiska familj på deras vilda lek genom livet. Hennes äventyr slutar alltid lyckligt med grymt(!) höga skratt", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1650,Title="Nyheter på lätt svenska",Broadcasting = new DateTime(2018,11,10,17,15,00),  Duration = 5,Informations = "Textat sid. 199.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1651,Title="Nyhetstecken",Broadcasting = new DateTime(2018,11,10,17,20,00),  Duration = 10,Informations = "Nyheter på teckenspråk. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1654,Title="Oddasat",Broadcasting = new DateTime(2018,11,10,17,30,00),  Duration = 15,Informations = "Samiskspråkiga nyheter.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1655,Title="Uutiset",Broadcasting = new DateTime(2018,11,10,17,45,00),  Duration = 15,Informations = "Finskspråkiga nyheter.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1658,Title="Engelska Antikrundan",Broadcasting = new DateTime(2018,11,10,18,00,00),  Duration = 60,Informations = " för att värdera och berätta om föremålen som kommer till dem. Ett spetsigt föremål som antikexperterna tror kan ha använts för att jaga undan vägfarare en ovanlig kollektion av viktorianskt kakel och en snudd på ovärderlig samling giftflaskor är några av de objekt de får nöjet att värdera idag. HD. Från SVT2 tidigare i dag.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1659,Title="Engelska Antikrundan: Arvegodsens hemligheter",Broadcasting = new DateTime(2018,11,10,19,00,00),  Duration = 30,Informations = "Brittisk antikvitetsserie från 2015. Arvegodsens hemligheter. I det här avsnittet undersöks en ring som härstammar från den kanske mest explosiva tiden i brittisk historia. När personer tar med föremål till Engelska Antikrundans experter är det inte alltid för att få en värdering. De flesta är på jakt efter svar om sin familjs historia. Vi får åter stifta bekantskap med några av föremålen och och fördjupa oss i historien kring dem. HD. Även i SVT24 senare i natt och SVT2 10/11.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1662,Title="Förväxlingen",Broadcasting = new DateTime(2018,11,10,19,30,00),  Duration = 30,Informations = "Träffa den oemotståndliga Greta Gris och hennes fnissande grymtande fantastiska familj på deras vilda lek genom livet. Hennes äventyr slutar alltid lyckligt med grymt(!) höga skratt", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1663,Title="Curiosity and control",Broadcasting = new DateTime(2018,11,10,20,00,00),  Duration = 60,Informations = " exploatering och en önskan om att bevara; den här dokumentären undersöker vår komplexa relation till naturen. I en kollageliknande film med röster från djurparkschefer historiker och arkitekter undersöks djurparkers och naturhistoriska museums mål att återkoppla människor med naturen och vår impuls att kontrollera det vi älskar. HD. Även i SVT2 11/11 och SVT2 13/11. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1666,Title="Aktuellt",Broadcasting = new DateTime(2018,11,10,21,00,00),  Duration = 18,Informations = "Textat sid. 199.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1667,Title="Kulturnyheterna",Broadcasting = new DateTime(2018,11,10,21,18,00),  Duration = 5,Informations = "Textat sid. 199.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1670,Title="Väder",Broadcasting = new DateTime(2018,11,10,21,23,00),  Duration = 2,Informations = "Textat sid. 199.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1671,Title="Lokala nyheter",Broadcasting = new DateTime(2018,11,10,21,25,00),  Duration = 5,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1674,Title="Sportnytt",Broadcasting = new DateTime(2018,11,10,21,30,00),  Duration = 14,Informations = "Senaste sportnyheterna från SVT Sport. HD. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =2, Name = "Sport" } } },

                    new Program{ID=1675,Title="Höstsonaten",Broadcasting = new DateTime(2018,11,10,21,45,00),  Duration = 100,Informations = "Svensk långfilm från 1978. Ingrid Bergman i en av sina största roller i Ingmar Bergmans starka film om uppgörelsen mellan en mor och hennes dotter. Modern den berömda konsertpianisten Charlotte", Categories = new List<Category>{ new Category { ID =1, Name = "Film" } } },

                    new Program{ID=1677,Title="Berlin - under samma himmel",Broadcasting = new DateTime(2018,11,10,23,25,00),  Duration = 50,Informations = "Tysk-engelsk dramaserie från 2017. Lauren slits mellan sina känslor för Lars och ansvaret hon känner för sin vilsne 17-årige son Emil. Det olympiska hoppet Klara konfronteras av sin syster och hennes hemliga kroppsliga förändringar avslöjas. Duncan kommer tillbaka från väst och träffar Axel i ett hemligt kärleksnäste", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },
                }
            };
            vmHome.TVChannels.Add(tvChannel);


            tvChannel = new TVChannel
            {
                ID = 3,
                Name = "Barnkanalen",
                TVPrograms = new List<Program>
                {
               new Program{ID=1678,Title="Babblarna",Broadcasting = new DateTime(2018,11,10,06,00,00),  Duration = 60,Informations = "En serie för de allra minsta med figurerna Babba, Bibbi, Bobbo, Dadda,  Diddi och Doddo. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1681,Title="Morgonshowen",Broadcasting = new DateTime(2018,11,10,07,00,00),  Duration = 120,Informations = "Textat sid. 199.", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1692,Title="Lexi och Lottie",Broadcasting = new DateTime(2018,11,10,09,00,00),  Duration = 60,Informations = "Träffa den oemotståndliga Greta Gris och hennes fnissande grymtande fantastiska familj på deras vilda lek genom livet. Hennes äventyr slutar alltid lyckligt med grymt(!) höga skratt", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1693,Title="Kapten Flinn",Broadcasting = new DateTime(2018,11,10,10,00,00),  Duration = 15,Informations = "Träffa den oemotståndliga Greta Gris och hennes fnissande grymtande fantastiska familj på deras vilda lek genom livet. Hennes äventyr slutar alltid lyckligt med grymt(!) höga skratt", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1694,Title="Katie Morag",Broadcasting = new DateTime(2018,11,10,09,00,00),  Duration = 15,Informations = " fylld av vardagligheter spännande historia och mystik. Andra säsongen. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1695,Title="Pippi Långstrump",Broadcasting = new DateTime(2018,11,10,09,15,00),  Duration = 25,Informations = " men det går bara inte. I huvudrollerna: Inger Nilsson Maria Persson och Pär Sundberg. Textat sid. 199. Nilsson Maria Persson och Pär Sundberg. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1696,Title="Octonauterna",Broadcasting = new DateTime(2018,11,10,09,40,00),  Duration = 10,Informations = "Träffa den oemotståndliga Greta Gris och hennes fnissande grymtande fantastiska familj på deras vilda lek genom livet. Hennes äventyr slutar alltid lyckligt med grymt(!) höga skratt", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1697,Title="Kate och Mim-Mim",Broadcasting = new DateTime(2018,11,10,09,50,00),  Duration = 10,Informations = "Rolig kanadensisk äventyrsserie för småbarn. Den magiska anden. Kate är en pigg och äventyrlig liten 5-åring som tillsammans med sitt gosedjur Mim-Mim hamnar på fantastiska äventyr i fantasivärlden Mimiloo. Mim-Mim kommer till liv och tillsammans med sina vänner reser de två äventyrarna på upptäcktsfärd till spännande platser för att försöka lösa förbryllande problem som Kate har stött på i den riktiga världen. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1715,Title="Ninjaman",Broadcasting = new DateTime(2018,11,10,10,00,00),  Duration = 180,Informations = " Ninjawoman. Ninjaman är stor stark och snäll. När larmet går så vet Ninjaman att barn behöver hans hjälp. Då rycker han ut och rusar blixtsnabbt till undsättning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1716,Title="Ninjaman",Broadcasting = new DateTime(2018,11,10,13,00,00),  Duration = 120,Informations = "Träffa den oemotståndliga Greta Gris och hennes fnissande grymtande fantastiska familj på deras vilda lek genom livet. Hennes äventyr slutar alltid lyckligt med grymt(!) höga skratt", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1720,Title="Lilla Aktuellt skola",Broadcasting = new DateTime(2018,11,10,15,00,00),  Duration = 15,Informations = "Direktsända nyheter för barn och ungdomar. UR. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1723,Title="MI High",Broadcasting = new DateTime(2018,11,10,15,20,00),  Duration = 30,Informations = " mycket mäktigare fiende också. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1724,Title="Hank Zipzer",Broadcasting = new DateTime(2018,11,10,15,50,00),  Duration = 25,Informations = "Hur jag körde i kemi. Hur jag körde i kemi. Henry Hank Zipzer är 12 år och dyslektiker allt är inte så lätt för honom i skolan han har dessutom en förmåga att ställa till problem... utan att egentligen mena det. Som tur är så har Hank vänner och familj som stöttar och hjälper honom så i slutänden löser han alltid sina problem... på sitt eget ofta lite speciella sätt. Säsong 1. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1725,Title="Blue water high",Broadcasting = new DateTime(2018,11,10,16,15,00),  Duration = 25,Informations = "Träffa den oemotståndliga Greta Gris och hennes fnissande grymtande fantastiska familj på deras vilda lek genom livet. Hennes äventyr slutar alltid lyckligt med grymt(!) höga skratt", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1726,Title="Jobbigt läge",Broadcasting = new DateTime(2018,11,10,16,40,00),  Duration = 30,Informations = "Träffa den oemotståndliga Greta Gris och hennes fnissande grymtande fantastiska familj på deras vilda lek genom livet. Hennes äventyr slutar alltid lyckligt med grymt(!) höga skratt", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1727,Title="Lille Roy",Broadcasting = new DateTime(2018,11,10,17,15,00),  Duration = 10,Informations = "Rapparen Roy. Rapparen Roy. Roy är 5 år och en kille med stor fantasi. Den största skillnaden mellan Roy och andra barn i hans ålder är att han är tecknad. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1728,Title="Ballonggården",Broadcasting = new DateTime(2018,11,10,17,25,00),  Duration = 10,Informations = "Varma dagen. Åsnorna Bella och Blixten bor ute på landet tillsammans med de andra ballongdjuren. Vad händer på ballonggården idag?. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1729,Title="Stella och Sam",Broadcasting = new DateTime(2018,11,10,17,35,00),  Duration = 10,Informations = " snällaste och mest nyfikna storasyster heter Stella. Hon har svar på allt till och med när hon inte vet svaret. Hon och lillebror Sam är med om fantastiska äventyr. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1730,Title="Daniel Tigers kvarter",Broadcasting = new DateTime(2018,11,10,17,45,00),  Duration = 60,Informations = " Prins Onsdag Kattis och ugglan Ho lär sig om känslor och sånt genom sång och fantasi. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1738,Title="Familjen Rysberg",Broadcasting = new DateTime(2018,11,10,18,45,00),  Duration = 30,Informations = "Svensk komediserie från 2018. Säsong 4. Drak-Olles rysliga morsa. Till Drak-Olles stora fasa kommer hans mamma på besök för första gången på hundra år. Och som om inte det var nog har hon dessutom med sig en obehaglig överraskning. Samtidigt har Vampyrella bestämt sig för att adoptera en föräldralös fladdermus. Manus och regi: Fredde Granberg och Thomas Claesson. Textat sid. 199.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1739,Title="Zombie-Lars",Broadcasting = new DateTime(2018,11,10,19,15,00),  Duration = 45,Informations = "Träffa den oemotståndliga Greta Gris och hennes fnissande grymtande fantastiska familj på deras vilda lek genom livet. Hennes äventyr slutar alltid lyckligt med grymt(!) höga skratt", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1740,Title="Grizzy och lämlarna",Broadcasting = new DateTime(2018,11,10,20,00,00),  Duration = 10,Informations = "Huslig björn. Huslig björn. Björnen Grizzy flyttar in i en övergiven skogvaktarstuga. Äntligen ska han få njuta av alla moderna bekvämligheter! Det är bara det att en stor lämmelfamilj fått samma idé.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },
                   }
            };
            vmHome.TVChannels.Add(tvChannel);



            tvChannel = new TVChannel
            {
                ID = 4,
                Name = "TV4",
                TVPrograms = new List<Program>
                {
                    new Program{ID=1741,Title="Nyhetsmorgon",Broadcasting = new DateTime(2018,11,10,05,45,00),  Duration = 255,Informations = "Direktsänt morgonprogram. Nyheter varvas med fördjupande diskussioner bevakning av de senaste trenderna personliga intervjuer kultur och sport. Programledare: Jenny Strömstedt och Steffo Törnquist. Vakna upp till Sveriges största morgonprogram Nyhetsmorgon. Se nyhetshändelser utvecklas och fördjupas trender granskas och situationer avhandlas i detta program som sänds varje dag året runt.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1742,Title="Malou efter tio",Broadcasting = new DateTime(2018,11,10,10,00,00),  Duration = 120,Informations = "Svenskt aktualitetsprogram med Malou von Sivers. Malou von Sivers bjuder in gäster till långa intervjuer starka berättelser nyfikna frågor och engagerande diskussioner. Varje dag har ett aktuellt huvudtema som tar upp allt från forskning av olika slag till relationer och kärlek. Kalle Moreaus berättar om sitt nya hälsosamma liv och Frida Zetterström visar upp höstens mode. Marcus Birro och Michaela Kälveskog pratar om psykisk ohälsa och sin relation. Andra gäster är Helena von Zweigbergk Gustav Norén och Frida Skattberg.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1743,Title="Hem till gården",Broadcasting = new DateTime(2018,11,10,12,00,00),  Duration = 30,Informations = "Brittisk dramaserie om det dagliga livet i en by i norra England. Älskad långkörare om livet i en engelsk by. Följ familjerna Sudgen Dingle och Kings levnadsöden på landsbygden. Drama kärlek och intriger utlovas i såpaklassiker som gått i rutan sedan 1972. Brenda tar ett dumdristigt beslut. Aaron gästas av en ovälkommen gäst och Megan gör en upptäckt.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1744,Title="Hem till gården",Broadcasting = new DateTime(2018,11,10,12,30,00),  Duration = 30,Informations = "Brittisk dramaserie om det dagliga livet i en by i norra England. Älskad långkörare om livet i en engelsk by. Följ familjerna Sudgen Dingle och Kings levnadsöden på landsbygden. Drama kärlek och intriger utlovas i såpaklassiker som gått i rutan sedan 1972. Aaron och Robert känner sig både förolämpade medan Daz vaknar fylld av ånger. Lachlan blir omskakad av oväntade besked.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1745,Title="Doktorn kan komma",Broadcasting = new DateTime(2018,11,10,13,00,00),  Duration = 60,Informations = "Australisk dramaserie från 1987. Om några av de människor som bor på den vidsträckta landsbygden i Australien. Det är för dessa människor som landets läkarstationer med flygplansburna läkare finns läkare som ger sig av upp i det blå och flyger långa sträckor för att snabbt nå fram till landsbygdens invånare. När Geoff får ett mystisk telefonsamtal som leder honom till Melbourne stöter han på Carbine och Pharlap Cochranes gamla mor. Hon vill till varje pris återvända till Coopers Crossing för att dö i frid.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1746,Title="Husjägarna",Broadcasting = new DateTime(2018,11,10,14,00,00),  Duration = 55,Informations = "Brittisk livsstilsserie från 2017. Mäklarna Phil Spencer och Kirstie Allsopp hjälper husletare i behov av expertis att hitta sina nya drömhem runtom i Storbritannien. Varje husjakt är en utmaning när alla har långa önskelistor stora drömmar och budgetbegränsningar. Efterfrågan är större än tillgången på Nottinghams bostadsmarknad. Phil och Kirstie breddar vyerna för två par på jakt efter ett nytt hem som båda snöat in sig på de trendigaste områdena där konkurrensen om varje hem är stenhård.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1747,Title="Bygglov",Broadcasting = new DateTime(2018,11,10,14,55,00),  Duration = 60,Informations = "Svensk bygg- och inredningsserie från 2018. Matte Carlsson Willy Björkman och arkitekten Maria Kingsley reser runt i Sverige och hjälper människor med deras bygg- eller renoveringsprojekt som havererat på grund av att pengarna eller kunskapen inte räckt till. Familjen Kelly i Jonstorp har renoverat sitt funkishus själva men tomten har de inte lyckats få fason på. Nu får de hjälp av Bygglov som lägger upp storslagna planer som visar sig bli tuffa att genomföra.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1748,Title="Veterinärerna",Broadcasting = new DateTime(2018,11,10,15,55,00),  Duration = 55,Informations = "Svensk dokumentärserie från 2018. Om veterinärer och deras dagliga arbete runt om i Sverige. De visar öppenhjärtigt upp sin vardag där de hjälper djur som skadat sig eller blivit sjuka. Veterinärerna möter många olika typer av djur både stora och små och får ta del av deras ägares berättelser. Schäfern Zacko ska genomgå en titthålsoperation på Väsby djursjukhus. Mälaren smådjursklinik får besök av gerbilerna Pysen och Ekorren som den senaste tiden varit trötta och slöa. I Skåne gör parkens pilgrimsfalk en friflygning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1749,Title="Renées brygga",Broadcasting = new DateTime(2018,11,10,16,50,00),  Duration = 60,Informations = "Svensk underhållning från 2018 med Renée Nyberg. Renée Nyberg bjuder in kända och intressanta svenskar som hon är nyfiken på att lära känna mer till en ö i Stockholms skärgård. Det blir förtroliga samtal om livet men också mycket skratt och upptåg. Säsongsavslutning. Renée får besök av Bahar Pars Jonas Björkman och Måns Zelmerlöw. Måns berättar om hur han tog mod till sig att fria till kvinnan i sitt liv och Bahar om hur hon träffade maken Linus Tunström.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1750,Title="V75-klubben",Broadcasting = new DateTime(2018,11,10,17,50,00),  Duration = 5,Informations = "Travmagasin. Här får tittare chansen att komma till studion och vinna på Top 7 spelet. Ett lotterihjul avgör sedan hur stor Top 7-spelet blir. Vinnaren kan sedan dubbla sin vinst genom ett Harryboy-system. En tittare får chansen att komma till studion och vinna på Top 7-spelet på upp till 9000 kronor. Hur stor Top 7-spelet blir avgöras av ett lotterihjul. Vinnaren kan sedan dubbla sin vinst genom ett Harryboy-system.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1751,Title="Bachelor - kom ikapp",Broadcasting = new DateTime(2018,11,10,17,55,00),  Duration = 55,Informations = "Här summeras de tio första avsnitten och vi återser de största ögonblicken av kärleksäventyret. Massvis med smaskiga detaljer kommer för den som väntar på något gott. Var den där romantiska dejten egentligen så härlig? Hur gick Davids tankar?", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1752,Title="Keno",Broadcasting = new DateTime(2018,11,10,18,50,00),  Duration = 10,Informations = "Redovisning av dagens Kenodragning.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1753,Title="TV4Nyheterna",Broadcasting = new DateTime(2018,11,10,19,00,00),  Duration = 15,Informations = "Nyheter från TV4. Varje nyhetssändning profileras av ett huvudankare. Håll dig uppdaterad med kvällens nyheter. TV4Nyheterna sänder nyheter dygnet runt året om. Varje nyhetssändning profileras av ett huvudankare.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1754,Title="Sporten",Broadcasting = new DateTime(2018,11,10,19,15,00),  Duration = 5,Informations = "Sportnyheter. Det senaste inom sportnyheter.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1755,Title="TV4Vädret",Broadcasting = new DateTime(2018,11,10,19,20,00),  Duration = 10,Informations = "Väderprognos. Väderprognos. Håll dig uppdaterad med det senaste vädret där just du är! Håll dig uppdaterad med det senaste vädret. Väderprognosen presenteras av meteorologerna på TV4.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1756,Title="Drömpyramiden",Broadcasting = new DateTime(2018,11,10,19,30,00),  Duration = 30,Informations = "Svenskt underhållningsprogram från 2018. Här tävlar par i att försöka svara rätt på så många frågor i rad som möjligt. Målet är att klättra i en pyramid av containrar där fem av dem innehåller otroliga priser för hela familjen. Programledare är Rickard Sjöberg. Här tävlar par i att försöka svara rätt på så många frågor i rad som möjligt och klättra i en pyramid fylld av priser.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1757,Title="Idol 2018",Broadcasting = new DateTime(2018,11,10,20,00,00),  Duration = 90,Informations = "Svenskt underhållningsprogram från 2018. Svenskt underhållningsprogram från 2018. Idol är Sveriges största talangjakt där hoppfulla talanger kan förverkliga sina drömmar. Här följs framtidens stjärnor från sitt första möte med juryn genom kvalomgångar och fredagsfinaler till den stora finalen. Idolernas mammor och pappor väljer låtarna det blir en blandad repertoar med sånger av artister som Elton John Tommy Nilsson Shania Twain Peter Jöback och The Beatles. Dessutom får vi njuta av Idol-föräldrarnas stämmor i öppningsnumret.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1758,Title="Mumbo jumbo",Broadcasting = new DateTime(2018,11,10,21,30,00),  Duration = 30,Informations = "Svenskt humorprogram från 2018. Svenskt veckoaktuellt humorprogram som skojar om vår populärkulturella samtid med träffsäkra imitationer och höga frisyrer. Se klockrena sketcher och parodier med Daniel Norberg Shanthi Rydwall-Menon Louise Nordahl och Christian Åkesson. Hellenius hörna parodieras och gästas av Bianca Ingrosso och Felix Herngren. Kristian Luuk får svar i Fråga Lund och Petra Mede leder tv-galan Guldegot. Dessutom brister den konservativa kören Förnekelsearmén ut i en sång om klimathotet.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1759,Title="TV4Nyheterna och Sporten",Broadcasting = new DateTime(2018,11,10,22,00,00),  Duration = 15,Informations = "Nyheter och sport. Nyheter och sport.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1760,Title="TV4Vädret",Broadcasting = new DateTime(2018,11,10,22,15,00),  Duration = 10,Informations = "Väderprognos från TV4. Väderprognosen presenteras av meteorologerna på TV4. Väderprognosen presenteras av meteorologerna på TV4.", Categories = new List<Category>{ new Category { ID =4, Name = "Nyheter" } } },

                    new Program{ID=1761,Title="Idol 2018 - resultatshow",Broadcasting = new DateTime(2018,11,10,22,25,00),  Duration = 20,Informations = "Svenskt underhållningsprogram från 2018. Röstningsresultatet i Idol presenteras. Rafflande spänning och nervösa deltagare. Nu har det blivit dags för röstningsresultatet att presenteras. Vem får fortsätta sin artistresa och vem får lämna tävlingen?", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1762,Title="Idol Extra",Broadcasting = new DateTime(2018,11,10,22,45,00),  Duration = 25,Informations = "Svenskt underhållningsprogram från 2018. Det bjuds på intervjuer eftersnack och analyser tillsammans med journalister bloggare jurymedlemmar och tävlande. Det bjuds på intervjuer eftersnack och analyser tillsammans med journalister bloggare jurymedlemmar och tävlande.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1763,Title="Ben-Hur",Broadcasting = new DateTime(2018,11,10,23,10,00),  Duration = 150,Informations = "Judah Ben-Hur är en högtstående judisk man under antiken som blir falskt anklagad för förräderi av sin adopterade bror romaren Messala och tvingas iväg från sitt hem. Den stolte Judah vägrar dock att ge upp och han blir besatt av att rentvå sitt namn.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },
                   }
            };
            vmHome.TVChannels.Add(tvChannel);



            tvChannel = new TVChannel
            {
                ID = 5,
                Name = "Kanal 5",
                TVPrograms = new List<Program>
                {
                    new Program{ID=1532,Title="Railroad Alaska",Broadcasting = new DateTime(2018,11,10,07,10,00),  Duration = 50,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1533,Title="Tunnelbanan",Broadcasting = new DateTime(2018,11,10,08,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1534,Title="Trafikpoliserna Köpenhamn",Broadcasting = new DateTime(2018,11,10,09,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1535,Title="Top Chef Masters",Broadcasting = new DateTime(2018,11,10,10,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1536,Title="Grey's Anatomy",Broadcasting = new DateTime(2018,11,10,11,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1537,Title="Sofias änglar",Broadcasting = new DateTime(2018,11,10,12,00,00),  Duration = 60,Informations = "Sofias änglar hjälper familjer som hamnat i svåra situationer i livet. Med sina olika kunskaper ordnar de praktikaliteter som gör livet lite enklare. Johnnie och Mattias hjälper familjerna med sina hem och Sofia med annat som kommit på undantag när en sjuk familjemedlem olyckor eller annat hade kommit i vägen för det liv man egentligen hade tänkt sig.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1538,Title="Andarnas makt Norge",Broadcasting = new DateTime(2018,11,10,13,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1539,Title="Ullared",Broadcasting = new DateTime(2018,11,10,14,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1540,Title="The Big Bang Theory",Broadcasting = new DateTime(2018,11,10,15,00,00),  Duration = 30,Informations = "Leonard och Sheldon är två supersmarta nördar som vet allt om hur universum funkar men inte hur man talar med en kvinna. Allting förändras när den vackra Penny flyttar in i lägenheten mitt emot och en ny värld öppnar sig för dem.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1541,Title="The Big Bang Theory",Broadcasting = new DateTime(2018,11,10,15,30,00),  Duration = 30,Informations = "Leonard och Sheldon är två supersmarta nördar som vet allt om hur universum funkar men inte hur man talar med en kvinna. Allting förändras när den vackra Penny flyttar in i lägenheten mitt emot och en ny värld öppnar sig för dem.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1542,Title="Sofias änglar",Broadcasting = new DateTime(2018,11,10,16,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1543,Title="Tunnelbanan",Broadcasting = new DateTime(2018,11,10,17,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1544,Title="Ullared",Broadcasting = new DateTime(2018,11,10,18,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1545,Title="The Big Bang Theory",Broadcasting = new DateTime(2018,11,10,19,00,00),  Duration = 30,Informations = "Leonard och Sheldon är två supersmarta nördar som vet allt om hur universum funkar men inte hur man talar med en kvinna. Allting förändras när den vackra Penny flyttar in i lägenheten mitt emot och en ny värld öppnar sig för dem.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1546,Title="Tunnelbanan",Broadcasting = new DateTime(2018,11,10,20,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1547,Title="Wahlgrens värld",Broadcasting = new DateTime(2018,11,10,21,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1548,Title="Breaking Nyheter med Filip &amp; Fredrik",Broadcasting = new DateTime(2018,11,10,22,00,00),  Duration = 60,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1549,Title="The Big Bang Theory",Broadcasting = new DateTime(2018,11,10,23,00,00),  Duration = 30,Informations = "Leonard och Sheldon är två supersmarta nördar som vet allt om hur universum funkar men inte hur man talar med en kvinna. Allting förändras när den vackra Penny flyttar in i lägenheten mitt emot och en ny värld öppnar sig för dem.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1550,Title="The Big Bang Theory",Broadcasting = new DateTime(2018,11,10,23,30,00),  Duration = 30,Informations = "Leonard och Sheldon är två supersmarta nördar som vet allt om hur universum funkar men inte hur man talar med en kvinna. Allting förändras när den vackra Penny flyttar in i lägenheten mitt emot och en ny värld öppnar sig för dem.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },
                   }
            };
            vmHome.TVChannels.Add(tvChannel);


            tvChannel = new TVChannel
            {
                ID = 6,
                Name = "Nickelodeon",
                TVPrograms = new List<Program>
                {
                    new Program{ID=1563,Title="Greta Gris Maraton",Broadcasting = new DateTime(2018,11,10,05,00,00),  Duration = 120,Informations = "Träffa den oemotståndliga Greta Gris och hennes fnissande grymtande fantastiska familj på deras vilda lek genom livet. Hennes äventyr slutar alltid lyckligt med grymt(!) höga skratt", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1577,Title="SvampBob Fyrkant",Broadcasting = new DateTime(2018,11,10,07,00,00),  Duration = 29,Informations = "SvampBob Fyrkant är en tecknad serie med Gulahavs-svampen SvampBob i huvudrollen. SvampBob bor djupt ned i havet i en stad som heter Bikinibotten. Tillsammans med sin kompis den rosa sjöstjärnan Patrik får han uppleva dom mest galna och spännande äventyr man kan tänka sig. SvampBob är en väldigt intensiv och optimistisk karaktär han arbetar på restaurangen den krångliga Krabban där han steker dom godaste burgarna i hela Gula Havet.", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1579,Title="Alvinnn!!! Och Gänget",Broadcasting = new DateTime(2018,11,10,07,30,00),  Duration = 29,Informations = "Ekorrarna är som helt vanliga ungar. De går i skolan hjälper till hemma gör sina läxor och bråkar som syskon gör men ger stora konserter för miljontals fans. Åh nämnde vi att de är internationella rockstjärnor?", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1583,Title="My Little Pony",Broadcasting = new DateTime(2018,11,10,08,00,00),  Duration = 48,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1585,Title="My Little Pony",Broadcasting = new DateTime(2018,11,10,08,50,00),  Duration = 24,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1586,Title="Kid Dangers äventyr",Broadcasting = new DateTime(2018,11,10,09,15,00),  Duration = 19,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1587,Title="Lugn i stormen",Broadcasting = new DateTime(2018,11,10,09,35,00),  Duration = 24,Informations = "Har du någonsin undrat över hur det är att växa upp i en stor familj? Elvaårige Lincoln bjuder tittarna på en kaotisk inblick i hur det är att växa upp med tio systrar!", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1588,Title="Rise Of The Teenage Mutant Ninja Turtles",Broadcasting = new DateTime(2018,11,10,10,00,00),  Duration = 24,Informations = "Rise up! Teenage Mutant Ninja Turtles är tillbaka och den här gången har de häftiga nya krafter! Häng med Raph Leo Donnie och Mikey när de bemästrar nya vapen slåss mot absurda mutanter och upptäcker en Dold Stad under New York. Cowabunga!  !", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1589,Title="The Fairly OddParents",Broadcasting = new DateTime(2018,11,10,10,25,00),  Duration = 29,Informations = "Om du är Timmy Turner behöver du bara be dina magiska mystiska och helt galna goda fé-föräldrar om hjälp. Men när gudföräldrarna är så knäppa som Cosmo och Wanda får du kanske mer av deras hjälp än du bad om!", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1590,Title="The Fairly OddParents",Broadcasting = new DateTime(2018,11,10,10,55,00),  Duration = 29,Informations = "Om du är Timmy Turner behöver du bara be dina magiska mystiska och helt galna goda fé-föräldrar om hjälp. Men när gudföräldrarna är så knäppa som Cosmo och Wanda får du kanske mer av deras hjälp än du bad om!", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1591,Title="Henry Danger",Broadcasting = new DateTime(2018,11,10,11,25,00),  Duration = 34,Informations = "Träffa den oemotståndliga Greta Gris och hennes fnissande grymtande fantastiska familj på deras vilda lek genom livet. Hennes äventyr slutar alltid lyckligt med grymt(!) höga skratt", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1592,Title="Hunters hemlighet",Broadcasting = new DateTime(2018,11,10,12,00,00),  Duration = 119,Informations = "När Hunter-syskonens föräldrar plötsligt försvinner är det upp till de fem barnen att lösa mysteriet bakom försvinnandet. Samtidigt måste de göra allt de kan för att ingen ska misstänka att något är fel.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1595,Title="Hunters hemlighet",Broadcasting = new DateTime(2018,11,10,14,00,00),  Duration = 119,Informations = "När Hunter-syskonens föräldrar plötsligt försvinner är det upp till de fem barnen att lösa mysteriet bakom försvinnandet. Samtidigt måste de göra allt de kan för att ingen ska misstänka att något är fel.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1602,Title="HartBeat",Broadcasting = new DateTime(2018,11,10,16,00,00),  Duration = 84,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1603,Title="Lip Sync Battle Shorties - Nick",Broadcasting = new DateTime(2018,11,10,17,25,00),  Duration = 24,Informations = "Det finns ingen beskrivning.", Categories = new List<Category>{ new Category { ID =3, Name = "Serie" } } },

                    new Program{ID=1604,Title="Game Shakers",Broadcasting = new DateTime(2018,11,10,17,50,00),  Duration = 24,Informations = "Babe och Kenzie lyckas tillsammans skapa ett nytt mobilspel som snart visar sig vara ett av de mest populära spelen någonsin. Tillsammans med deras vän Hudson den berömda rapparen Double G och hans son Triple G startar de spelföretaget Game Shakers. Men nu måste tjejerna försöka lyckas med att både utveckla nya spel och samtidigt sköta sina läxor!", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1605,Title="Game Shakers",Broadcasting = new DateTime(2018,11,10,18,15,00),  Duration = 19,Informations = "Babe och Kenzie lyckas tillsammans skapa ett nytt mobilspel som snart visar sig vara ett av de mest populära spelen någonsin. Tillsammans med deras vän Hudson den berömda rapparen Double G och hans son Triple G startar de spelföretaget Game Shakers. Men nu måste tjejerna försöka lyckas med att både utveckla nya spel och samtidigt sköta sina läxor!", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1606,Title="Game Shakers",Broadcasting = new DateTime(2018,11,10,18,35,00),  Duration = 24,Informations = "Babe och Kenzie lyckas tillsammans skapa ett nytt mobilspel som snart visar sig vara ett av de mest populära spelen någonsin. Tillsammans med deras vän Hudson den berömda rapparen Double G och hans son Triple G startar de spelföretaget Game Shakers. Men nu måste tjejerna försöka lyckas med att både utveckla nya spel och samtidigt sköta sina läxor!", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1609,Title="Zoey 101",Broadcasting = new DateTime(2018,11,10,19,55,00),  Duration = 29,Informations = "Det är dags för Zoey att börja sitt andra år på internatskolan Pacific Coast Academy. Ett nytt år innebär nya lektioner nya spännande äventyr nya vänner och en ny kompis att dela rum med.", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1610,Title="Värsta Pranket!",Broadcasting = new DateTime(2018,11,10,20,25,00),  Duration = 24,Informations = "Tre prank-älskande ungar sätts ihop var och en med ett gäng specialeffektsmästare från Hollywood som kallas Effektmakarna. Varje duo ska utföra ett otroligt dolda kameran-prank. Det barn som får flest röster för sitt prank får möjligheten att utsätta sin familj för det ultimata hjärnsmältande pranket.", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1612,Title="Värsta Pranket!",Broadcasting = new DateTime(2018,11,10,21,15,00),  Duration = 29,Informations = "Tre prank-älskande ungar sätts ihop var och en med ett gäng specialeffektsmästare från Hollywood som kallas Effektmakarna. Varje duo ska utföra ett otroligt dolda kameran-prank. Det barn som får flest röster för sitt prank får möjligheten att utsätta sin familj för det ultimata hjärnsmältande pranket.", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },

                    new Program{ID=1613,Title="Ned's Declassified",Broadcasting = new DateTime(2018,11,10,21,45,00),  Duration = 14,Informations = "Eftersom Ned har bestämt sig för att gilla skolan och tiden där har han skapat den ultimata överlevndas-guiden - full av tips och trix! Han ska besegra alla nerviga och otäckt pinsamma situationer som alla högstadie-elever möter dagligen.Ned och hans två bästa polare Cookie och Moze har bestämt sig för att ta hand om alla svindlande skol-tankar.Så alla förälskelser elevskåp och översittare är ingenting för Ned. Inte så ofta i allfall...Nu pratar alla i serien svenska!!!", Categories = new List<Category>{ new Category { ID =5, Name = "Barn" } } },
                   }
            };
            vmHome.TVChannels.Add(tvChannel);

            return vmHome;
        }
        #endregion

        public static List<Category> AddCategories()
        {
            Category category = new Category();

            List<Category> categories = new List<Category>
            {
                new Category { ID = 1, Name = "Film" },
                new Category{ID=2,Name="Sport"},
                new Category{ID=3,Name="Serie"},
                new Category{ID=4,Name="Nyheter"},
                new Category{ID=5,Name="Barn"},

            };

            return categories;
        }
    }
}