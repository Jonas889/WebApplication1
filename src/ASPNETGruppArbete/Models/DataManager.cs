using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASPNETGruppArbete.Models
{
    public class DataManager
    {
        static List<Band> bands = new List<Band>();
        static List<Album> albums = new List<Album>();

        static DataManager()
        {
            bands.Add(new Band { Id = 1, BandName = "Foo Fighters", Description = "Foo Fighters är en amerikansk rockgrupp bildad 1994 i Seattle. Bandet bildades som ett soloprojekt av Dave Grohl efter den drastiska upplösningen av den populära grungegruppen Nirvana men kom ganska snart att stadga sig som ett komplett band." });

            albums.Add(new Album { Titel = "Foo FIghters", Year = 1995, Bid = 1, Aid = 1 });
            albums.Add(new Album { Titel = "The Colour And The Shape", Year = 1997, Bid = 1, Aid = 2 });
            albums.Add(new Album { Titel = "There Is Nothing Left To Loose", Year = 1999, Bid = 1, Aid = 3 });
            albums.Add(new Album { Titel = "One By One", Year = 2002, Bid = 1, Aid = 4 });
            albums[0].SongsDuration = new string[14, 2]
            {
                { "This Is a Call", "3:53"},
                { "I'll Stick Around","3:52"},
                { "Big Me", "2:12"},
                { "Alone + Easy Target", "4:05"},
                { "Good Grief","4:01"},
                { "Floaty","4:30"},
                { "Weenie Beenie", "2:45"},
                { "Oh, George", "3:00"},
                { "For All the Cows","3:30"},
                { "X-Static", "4:13"},
                { "Wattershed","2:15"},
                { "Exhausted", "5:45"},
                { "Winnebago (bonusspår på den japanska utgåvan)","4:14"},
                { "Podunk (bonusspår på den japanska utgåvan)","3:03" }
            };
            albums[1].SongsDuration = new string[3, 2]
            {
                { "Låt 1","4:00" },
                { "låt 2","4:00" },
                { "låt 3","4:00" },
            };
            albums[2].SongsDuration = new string[3, 2]
            {
                { "Låt 1","4:00" },
                { "låt 2","4:00" },
                { "låt 3","4:00" },
            };
            albums[3].SongsDuration = new string[3, 2]
            {
                { "Låt 1","4:00" },
                { "låt 2","4:00" },
                { "låt 3","4:00" },
            };
        }

        public Band[] GetAllBands()
        {
            return bands.ToArray();
        }

        public Album[] GetBandAlbums(int id)
        {
            return albums
                .Where(a => a.Bid == id)
                .OrderByDescending(a => a.Year)
                .ToArray();
        }
        public string[,] GetAlbumDetails(int id)
        {
            return albums
                .Single(a => a.Aid == id)
                .SongsDuration;
        }
    }
}
