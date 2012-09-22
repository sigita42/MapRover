using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapRover.Models
{
    [Bind(Exclude = "IdCurrencyA,IdCurrencyB")]
    public class ExchangeRate
    {
        public int IdCurrencyA { get; set; }
        public int IdCurrencyB { get; set; }
        public decimal Value { get; set; }
        public Currency CurrencyA { get; set; }
        public Currency CurrencyB { get; set; }

    }
}