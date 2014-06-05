﻿using System;
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

        [HttpGet]
        public ActionResult GetRestaurant(string cityname)
        {
            var adresse = from s in db.adresse select s;
            if (!string.IsNullOrEmpty(cityname))
            {
                adresse = adresse.Where(s => s.ville.ToUpper().Contains(cityname.ToUpper()));
            }
            
            return View("Restaurant" , adresse.ToList());
        }

        [HttpGet]
        public ActionResult GetRestaurant2(string cityname)
        {
            /*cit.CountryID = (from a in db.adresse where a.restaurantID == citee.CountryCode select cnt).First<Country>().ID;
            List<int> R = from s in db.adresse where s.ville == cityname select s.restaurantID ;
            var restaurant = from r in db.restaurant select r;
            var adresse = from s in db.adresse select s;
            if (!string.IsNullOrEmpty(cityname))
            {
                adresse = adresse.Where(s => s.ville.ToUpper().Contains(cityname.ToUpper()));
                //foreach(restaurant r in adresse)
                //{
                //}
            }

            return View("Restaurant", adresse.ToList());
             */
            return View();
        }
    }
}