using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Route
    {
        public int RouteID { get; set; }

        public ICollection<Step> Steps { get; set; }
        public ICollection<Path> Paths { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? StopDate { get; set; }

    }
}