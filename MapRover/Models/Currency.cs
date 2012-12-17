using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapRover.Models
{
    //[Bind(Exclude = "CurrencyId")]
    public class Currency
    {
        public string Abbraviation { get; set; }

        public List<Country> Countries { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CurrencyId { get; set; }

        public List<ExchangeRate> ExchangeRates { get; set; }

        public string Name { get; set; }
    }
}