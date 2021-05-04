using LTA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LTA.Controllers
{
    public class CheckAccountController : Controller
    {
        public string CheckUserName { get; private set; }
        public string CheckPassword { get; private set; }

        Encrytion encry = new Encrytion();
        LTADbContext db = new LTADbContext();

        //Get: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(CheckAccount Checkacc)
        {
            if (ModelState.IsValid)
            {
                Checkacc.CheckPassword = encry.PasswordEncrytion(Checkacc.CheckPassword);
                db.CheckAccounts.Add(Checkacc);
                db.SaveChanges();
                return RedirectToAction("Login", "CheckAccount");
            }
            return View(Checkacc);
        }
        public ViewResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public ActionResult Login(CheckAccount Checkacc)
        {
            if (ModelState.IsValid)
            {
                string encrytionpass = encry.PasswordEncrytion(Checkacc.CheckPassword);
                var model = db.CheckAccounts.Where(m => m.CheckUsername == Checkacc.CheckUsername && m.CheckPassword == encrytionpass).ToList().Count();
                if (model == 1)
                {
                    FormsAuthentication.SetAuthCookie(Checkacc.CheckUsername, true);
                    return RedirectToAction("Index", "Home");
                }    
                else
                {
                    ModelState.AddModelError("", "Thông tin đăng nhập không chính xác");
                }    
            }
            return View(Checkacc);
        }
        //public ActionResult Login(CheckAccountController Checkacc, String returnUrl)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        if (Checkacc.CheckUserName == "admin" && Checkacc.CheckPassword == "123123")
        //        {
        //            FormsAuthentication.SetAuthCookie(Checkacc.CheckUserName, true);
        //            return RedirectToLocal(returnUrl);
        //        }
        //    }
        //    return View(Checkacc);
        //}
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }    
            else
            {
                return RedirectToAction("Index", "Home");
            }    
        }
    }
}