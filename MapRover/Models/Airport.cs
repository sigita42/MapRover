using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapRover.Models
{
    [Bind(Exclude = "AirportId")]
    public class Airport
    {
        public int AirportId { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
    }
}