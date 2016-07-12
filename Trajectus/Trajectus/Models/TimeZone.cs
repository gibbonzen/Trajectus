using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class TimeZone
    {
        public int TimeZoneID { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }

    }
}