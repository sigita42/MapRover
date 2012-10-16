using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapRover.Models
{
    public class ProductInCity
    {
         public int ProductId { get; set; }
        public int CityId { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public City City { get; set; }
    }
}
    