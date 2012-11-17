using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapRover.Models
{
    [Bind(Exclude = "ProductId,CityId")]
    public class ProductInCity
    {
        [Key]
        [Column(Order=0)]
        public int ProductId { get; set; }
        [Key]
        [Column(Order=1)]
        public int CityId { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public City City { get; set; }
    }
}
    