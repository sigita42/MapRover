using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapRover.Models
{
    //[Bind(Exclude = "ProductId")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public List<ProductInCity> ProductInCities { get; set; }

        public string ProductName { get; set; }
    }
}