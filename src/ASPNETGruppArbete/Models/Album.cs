using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETGruppArbete.Models
{
    public class Album
    {
        public string Titel { get; set; }
        public int Year { get; set; }
        public int Bid { get; set; }
        public int Aid { get; set; }
        public string[,] SongsDuration { get; set; }

    }
}
