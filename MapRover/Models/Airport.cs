﻿using System;
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
        public int CityId { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}