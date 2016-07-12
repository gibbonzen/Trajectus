using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Language
    {
        public int LanguageID { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}