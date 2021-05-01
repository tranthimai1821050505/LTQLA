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

        public ViewResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(CheckAccountController Checkacc, String returnUrl)
        {
            if (ModelState.IsValid)
            {

                if (Checkacc.CheckUserName == "admin" && Checkacc.CheckPassword == "123123")
                {
                    FormsAuthentication.SetAuthCookie(Checkacc.CheckUserName, true);
                    return RedirectToLocal(returnUrl);
                }
            }
            return View(Checkacc);
        }
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