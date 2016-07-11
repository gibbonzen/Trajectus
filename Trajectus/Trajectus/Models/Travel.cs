using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trajectus.Models;

namespace Trajectus.Models
{
    public class Travel
    {
        public string Name { get; set; }

        public int Travelers { get; set; }
        public string Description { get; set; }

        public User Owner { get; set; }

        public Route Route { get; set; }

    }
}