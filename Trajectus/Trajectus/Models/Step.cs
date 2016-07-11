using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Step
    {
        public string Name { get; set; }
        public int Index { get; set; }

        public City City { get; set; }
        public TimeSpan Duration { get; set; }

    }
}