using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapRover.Models
{
    [Bind(Exclude = "CurrencyId")]
    public class Currency
    {
        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public string Abbraviation { get; set; }
        public List<ExchangeRate> ExchangeRates { get; set; }
        public List<Country> Countries { get; set; }
    }
}