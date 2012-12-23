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
                            Description="Frankfurt (also known as Frankfurt am Main) is the fifth largest city in Germany. Frankfurt is considered to be the largest financial centre in continental Europe since it is hosting numerous major banks. City is known also for its significant transpotation system and educational institutions. You can also find there a lot of museums (Stadel, Naturmuseum Senckenberg, Goethe House) and two remarkable botanical gardens.",
                            Population=691518,
                            Size=248.31,
                            Picture="url(/Content/themes/base/images/Frankfurte.jpg)",
                            CountryId=1,
                            Lat=50.111667,
                            Lng=8.685833,
                            MilkPrice=0.62,
                            BreadPrice=1.50,
                            CityCurrency="Euro"
                             },

                     new City { Name = "Vienna ",
                             CityId=2,
                             Description="Vienna is the capital of Austria. Through the city flows a river called Danube which contains an 21 km long island - Danube Island. It is a famous leisure area with swimming and BBQ places. As for food and wine you can discover many heurigers at the foot of beautiful Alps. Vienna has also some woldwide famous buildings like castle Schonbrunn, cathedral Stephansdom, baroque style church Karlskirche.",
                             Population=1731236,
                             Size=414.65,
                             Picture="url(/Content/themes/base/images/Vine.jpg)",
                             CountryId=2,
                             Lat=48.208333,
                             Lng=16.373056,
                             MilkPrice=0.97,
                             BreadPrice=1.78,
                             CityCurrency="Euro"
                             },

                     new City { Name = "Riga",
                             CityId=3,
                             Description="Riga is the largest city of the Baltic states. Old city of Riga has an unvaluable meaning of the city - Riga historical centre is a UNESCO World Heritage Site for its Jugendstil arhitecture. One of the most important buildings in Riga are St. Peters church, Three brothers, The House of Blackheads. From newly built buildings can be metioned Saules akmens and library which is still in buliding process - Gaismas pils.",
                             Population=699203,
                             Size=307.17,
                             Picture="url(/Content/themes/base/images/Riga1-002.jpg)",
                             CountryId=3,
                             Lat=56.948889,
                             Lng=24.106389,
                             MilkPrice=0.96,
                             BreadPrice=0.72,
                             CityCurrency="Lats"
                            },

                     new City{ Name = "Paris",
                             CityId=4,
                             Description="Paris is the capital and largest city in France. City is one of the most popular tourism destinations as well as famous cultural centre. Besides the widely known romantic building - the Eiffel Tower, in Paris are located also such significant buildings as Louvre, The Opera Garnier and many more.",
                             Population=2234105,
                             Size=105.4,
                             Picture="url(/Content/themes/base/images/Parize.jpg)",
                             CountryId=4,
                             Lat=48.8567,
                             Lng=2.3508,
                             MilkPrice=1.13,
                             BreadPrice=1.50,
                             CityCurrency="Euro"
                            },

                     new City{ Name = "Madrid",
                             CityId=5,
                             Description="Madrid is the capital of Spain. It is home for one of the most prestigious football clubs of the world - La Liga football club Real Madrid. In Madrid you can visit numerous significant places - Plaza Mayor, Puerta de Alcala, City Hall of Madrid, etc.",
                             Population= 3265038,
                             Size= 605.77,
                             Picture="url(/Content/themes/base/images/Madride.jpg)",
                             CountryId=5,
                             Lat=40.383333,
                             Lng=-3.716667,
                             MilkPrice=0.80,
                             BreadPrice=1.00,
                             CityCurrency="Euro"
                            },

                     new City{ Name = "Moscow",
                             CityId=6,
                             Description="Moscow is major political, economic, cultural and scientific center in Russia and in Europe. Moscow is the site of the Moscow Kremlin, an ancient fortress that is today the residence of the Russian president and of the executive branch of the Government of Russia. The Kremlin is also one of several World Heritage Sites in the city. Othersignificant places are Red Square and Saint Basils Cathedral.",
                             Population= 11503501,
                             Size= 2510.00,
                             Picture="url(/Content/themes/base/images/Maskava.jpg)",
                             CountryId=6,
                             Lat=55.75,
                             Lng=37.616667,
                             MilkPrice=0.98,
                             BreadPrice=0.62,
                             CityCurrency="Ruble"
                            },

                     new City{ Name = "Rome",
                             CityId=7,
                             Description="Rome is the capital of Italy. It has a significantly long and rich history since foundation of Rome in 753 BC. It is an attraction place for numberless toursists mainly because of its antique arhiteture and culture. Nowadays visitors can still observe a lot of the stunning buildings - Basilica of St. John Lateranand, Colosseum (in the picture) and much more thus having the feeing of the ancient Rome.",
                             Population= 2777979,
                             Size= 1285.31,
                             Picture="url(/Content/themes/base/images/Rome.jpg)",
                             CountryId=7,
                             Lat=41.9,
                             Lng=12.5,
                             MilkPrice=1.50,
                             BreadPrice=1.50,
                             CityCurrency="Euro"
                            },

                     new City{ Name = "Oslo",
                             CityId=8,
                             Description="Oslo is the economic and governmental centre of Norway. The city is also a hub of Norwegian trade, banking, industry and shipping. It is an important centre for maritime industries and maritime trade in Europe. The city is home to many companies within the maritime sector. Oslo is a pilot city of the Council of Europe and the European Commission intercultural cities programme.",
                             Population= 1020000,
                             Size= 454.03,
                             Picture="url(/Content/themes/base/images/Oslo.jpg)",
                             CountryId=8,
                             Lat=59.949444,
                             Lng=10.756389,
                             MilkPrice=1.97,
                             BreadPrice=3.06,
                             CityCurrency="Krone"
                            },

                     new City{ Name = "Barcelona",
                             CityId=9,
                             Description="Barcelona is the capital of Catalunia. It is also the second biggest city in Spain. Barcelona has a rich cultural heritage and is today an important cultural centre and a major tourist destination. Particularly renowned are the architectural works of Antoni Gaudi and Lluis Domenech i Montaner, which have been designated UNESCO World Heritage Sites.",
                             Population= 1621537,
                             Size= 803.00,
                             Picture="url(/Content/themes/base/images/Barcelona.jpg)",
                             CountryId=5,
                             Lat=41.383333,
                             Lng=2.183333,
                             MilkPrice=0.85,
                             BreadPrice=1.00,
                             CityCurrency="Euro"
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
                            webPage="http://www.frankfurt-airport.com",
                            Passengers=56436255
                            },

                 new Airport { Name = "Vienna International Airport",
                            AirportId=2,
                            CityId=2,
                            Lat=48.110278,
                            Lng=16.569722,
                            webPage="http://www.viennaairport.com",
                            Passengers=21106292
                             },

                 new Airport { Name = "Riga International Airport",
                            AirportId=3,
                            CityId=3,
                            Lat=56.923611,
                            Lng=23.971111,
                            webPage="http://www.riga-airport.com/",
                            Passengers=5106926
                             },

                 new Airport { Name = "Paris-Charles de Gaulle Airport",
                            AirportId=4,
                            CityId=4,
                            Lat=49.009722,
                            Lng=2.547778,
                            webPage="http://www.aeroportsdeparis.fr",
                            Passengers=60970551
                             },

                 new Airport { Name = "Barajas Airport",
                            AirportId=5,
                            CityId=5,
                            Lat=40.472222,
                            Lng=-3.560833,
                            webPage="...",
                            Passengers=49671270
                             },

                 new Airport { Name = "Domodedovo International Airport",
                            AirportId=6,
                            CityId=6,
                            Lat=55.408611,
                            Lng=37.906111,
                            webPage="...",
                            Passengers=25701610 
                             },

                 new Airport { Name = "Leonardo da Vinci–Fiumicino Airport",
                            AirportId=7,
                            CityId=7,
                            Lat=41.800278,
                            Lng=12.238889,
                            webPage="...",
                            Passengers=37651700
                             },

                 new Airport { Name = "Oslo-Gardermoen Airport",
                            AirportId=8,
                            CityId=8,
                            Lat=60.202778,
                            Lng=11.083889,
                            webPage="...",
                            Passengers=19091036
                             },

                 new Airport { Name = "Barcelona El Prat Airport",
                            AirportId=9,
                            CityId=9,
                            Lat=41.296944,
                            Lng=2.078333,
                            webPage="...",
                            Passengers=29209536
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