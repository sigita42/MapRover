using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MapRover.Models
{
    public class MapInitializer : DropCreateDatabaseIfModelChanges<MapRoverEntities>
    {
        protected override void Seed(MapRoverEntities context)
        {
            var Cities = new List<City> {  
  
                 new City { Name = "Frankfurt",   
                            Description="Description of Frankfurt",   
                            Population=691518,  
                            Size=248.31,  
                            Picture="Content/themes/base/images/Frankfurte.jpg",
                            CountryId=1
                             },  

                     new City { Name = "Vienna ",   
                             Description="Description of Vienna",   
                             Population=1731236,  
                             Size=414.65,  
                             Picture="Content/themes/base/images/Vine.jpg",
                             CountryId=2 /*Country=Germny*/
                             },   
  
                 new City { Name = "Riga",   
                             Description="Description of Riga",   
                             Population=699203,  
                             Size=307.17,  
                             Picture="Content/themes/base/images/Riga1.jpg",
                             CountryId=3 
                            },   

               new City{ Name = "Paris",   
                             Description="Description of Paris",   
                             Population=2234105,  
                             Size=105.4,  
                             Picture="Content/themes/base/images/Parize.jpg",
                             CountryId=4 
                            },   
             };

            Cities.ForEach(d => context.Cities.Add(d));

        var Countries = new List<Country> {  
  
                 new Country { Name = "Germany",   
                            Cheers="Description of Frankfurt",   
                            CurrencyId=1,                         
                             },  

                 new Country { Name = "Austria",   
                            Cheers="Description of Frankfurt",   
                            CurrencyId=1,                         
                             }, 
  
                 new Country { Name = "Riga",   
                            Cheers="Description of Frankfurt",   
                            CurrencyId=2,                         
                             }, 

                 new Country { Name = "France",   
                            Cheers="Description of Frankfurt",   
                            CurrencyId=1,                         
                             }, 
             };

            Countries.ForEach(d => context.Countries.Add(d));

            var Airports = new List<Airport> {  
  
                 new Airport { Name = "Frankfurt International Airport",   
                            CityId=1                      
                             },  

                 new Airport { Name = "Vienna International Airport",   
                            CityId=2                      
                             }, 
  
                 new Airport { Name = "Riga International Airport",   
                            CityId=3                      
                             },

                 new Airport { Name = "Paris-Charles de Gaulle Airport",   
                            CityId=4                      
                             },

                 new Airport { Name = "Paris-Orly Airport",   
                            CityId=4                      
                             },
             };

            Airports.ForEach(d => context.Airports.Add(d));

            var Currencies = new List<Currency> {  
  
                 new Currency { Name = "Euro",   
                            Abbraviation="EUR",
                            ExchangeRateId=1
                             },  

                 new Currency { Name = "Lats",   
                            Abbraviation="LS",
                            ExchangeRateId=2                      
                             },   
             };

            Currencies.ForEach(d => context.Currencies.Add(d));

            var ExchangeRates = new List<ExchangeRate> {  
  
                 new ExchangeRate { IdCurrencyA =2,   
                            IdCurrencyB=1,
                            Value=14372 
                             },   
             };

            ExchangeRates.ForEach(d => context.ExchangeRates.Add(d));

            var Distances = new List<Distance> {  
  
                 new Distance { IdCityA=1,   
                                IdCityB=2,
                                Value=1
                              },  
                 new Distance { IdCityA=2,   
                                IdCityB=1,
                                Value=1
                              },
                 new Distance { IdCityA=2,   
                                IdCityB=3,
                                Value=2
                              },
                 new Distance { IdCityA=3,   
                                IdCityB=2,
                                Value=2
                              },
                 new Distance { IdCityA=3,   
                                IdCityB=4,
                                Value=3
                              },
                 new Distance { IdCityA=4,   
                                IdCityB=3,
                                Value=3
                              },
            };
            Distances.ForEach(d => context.Distances.Add(d));

            var NeighbourCountries= new List<NeighbourCountry> {  
  
                 new NeighbourCountry { Name="Germany"
                             }, 
                 new NeighbourCountry { Name="Austria"
                             },
                 new NeighbourCountry { Name="Latvia"
                             },
                 new NeighbourCountry { Name="France"
                             },
            };
            NeighbourCountries.ForEach(d => context.NeighbourCountries.Add(d));

            var Products = new List<Product> {  
  
                 new Product { ProductName = "Bread",                            
                             },  

                 new Product { ProductName = "Coke",                        
                             },   
             };

            Products.ForEach(d => context.Products.Add(d));

            var ProductInCities = new List<ProductInCity> {  
  
                 new ProductInCity { ProductId = 1, 
                                     CityId=1,
                                     Price=1.2
                             },  
                 new ProductInCity { ProductId = 1, 
                                     CityId=2,
                                     Price=1.3
                             },
                 new ProductInCity { ProductId = 1, 
                                     CityId=3,
                                     Price=1.0
                             },
                 new ProductInCity { ProductId = 1, 
                                     CityId=4,
                                     Price=1.1
                             },
                 new ProductInCity { ProductId = 2, 
                                     CityId=1,
                                     Price=2.1
                             },
                 new ProductInCity { ProductId = 2, 
                                     CityId=2,
                                     Price=2.5
                             },
                 new ProductInCity { ProductId = 2, 
                                     CityId=3,
                                     Price=0.8
                             },
                 new ProductInCity { ProductId = 2, 
                                     CityId=4,
                                     Price=1.8
                             },

            ProductInCities.ForEach(d => context.ProductInCities.Add(d)) ;

            };
        }
    }
}