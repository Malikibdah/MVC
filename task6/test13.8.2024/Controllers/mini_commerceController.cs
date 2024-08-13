using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test13._8._2024.Controllers
{
    public class mini_commerceController : Controller
    {
        // GET: mini_commerce
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult adminpage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult adminpage(FormCollection form)
        {
            return View();
        }
    }
}