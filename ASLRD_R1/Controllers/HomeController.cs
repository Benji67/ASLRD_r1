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

        [HandleError(View = "Error")]
        public ActionResult Index()
        {
            ViewBag.Message = "Index message.";
            return View();
        }

        [HandleError(View = "ErrorAdresse")]
        public ActionResult Adresse()
        {
            ViewBag.Message = "Adresse message.";
            return View();
        }

        [HandleError(View = "ErrorAdresse")]
        public ActionResult Restaurant()
        {
           ViewBag.Message = "Restaurant message.";
           return View();
        }

        [HandleError(View = "ErrorAdresse")]
        public ActionResult Produit()
        {
            ViewBag.Message = "Produit message.";
            return View();
        }

        [HandleError(View = "ErrorAdresse")]
        public ActionResult Menu()
        {
            ViewBag.Message = "Menu message.";
            return View();
        }

        [HandleError(View = "Error")]
        [HttpGet]
        public ActionResult Commentaire()
        {
            var listecommentaire = (from c in db.commentaire
                                    select c).ToList();
            if (listecommentaire.FirstOrDefault() == null)
            {
                return View();
            }
            else
            {
                return View(listecommentaire);
            }
        }

        [HandleError(View = "Error")]
        public ActionResult About()
        {
            ViewBag.Message = "About message.";
            return View();
        }

        [HandleError(View = "Error")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact message.";
            return View();
        }

        //liste des restaurants en fonction de la ville
        [HttpGet]
        [HandleError(View = "ErrorAdresse")]
        public ActionResult GetRestaurant(string cityname)
        {
            if (string.IsNullOrEmpty(cityname))
            {
                ViewBag.Resut = "Erreur, entrer une ville (exemple: Strasbourg)";
                return View("Adresse", null);
            }
            else
            {
                var listerestaurant = (from r in db.restaurant
                                           from a in db.adresse                                       
                                           where a.restaurantID == r.restaurantID
                                           where a.ville.ToUpper() == cityname.ToUpper()
                                           select r).ToList();
                if (listerestaurant.FirstOrDefault() == null)
                {
                    ViewBag.Resut = "Erreur, entrer une ville existante ou cette ville est non référencé (exemple: Strasbourg)";
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
        [HandleError(View = "ErrorAdresse")]
        public ActionResult GetProduit(int? restaurantID)
        {
            var listeproduit = (from p in db.produit
                                        from r in db.restaurant
                                        where r.restaurantID == restaurantID
                                        where p.restaurantID == r.restaurantID
                                        select p).ToList();
            if (listeproduit.FirstOrDefault() == null)
            {
                ViewBag.Resut = "Erreur, la liste des produits est vide pour le restaurant";
                return View("Restaurant");
            }
            else
            {
                return View("Produit", listeproduit);
            }
        }
        
         //Ajouter au panier un produit
        [HttpGet]
        [HandleError(View = "ErrorAdresse")]
        public ActionResult AjouterAuCadie(int produitID)
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}
