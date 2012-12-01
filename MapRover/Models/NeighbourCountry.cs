using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapRover.Models
{
    [Bind(Exclude = "IdContryA,IdCountryB")]
    public class NeighbourCountry
    {
        public NeighbourCountry() { }

        [Key]
        [Column(Order = 0)]
        public int IdCountryA { get; set; }
        [Key]
        [Column(Order = 1)]
        public int IdCountryB { get; set; }
        public Country CountryA { get; set; }
        public Country CountryB { get; set; }
    }
}

