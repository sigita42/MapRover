﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapRover.Models
{
    //[Bind(Exclude = "ProductId,CityId")]
    public class ProductInCity
    {
        public City City { get; set; }

        [Key]
        [Column(Order = 1)]
        public int CityId { get; set; }

        public double Price { get; set; }

        public Product Product { get; set; }

        [Key]
        [Column(Order = 0)]
        public int ProductId { get; set; }
    }
}