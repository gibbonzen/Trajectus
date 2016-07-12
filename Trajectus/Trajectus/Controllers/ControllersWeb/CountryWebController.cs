using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Trajectus.Business;
using Trajectus.Controllers.ControllersWeb;
using Trajectus.Models;

namespace Trajectus.Controllers.ControllersWeb
{
    public class CountryWebController : ApiController
    {
        // GET: api/CountryWeb
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CountryWeb/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CountryWeb
        public void Post([FromBody] List<CountryWeb> countriesWeb)
        {
            CountryConverter CC = new CountryConverter();

            List<Country> countries = new List<Country>();
            foreach (var item in countriesWeb)
            {
                Country cC = CC.Convert<Country, CountryWeb>(item);
                countries.Add(cC);
            }

        }

        // PUT: api/CountryWeb/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CountryWeb/5
        public void Delete(int id)
        {
        }
    }
}
