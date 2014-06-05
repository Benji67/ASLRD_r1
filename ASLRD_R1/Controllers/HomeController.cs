using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASLRD_R1.DataBaseAccess;

namespace ASLRD_R1.Controllers
{
    public class HomeController : Controller
    {
        private DataBaseASLRD db = new DataBaseASLRD();

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult Adresse()
        {
            ViewBag.Message = "Your app description page.";
            return View();
        }

        public ActionResult Restaurant()
        {
            ViewBag.Message = "Your app description page.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // liste les adresses
        [HttpGet]
        public ActionResult GetRestaurant(string cityname)
        {
            var adresse = from a in db.adresse select a;
            if (!string.IsNullOrEmpty(cityname))
            {                
                adresse = adresse.Where(a => a.ville.ToUpper().Contains(cityname.ToUpper()));
                return View("Restaurant", adresse.ToList());                
            }
            
            else
            {
                return View("Adresse", adresse.ToList());
            }
            
        }

        // liste les restaurants de la ville en parametre
        [HttpGet]
        public ActionResult GetRestaurant2(string cityname)
        {
            // Lazy loading
            var adresse = from a in db.adresse select a;
            var restaurant = from r in db.restaurant select r;
            if (!string.IsNullOrEmpty(cityname))
            {
                adresse = adresse.Where(s => s.ville.ToUpper().Contains(cityname.ToUpper()));
                foreach (adresse A in adresse.ToList())
                {

                }
            }

            return View("Restaurant", adresse.ToList());
            
            //return View();
        }
    }
}
