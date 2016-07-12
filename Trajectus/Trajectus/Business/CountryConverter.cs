using System;
using Trajectus.Models;

namespace Trajectus.Business
{
    public class CountryConverter : IWebConvertible<Country, CountryWeb>
    {
        public T Convert<T, U>(U webModel)
        {
            var cw = (CountryWeb)System.Convert.ChangeType(webModel, typeof(CountryWeb));
            var c = new Country()
            {
                Name = cw.name,
                CapitalCity = cw.capital,
                Currencies = cw.currencies,
                Languages = cw.languages,
                Population = cw.population,
                CallingCode = cw.callingCodes,
                TimeZones = cw.timezones
            };
            return (T) System.Convert.ChangeType(c, typeof(T));
        }
    }
}