using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapRover.Models
{
    //[Bind(Exclude = "CityId")]
    public class City
    {
        public List<Airport> Airports { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        public Country Country { get; set; }

        public int CountryId { get; set; }

        public string Description { get; set; }

        public List<Distance> Distances { get; set; }

        public double Lat { get; set; }

        public double Lng { get; set; }

        public string Name { get; set; }

        public string Picture { get; set; }

        public int Population { get; set; }

        public List<ProductInCity> ProductsInCity { get; set; }

        public double Size { get; set; }

        public string CityCurrency { get; set; }

        public double BreadPrice { get; set; }

        public double MilkPrice { get; set; }
    }
}