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
                            CityId=1,
                            Description="Description of Frankfurt",   
                            Population=691518,  
                            Size=248.31,  
                            Picture="Content/themes/base/images/Frankfurte.jpg",
                            CountryId=1,
                            Lat=50.111667,
                            Lng=8.685833
                             },  

                     new City { Name = "Vienna ",   
                             CityId=2,
                             Description="Description of Vienna",   
                             Population=1731236,  
                             Size=414.65,  
                             Picture="Content/themes/base/images/Vine.jpg",
                             CountryId=2, 
                             Lat=48.208333, 
                             Lng=16.373056
                             },   
  
                     new City { Name = "Riga", 
                             CityId=3,
                             Description="Description of Riga",   
                             Population=699203,  
                             Size=307.17,  
                             Picture="Content/themes/base/images/Riga1-002.jpg",
                             CountryId=3,
                             Lat=56.948889, 
                             Lng=24.106389
                            },   

                     new City{ Name = "Paris", 
                             CityId=4,
                             Description="Description of Paris",   
                             Population=2234105,  
                             Size=105.4,  
                             Picture="Content/themes/base/images/Parize.jpg",
                             CountryId=4,
                             Lat=48.8567, 
                             Lng=2.3508
                            },   
             };

            Cities.ForEach(d => context.Cities.Add(d));

        var Countries = new List<Country> {  
  
                 new Country { Name = "Germany",  
                            CountryId=1,
                            Cheers="Prost",   
                            CurrencyId=1,                         
                             },  

                 new Country { Name = "Austria", 
                            CountryId=2,
                            Cheers="Prost",   
                            CurrencyId=1,                         
                             }, 
  
                 new Country { Name = "Latvia", 
                            CountryId=3,
                            Cheers="Priekā",   
                            CurrencyId=2,                         
                             }, 

                 new Country { Name = "France", 
                            CountryId=4,
                            Cheers="Santé",   
                            CurrencyId=1,                         
                             }, 
             };

            Countries.ForEach(d => context.Countries.Add(d));

            var Airports = new List<Airport> {  
  
                 new Airport { Name = "Frankfurt International Airport", 
                            AirportId=1,
                            CityId=1, 
                            Lat=50.033333,
                            Lng=8.570556
                             },  

                 new Airport { Name = "Vienna International Airport", 
                            AirportId=2,
                            CityId=2, 
                            Lat=48.110278,
                            Lng=16.569722                      
                             }, 
  
                 new Airport { Name = "Riga International Airport", 
                            AirportId=3,
                            CityId=3, 
                            Lat=56.923611,
                            Lng=23.971111                      
                             },

                 new Airport { Name = "Paris-Charles de Gaulle Airport",  
                            AirportId=4,
                            CityId=4, 
                            Lat=49.009722,
                            Lng=2.547778                      
                             },

                 new Airport { Name = "Paris-Orly Airport",  
                            AirportId=5,
                            CityId=4, 
                            Lat=48.723333,
                            Lng=2.379444                      
                             },
             };

            Airports.ForEach(d => context.Airports.Add(d));

            var Currencies = new List<Currency> {  
  
                 new Currency { Name = "Euro",  
                            CurrencyId=1,
                            Abbraviation="EUR",
                             },  

                 new Currency { Name = "Lats",
                            CurrencyId=2,
                            Abbraviation="LVL",                      
                             },   
             };

            Currencies.ForEach(d => context.Currencies.Add(d));

            var ExchangeRates = new List<ExchangeRate> {  
  
                 new ExchangeRate { 
                            IdCurrencyA =2,   
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
                 new Distance { IdCityA=1,   
                                IdCityB=3,
                                Value=3
                              },
                 new Distance { IdCityA=3,   
                                IdCityB=1,
                                Value=3
                              },
                 new Distance { IdCityA=1,   
                                IdCityB=4,
                                Value=3
                              },
                 new Distance { IdCityA=4,   
                                IdCityB=1,
                                Value=3
                              },
                 new Distance { IdCityA=4,   
                                IdCityB=2,
                                Value=4
                              },
                 new Distance { IdCityA=2,   
                                IdCityB=4,
                                Value=4
                              },
                 new Distance { IdCityA=1,   
                                IdCityB=1,
                                Value=0
                              },
                 new Distance { IdCityA=2,   
                                IdCityB=2,
                                Value=0
                              },
                 new Distance { IdCityA=3,   
                                IdCityB=3,
                                Value=0
                              },
                 new Distance { IdCityA=4,   
                                IdCityB=4,
                                Value=0
                              },
                            
            };
            Distances.ForEach(d => context.Distances.Add(d));

            var NeighbourCountries= new List<NeighbourCountry> {  
  
                 new NeighbourCountry { Name="Germany",
                                        NeighbourCountryId=1
                             }, 
                 new NeighbourCountry { Name="Austria",
                                        NeighbourCountryId=2
                             },
                 new NeighbourCountry { Name="Latvia",
                                        NeighbourCountryId=3
                             },
                 new NeighbourCountry { Name="France",
                                        NeighbourCountryId=4
                             },
            };
            NeighbourCountries.ForEach(d => context.NeighbourCountries.Add(d));

            var Products = new List<Product> {  
  
                 new Product { ProductName = "Bread", 
                               ProductId=1      
                             },  

                 new Product { ProductName = "Coke", 
                               ProductId=2  
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
                             }
            };

            ProductInCities.ForEach(d => context.ProductInCities.Add(d));
        }
    }
}