using System.ComponentModel.DataAnnotations.Schema;

namespace MapRover.Models
{
    //[Bind(Exclude = "AirportId")]
    public class Airport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AirportId { get; set; }

        public City City { get; set; }

        public int CityId { get; set; }

        public double Lat { get; set; }

        public double Lng { get; set; }

        public string Name { get; set; }

        public string webPage { get; set; }
    }
}