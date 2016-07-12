using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CapitalCity { get; set; }
        [Required]
        public List<string> Currencies { get; set; }
        [Required]
        public List<object> Languages { get; set; }
        public int Population { get; set; }
        public List<string> CallingCode { get; set; }
        public List<string> TimeZones { get; set; }
        public double GoldAveragePerDay { get; set; }        


    }
}