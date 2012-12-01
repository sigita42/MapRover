using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapRover.Models
{
    [Bind(Exclude = "IdCityA,IdCityB")]
    public class Distance
    {
        public const int RadiusOfEarthInKm = 6371;

        public Distance() { }

        public Distance(City cityA, City cityB)
        {
            CityA = cityA;
            CityB = cityB;
            IdCityA = CityA.CityId;
            IdCityB = CityB.CityId;

            Value = CalculateDistanceBetweenCities();
        }

        [Key]
        [Column(Order = 0)]
        public int IdCityA { get; set; }
        [Key]
        [Column(Order = 1)]
        public int IdCityB { get; set; }
        public double Value { get; set; }
        public City CityA { get; set; }
        public City CityB { get; set; }

        /// <summary>
        /// Calculates the distance between CityA and CityB based on the Haversine formula (http://en.wikipedia.org/wiki/Haversine_formula)
        /// </summary>
        /// <returns></returns>
        private double CalculateDistanceBetweenCities()
        {
            double cityALatRadians = CityA.Lat * (Math.PI / 180.0);
            double cityALngRadians = CityA.Lng * (Math.PI / 180.0);
            double cityBLatRadians = CityB.Lat * (Math.PI / 180.0);
            double cityBLngRadians = CityB.Lng * (Math.PI / 180.0);

            double distanceLat = cityALatRadians - cityBLatRadians;
            double distanceLng = cityALngRadians - cityBLngRadians;

            // Intermediate result a.
            double a = Math.Pow(Math.Sin(distanceLat / 2.0), 2.0) +
                       Math.Cos(cityALatRadians) * Math.Cos(cityBLatRadians) *
                       Math.Pow(Math.Sin(distanceLng / 2.0), 2.0);

            // Intermediate result c (great circle distance in Radians).
            double c = 2.0 * Math.Asin(Math.Sqrt(a));

            // Distance
            return RadiusOfEarthInKm * c;
        }
    }
}