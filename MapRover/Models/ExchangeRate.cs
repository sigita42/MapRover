using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapRover.Models
{
    //[Bind(Exclude = "IdCurrencyA,IdCurrencyB")]
    public class ExchangeRate
    {
        public Currency CurrencyA { get; set; }

        public Currency CurrencyB { get; set; }

        [Key]
        [Column(Order = 0)]
        public int IdCurrencyA { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IdCurrencyB { get; set; }

        public string Value { get; set; }
    }
}