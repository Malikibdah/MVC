using _30._7._2024task4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _30._7._2024task4.Controllers
{
    public class UsersController : Controller
    {
        UsersEntities db = new UsersEntities();
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User uSER)
        {
            if (ModelState.IsValid && uSER.UserPassword == uSER.ConfirmPassword)
            {
                db.Users.Add(uSER);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uSER);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User uSER)
        {
            var checkInputs = db.Users.Where(model => model.Email == uSER.Email && model.UserPassword == uSER.UserPassword).FirstOrDefault();

            Session["UserID"] = checkInputs.ID;


            if (checkInputs != null)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Logout()
        {
            Session["UserID"] = null;
            return RedirectToAction("Index");
        }


        public ActionResult Profile()
        {
            var userID = (int)Session["UserID"];
            var user = db.Users.Find(userID);
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Profile(User uSER, HttpPostedFileBase upload)
        {


            if (upload != null && upload.ContentLength > 0)
            {
                var fileName = Path.GetFileName(upload.FileName);
                var path = Path.Combine(Server.MapPath("~/Images/"), fileName);

                if (!Directory.Exists(Server.MapPath("~/Images/")))
                {
                    Directory.CreateDirectory(Server.MapPath("~/Images/"));
                }

                upload.SaveAs(path);
                uSER.Img = fileName;
            }

            db.Entry(uSER).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult ResetPasswordt()
        {
            var userID = (int)Session["UserID"];
            var user = db.Users.Find(userID);
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ResetPasswordt(string currentPassword, string newPassword, string confirmNewPassword)
        {
            var userID = (int)Session["UserID"];
            var user = db.Users.Find(userID);

            if (currentPassword == user.UserPassword)
            {
                if (newPassword == confirmNewPassword)
                {
                    user.UserPassword = newPassword;
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Profile");
                }
                else
                {
                    ViewBag.Message = "New Password does not match Confirm Password!";
                    return View(user);
                }
            }
            else
            {
                ViewBag.Message = "Current Password is incorrect!";
                return View(user);
            }
        }

    }
}