using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;
using Trajectus.Models;

namespace Trajectus.Services
{
    public class CountryParser
    {
        private string jsonPath = @"c:\videogames.json";

        public CountryParser()
        {

        }

        private void LoadFile()
        {
            var path = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "D:\\dev\\TravelManager\\Trajectus\\Trajectus\\Ressources\\");

            string filter = "countries.json";
            string[] files = Directory.GetFiles(path, filter);
            this.jsonPath = files[0];
        }

        public List<Country>getCountries()
        {
            this.LoadFile();
            JArray jsonObject;
            using (StreamReader file = File.OpenText(this.jsonPath))
            {
                string json = file.ReadToEnd();
                jsonObject = JArray.Parse(json);
            }
            dynamic result = this.FillData(jsonObject);
            return result;
        }

        private List<Country> FillData(JArray data)
        {
            List<Country> countries = new List<Country>();

            foreach(dynamic country in data)
            {
                Country newCountry = new Country();
                newCountry.Name = country.name;
                newCountry.CapitalCity = country.capital;
                countries.Add(newCountry);
            }
            return countries;
        }
    }
}