using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public double GoldAveragePerDay { get; set; }
        public string Currency { get; set; }

        public string Language { get; set; }

        public int Population { get; set; }

        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public string CapitalCity { get; set; }
    }
}