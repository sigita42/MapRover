using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapRover.Models
{
    //[Bind(Exclude = "CountryId")]
    public class Country
    {
        public string Cheers { get; set; }

        public List<City> Cities { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryId { get; set; }

        public Currency Currency { get; set; }

        public int CurrencyId { get; set; }

        public string Name { get; set; }

        public List<NeighbourCountry> NeighbourCountries { get; set; }
    }
}