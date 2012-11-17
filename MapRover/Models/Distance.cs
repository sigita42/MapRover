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
        [Key]
        [Column(Order=0)]
        public int IdCityA { get; set; }
        [Key]
        [Column(Order=1)]
        public int IdCityB { get; set; }
        public double Value { get; set; }
        public City CityA { get; set; }
        public City CityB { get; set; }
    }
}