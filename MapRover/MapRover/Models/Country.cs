using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapRover.Models
{
    [Bind(Exclude = "CountryId")]
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Cheers { get; set; }
        public int CurrencyId { get; set; }
        public List<City> Cities { get; set; }
        public List<NeighbourCountry> NeighbourCountries { get; set; }
        public Currency Currency { get; set; }
    }
}