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
        public List<Currency> Currencies { get; set; }
        [Required]
        public List<Language> Languages { get; set; }
        public int Population { get; set; }
        public string CallingCode { get; set; }
        public List<TimeZone> TimeZones { get; set; }
        public double GoldAveragePerDay { get; set; }        
    }
}