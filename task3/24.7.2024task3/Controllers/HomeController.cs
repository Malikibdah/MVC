using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24._7._2024task3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["name"] = "1";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(FormCollection contact)
        {
            @ViewBag.Name = contact["name"];
            @ViewBag.Email = contact["email"];
            @ViewBag.Message = contact["message"];
            

            return View();
        }
        public ActionResult Login(FormCollection form)
        {
            Session["login"] ="Malik Ibdah";
            string email = form["email"];
            string password = form["password"];

            if (email == "malikibdah@gmail.com"&& password=="123456")
            {
                Session["name"] = "0";
                return View("Index");
            }
            return View();
        }
    }
}