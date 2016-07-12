using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    public class Currency
    {
        public int CurrencyID { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}