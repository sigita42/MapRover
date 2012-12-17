using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapRover.Models
{
    //[Bind(Exclude = "IdContryA,IdCountryB")]
    public class NeighbourCountry
    {
        public NeighbourCountry()
        {
        }

        public Country CountryA { get; set; }

        public Country CountryB { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCountryA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCountryB { get; set; }
    }
}