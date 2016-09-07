using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebGoat.MVC.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult LogOn()
        {
            return View();
        }

	    public ActionResult Logout()
	    {
		    FormsAuthentication.SignOut();
		    return RedirectToMain();
	    }

		[HttpPost]
	    public ActionResult LogOn(string username, string password)
	    {
		    FormsAuthentication.SetAuthCookie(username, createPersistentCookie: false);
			return RedirectToMain();
	    }

	    private RedirectToRouteResult RedirectToMain()
	    {
		    return RedirectToAction("Index", "Home");
	    }
    }
}