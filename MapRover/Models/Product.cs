using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapRover.Models
{
    [Bind(Exclude = "ProductId")]
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public List<ProductInCity> ProductInCities { get; set; }
    }
}