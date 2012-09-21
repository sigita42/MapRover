using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapRover.Models
{
    [Bind(Exclude = "NeighbourCountryId")]
    public class NeighbourCountry
    {
        public int NeighbourCountryId { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}