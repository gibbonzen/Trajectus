using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trajectus.Models
{
    //public class CountryWeb
    //{
    //    public string Name { get; set; }
    //    public string Capital { get; set; }
    //    public List<string> AltSpellings { get; set; }
    //    public int Relevance { get; set; }
    //    public string Region { get; set; }
    //    public string SubRegion { get; set; }
    //    public Dictionary<string, string> Translations { get; set; }
    //    public long Population { get; set; }
    //    public List<int> Latlng { get; set; }
    //    public string Demonym { get; set; }
    //    public int Area { get; set; }
    //    public int Gini { get; set; }
    //    public List<string> TimeZones { get; set; }
    //    public List<string> Borders { get; set; }
    //    public string NativeName { get; set; }
    //    public string CallingCode { get; set; }
    //    public List<string> TopLevelDomain { get; set; }
    //    public string Alpha2Code { get; set; }
    //    public string Alpha3code { get; set; }
    //    public List<string> Currencies { get; set; }
    //    public List<string> Languages { get; set; }
    //}

    public class Translations
    {
        public string de { get; set; }
        public string es { get; set; }
        public string fr { get; set; }
        public string ja { get; set; }
        public string it { get; set; }
    }

    public class CountryWeb
    {
        public string name { get; set; }
        public string capital { get; set; }
        public List<string> altSpellings { get; set; }
        public string relevance { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public Translations translations { get; set; }
        public int population { get; set; }
        public List<object> latlng { get; set; }
        public string demonym { get; set; }
        public double? area { get; set; }
        public double? gini { get; set; }
        public List<string> timezones { get; set; }
        public List<object> borders { get; set; }
        public string nativeName { get; set; }
        public List<string> callingCodes { get; set; }
        public List<string> topLevelDomain { get; set; }
        public string alpha2Code { get; set; }
        public string alpha3Code { get; set; }
        public List<string> currencies { get; set; }
        public List<object> languages { get; set; }
    }

}
