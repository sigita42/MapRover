using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MapRover.Models
{
    public class MapRoverEntities : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Distance> Distances { get; set; }
        public DbSet<NeighbourCountry> NeighbourCountries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInCity> ProductsInCities { get; set; }
    }
}