using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MapRover.Models.ViewModels;

namespace MapRover.Controllers
{
    public class CommentsController : Controller
    {
        //
        // GET: /Comments/

        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /Map/Index/
        // Activates by pressing button - Go back to map

        public ActionResult Map()
        {
            return View();
        }
        // No idea what Im doing here - should tell controller to take info about City details from Map Controller. Later must be edited.
        public ActionResult CityDetails()
        {
            return View();
        }
        }
 }
    

