﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double GoldAveragePerDay { get; set; }
        public string Currency { get; set; }
        public string Language { get; set; }
        public string CapitalCity { get; set; }

    }
}