using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Route
    {
        public int RouteID { get; set; }

        [Required]
        public ICollection<Step> Steps { get; set; }
        [Required]
        public ICollection<Path> Paths { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? StopDate { get; set; }

    }
}