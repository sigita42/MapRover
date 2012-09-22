using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapRover.Models
{
    [Bind(Exclude = "IdCityA,IdCityB")]
    public class Distance
    {
        public int IdCityA { get; set; }
        public int IdCityB { get; set; }
        public double Value { get; set; }
        public City CityA { get; set; }
        public City CityB { get; set; }
    }
}