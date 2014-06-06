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

        //liste des restaurants en fonction de la ville
        [HttpGet]
        public ActionResult GetRestaurant(string cityname)
        {      
            if ( string.IsNullOrEmpty(cityname))
            {
                ViewBag.Resut = "Erreur, entrer une ville";
                return View("Adresse", null);
            }
            else
            {
                var listerestaurant = (from r in db.restaurant
                                       from a in db.adresse                                       
                                       where a.restaurantID == r.restaurantID
                                       where a.ville.ToUpper() == cityname.ToUpper()
                                       select r);
                if (listerestaurant == null)
                {
                    ViewBag.Resut = "Erreur, entrer une ville existante ou cette ville est non référencé";
                   return View("Adresse", null);
                }
                    else
                {
                    return View("Restaurant", listerestaurant);
                }
            }
        }

        //liste des produit pour un restaurant
        [HttpGet]
        public ActionResult GetProduit()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}
