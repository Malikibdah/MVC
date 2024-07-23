using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2test.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult login()
        {
            return View();
        }
        public ActionResult Regest()
        {
            ViewBag.intername = "Please Inter Your Name : ";
            ViewBag.interemail = "Please Inter Your Email : ";
            Session["interpass"] = "Inter Your Password : ";

            return View();

        }
        public ActionResult feedback()
        {
            ViewData["intername"] = "Please Inter Your Name : ";
            ViewData["interemail"] = "Please Inter Your Email : ";
            ViewData["interemessage"] = "Please Inter Your Message : ";
            TempData["moreinfo"] = "For more inrformation get touch with use using Number : 0786217123";


            return View();

        }
        public ActionResult home()
        {
            return View();
        }
    }
}