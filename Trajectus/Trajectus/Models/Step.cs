using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Step
    {
        public int StepID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int Index { get; set; }

        [Required]
        public City City { get; set; }
        public TimeSpan Duration { get; set; }

    }
}