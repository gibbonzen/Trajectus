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
        public string Code { get; set; }
        public double GoldAveragePerDay { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public City CapitalCity { get; set; }

    }
}