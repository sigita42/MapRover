using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapRover.Models
{
    [Bind(Exclude = "CityId")]
    public class City
    {
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Population { get; set; }
        public double Size { get; set; }
        public string Picture { get; set; }
        public List<Distance> Distances { get; set; }
        public List<Airport> Airports { get; set; }
        public List<ProductInCity> ProductsInCity { get; set; }
        public Country Country { get; set; }
    }
}