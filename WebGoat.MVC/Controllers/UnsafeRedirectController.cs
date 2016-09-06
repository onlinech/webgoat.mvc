using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGoat.MVC.Controllers
{
    public class UnsafeRedirectController : Controller
    {
        // GET: UnsafeRedirect
        public ActionResult Login(string redirectUrl)
        {
	        if (string.IsNullOrEmpty(redirectUrl))
	        {
		        redirectUrl = "/";
	        }
	        return View(model: redirectUrl);
        }

	    [HttpPost]
	    public ActionResult Login(string username, string password, string redirectUrl)
	    {
		    // login would happen here...

			return Redirect(redirectUrl);
	    }
    }
}