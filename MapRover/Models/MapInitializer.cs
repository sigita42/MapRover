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
                            Description="Frankfurt (also known as Frankfurt am Main) is the fifth largest city in Germany. Frankfurt is considered to be the largest financial centre in continental Europe since it is hosting numerous major banks. City is known also for its significant transpotation system and educational institutions. You can also find there a lot of museums (Stadel, Naturmuseum Senckenberg, Goethe House) and two remarkable botaical gardens.",
                            Population=691518,
                            Size=248.31,
                            Picture="url(/Content/themes/base/images/Frankfurte.jpg)",
                            CountryId=1,
                            Lat=50.111667,
                            Lng=8.685833
                             },

                     new City { Name = "Vienna ",
                             CityId=2,
                             Description="Description of Vienna",
                             Population=1731236,
                             Size=414.65,
                             Picture="url(/Content/themes/base/images/Vine.jpg)",
                             CountryId=2,
                             Lat=48.208333,
                             Lng=16.373056
                             },

                     new City { Name = "Riga",
                             CityId=3,
                             Description="Riga is the largest city of the Baltic states.",
                             Population=699203,
                             Size=307.17,
                             Picture="url(/Content/themes/base/images/Riga1-002.jpg)",
                             CountryId=3,
                             Lat=56.948889,
                             Lng=24.106389
                            },

                     new City{ Name = "Paris",
                             CityId=4,
                             Description="Description of Paris",
                             Population=2234105,
                             Size=105.4,
                             Picture="url(/Content/themes/base/images/Parize.jpg)",
                             CountryId=4,
                             Lat=48.8567,
                             Lng=2.3508
                            },

                     new City{ Name = "Madrid",
                             CityId=5,
                             Description="Description of Madrid",
                             Population= 3265038,
                             Size= 605.77,
                             Picture="url(/Content/themes/base/images/Madride.jpg)",
                             CountryId=5,
                             Lat=40.383333,
                             Lng=-3.716667
                            },

                     new City{ Name = "Moscow",
                             CityId=6,
                             Description="Description of Moscow",
                             Population= 11503501,
                             Size= 2510.00,
                             Picture="url(/Content/themes/base/images/Maskava.jpg)",
                             CountryId=6,
                             Lat=55.75,
                             Lng=37.616667
                            },

                     new City{ Name = "Rome",
                             CityId=7,
                             Description="Rome is the capital of Italy. It has a significantly long and rich history since foundation of Rome in 753 BC. It is an attraction place for numberless toursists mainly because of its antique arhiteture and remarkable culture. Nowadays visitors of the city still can observe a lot of the stunning buildings like Basilica of St. John Lateranand,  Basilica di Santa Maria Maggiore, The Colosseum (seen in the picture) and much more thus having the feeing of the ancient Rome.",
                             Population= 2777979,
                             Size= 1285.31,
                             Picture="url(/Content/themes/base/images/Rome.jpg)",
                             CountryId=7,
                             Lat=41.9,
                             Lng=12.5
                            },

                     new City{ Name = "Oslo",
                             CityId=8,
                             Description="Description of Oslo",
                             Population= 1020000,
                             Size= 454.03,
                             Picture="url(/Content/themes/base/images/Oslo.jpg)",
                             CountryId=8,
                             Lat=59.949444,
                             Lng=10.756389
                            },

                     new City{ Name = "Barcelona",
                             CityId=9,
                             Description="Barcelona is the capital of Catalunia. It is also the second biggest city in Spain.",
                             Population= 1621537,
                             Size= 803.00,
                             Picture="url(/Content/themes/base/images/Barcelona.jpg)",
                             CountryId=5,
                             Lat=41.383333,
                             Lng=2.183333
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

                 new Country { Name = "Spain",
                            CountryId=5,
                            Cheers="Santé",
                            CurrencyId=1,
                             },

                 new Country { Name = "Russia",
                            CountryId=6,
                            Cheers="Santé",
                            CurrencyId=4,
                             },

                 new Country { Name = "Italy",
                            CountryId=7,
                            Cheers="Santé",
                            CurrencyId=1,
                             },

                 new Country { Name = "Norway",
                            CountryId=8,
                            Cheers="Santé",
                            CurrencyId=3,
                             },
             };

            Countries.ForEach(d => context.Countries.Add(d));

            var Airports = new List<Airport> {
                 new Airport { Name = "Frankfurt International Airport",
                            AirportId=1,
                            CityId=1,
                            Lat=50.033333,
                            Lng=8.570556,
                            webPage="http://www.frankfurt-airport.com"
                            },

                 new Airport { Name = "Vienna International Airport",
                            AirportId=2,
                            CityId=2,
                            Lat=48.110278,
                            Lng=16.569722,
                            webPage="http://www.viennaairport.com"
                             },

                 new Airport { Name = "Riga International Airport",
                            AirportId=3,
                            CityId=3,
                            Lat=56.923611,
                            Lng=23.971111,
                            webPage="http://www.riga-airport.com/"
                             },

                 new Airport { Name = "Paris-Charles de Gaulle Airport",
                            AirportId=4,
                            CityId=4,
                            Lat=49.009722,
                            Lng=2.547778,
                            webPage="http://www.aeroportsdeparis.fr"
                             },

                 new Airport { Name = "Barajas Airport",
                            AirportId=5,
                            CityId=5,
                            Lat=40.472222,
                            Lng=-3.560833,
                            webPage="..."
                             },

                 new Airport { Name = "Domodedovo International Airport",
                            AirportId=6,
                            CityId=6,
                            Lat=55.408611,
                            Lng=37.906111,
                            webPage="..."
                             },

                 new Airport { Name = "Leonardo da Vinci–Fiumicino Airport",
                            AirportId=7,
                            CityId=7,
                            Lat=41.800278,
                            Lng=12.238889,
                            webPage="..."
                             },

                 new Airport { Name = "Oslo-Gardermoen Airport",
                            AirportId=8,
                            CityId=8,
                            Lat=60.202778,
                            Lng=11.083889,
                            webPage="..."
                             },

                 new Airport { Name = "Barcelona El Prat Airport",
                            AirportId=9,
                            CityId=9,
                            Lat=41.296944,
                            Lng=2.078333,
                            webPage="..."
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

                 new Currency { Name = "Norwegian Krone",
                            CurrencyId=3,
                            Abbraviation="NOK",
                             },

                 new Currency { Name = "Russian Ruble",
                            CurrencyId=4,
                            Abbraviation="RUB",
                             },
             };

            Currencies.ForEach(d => context.Currencies.Add(d));

            var ExchangeRates = new List<ExchangeRate> {
                 new ExchangeRate {
                            IdCurrencyA =2,
                            IdCurrencyB=1,
                            Value="1 Euro = 0.6962 Latvian Lati"
                             },

                 new ExchangeRate {
                            IdCurrencyA =3,
                            IdCurrencyB=1,
                            Value="1 Euro = 7.3535 Norwegian Krone"
                             },

                 new ExchangeRate {
                            IdCurrencyA =4,
                            IdCurrencyB=1,
                            Value="1 Euro = 40.3112 Russian Ruble"
                             },
             };

            ExchangeRates.ForEach(d => context.ExchangeRates.Add(d));

            foreach (City cityA in Cities)
            {
                foreach (City cityB in Cities)
                {
                    if (cityA != cityB)
                    {
                        context.Distances.Add(new Distance(cityA, cityB));
                    }
                }
            }

            var NeighbourCountries = new List<NeighbourCountry> {
                 new NeighbourCountry { IdCountryA = 1, IdCountryB = 2 },
                 new NeighbourCountry { IdCountryA = 1, IdCountryB = 4 },
                 new NeighbourCountry { IdCountryA = 2, IdCountryB = 1 },
                 new NeighbourCountry { IdCountryA = 2, IdCountryB = 7 },
                 new NeighbourCountry { IdCountryA = 3, IdCountryB = 6 },
                 new NeighbourCountry { IdCountryA = 4, IdCountryB = 1 },
                 new NeighbourCountry { IdCountryA = 4, IdCountryB = 5 },
                 new NeighbourCountry { IdCountryA = 4, IdCountryB = 7 },
                 new NeighbourCountry { IdCountryA = 5, IdCountryB = 4 },
                 new NeighbourCountry { IdCountryA = 6, IdCountryB = 3 },
                 new NeighbourCountry { IdCountryA = 7, IdCountryB = 2 },
                 new NeighbourCountry { IdCountryA = 7, IdCountryB = 4 },
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
                 new ProductInCity { ProductId = 1,
                                     CityId=5,
                                     Price=1.1
                             },
                 new ProductInCity { ProductId = 1,
                                     CityId=6,
                                     Price=1.1
                             },
                 new ProductInCity { ProductId = 1,
                                     CityId=7,
                                     Price=1.1
                             },
                 new ProductInCity { ProductId = 1,
                                     CityId=8,
                                     Price=1.1
                             },
                 new ProductInCity { ProductId = 1,
                                     CityId=9,
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
                 new ProductInCity { ProductId = 2,
                                     CityId=5,
                                     Price=1.8
                             },
                 new ProductInCity { ProductId = 2,
                                     CityId=6,
                                     Price=1.8
                             },
                 new ProductInCity { ProductId = 2,
                                     CityId=7,
                                     Price=1.8
                             },
                 new ProductInCity { ProductId = 2,
                                     CityId=8,
                                     Price=1.8
                             },
                 new ProductInCity { ProductId = 2,
                                     CityId=9,
                                     Price=1.8
                             },
            };

            ProductInCities.ForEach(d => context.ProductInCities.Add(d));
        }
    }
}