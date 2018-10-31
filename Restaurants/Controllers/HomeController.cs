using CoffeeShop_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurants.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "We LOVE to hear from our customers! Have something to tell us (good or bad!)? Please reach out to us as shown below..";

            return View();
        }

        public ActionResult Menu()
        {
            CoffeeMenuBusiness busObj = new CoffeeMenuBusiness();
            var modeldata = busObj.GetMenu();
            ViewBag.Message = "Your Menu page.";

            return View(modeldata);
        }
    }
}