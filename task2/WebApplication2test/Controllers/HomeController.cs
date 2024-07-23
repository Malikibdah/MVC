using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           

            return View();
        }
        public ActionResult Contact()
        {


            return View();
        }
        public ActionResult Contactrview()
        {
           
            return View();
        }
        [HttpPost]

        public ActionResult Contact(FormCollection form)
        {

            
            ViewBag.Name=form["name"];
            ViewBag.Birthyear = form["birth"];
            ViewBag.Gender = form["gender"];
            ViewBag.Courses = form["courses"];
            ViewBag.Skills = form["skills"];




            return View("Contactrview");
        }
    }
}