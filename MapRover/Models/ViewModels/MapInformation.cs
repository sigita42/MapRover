using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapRover.Models.ViewModels
{
    public class MapInformation
    {
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<Airport> Airports { get; set; }
        public IEnumerable<Distance> Distances { get; set; }
        public IEnumerable<NeighbourCountry> NeighbourCountries { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductInCity> ProductsInCities { get; set; }
    }
}