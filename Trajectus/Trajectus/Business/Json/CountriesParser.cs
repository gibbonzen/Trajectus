using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Trajectus.Models;

namespace Trajectus.Business.Json
{
    public class CountriesParser
    {

        public string COUNTRIES_PATH = "";

        public CountriesParser()
        {

        }

        public void LoadData()
        {

        }

        private string LoadFile(string filename)
        {
            string json;
            using (var sr = new StreamReader(filename))
            {
                json = sr.ReadToEnd();
            }
            return json;
        }

        private void LoadWebService()
        {
            throw new NotImplementedException();
        }

        private void ParseFile(string jsonString)
        {
            JArray jsonVal = JArray.Parse(jsonString) as JArray;
            List<Country> Countries = new List<Country>();

            foreach (dynamic country in jsonVal)
            {
                Country newCountry = new Country();
                newCountry.Name = country.name;
            }
        }

        

    }
}