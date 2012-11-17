using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MapRover.Models;
using MapRover.Models.ViewModels;

namespace MapRover.Controllers
{
    public class MapController : Controller
    {
        MapRoverEntities _mapDB = new MapRoverEntities();
        //
        // GET: /Map/

        public ActionResult Index()
        {
            var data = new MapInformation()
            {
                Cities = _mapDB.Cities,
                Countries = _mapDB.Countries,
                Airports = _mapDB.Airports,
                Distances = _mapDB.Distances,
                NeighbourCountries = _mapDB.NeighbourCountries,
                Products = _mapDB.Products,
                ProductsInCities = _mapDB.ProductInCities
            };

            return View(data);
        }
    }
}

