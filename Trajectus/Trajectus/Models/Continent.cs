using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Continent
    {
        public string Name { get; set; }
        public List<Country> Countries { get; set; }
    }
}