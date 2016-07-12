using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Continent
    {
        public int ContinentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
    }
}