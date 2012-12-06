using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapRover.Models
{
    [Bind(Exclude = "IdCurrencyA,IdCurrencyB")]
    public class ExchangeRate
    {
        [Key]
        [Column(Order=0)]
        public int IdCurrencyA { get; set; }
        [Key]
        [Column(Order=1)]
        public int IdCurrencyB { get; set; }
        public string Value { get; set; }
        public Currency CurrencyA { get; set; }
        public Currency CurrencyB { get; set; }

    }
}