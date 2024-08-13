using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test13._8._2024.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult admin()
        {


            return View();
        }
        [HttpPost]
        public ActionResult admin(FormCollection form)
        {
            var image = form["image"];
            var Productname = form["Product"];
            var price = form["price"];
            if (Session["images"] == null)
            {
                Session["images"] = new List<string>();
            }
            var images = Session["images"] as List<string>;
            images.Add(image);
            Session["images"] = images;
            if (Session["Productnames"] == null)
            {
                Session["Productnames"] = new List<string>();
            }
            var Productsname = Session["Productnames"] as List<string>;
            Productsname.Add(Productname);
            Session["Productnames"] = Productsname;

            if (Session["prices"] == null)
            {
                Session["prices"] = new List<string>();
            }
            var prices = Session["prices"] as List<string>;
            prices.Add(price);
            Session["Price"] = prices;

            return RedirectToAction("Index");

        }



    }
}