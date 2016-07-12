using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class City : BaseLocalisable
    {
        public int CityID { get; set; }
        [Required]
        public string Name { get; set; }

        public int CountryID { get; set; }
    }
}