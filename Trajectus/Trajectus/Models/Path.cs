using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Path
    {
        public int PathID { get; set; }

        public City StartCity { get; set; }
        public City StopCity { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime StopDateTime { get; set; }

        public short Distance { get; set; }

        public int Index { get; set; }

    }
}