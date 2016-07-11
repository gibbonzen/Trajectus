using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Path
    {
        public int PathID { get; set; }

        public City StartCity { get; set; }
        public City StopCity { get; set; }

        [Required]
        public DateTime StartDateTime { get; set; }
        [Required]
        public DateTime StopDateTime { get; set; }

        [Required]
        public short Distance { get; set; }

        [Required]
        public int Index { get; set; }

    }
}