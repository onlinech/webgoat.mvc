using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGoat.MVC.Models;

namespace WebGoat.MVC.Controllers
{
	[Authorize]
	public partial class CrossSiteRequestForgeryController : Controller
	{
		public static List<Models.CreatedUser> CreatedUsers = new List<CreatedUser>();

        [HttpPost]
        public ActionResult CreateUser(string username)
        {
			CreatedUsers.Add(new Models.CreatedUser {Username = username, CreatedByUser = User.Identity.Name});
	        return Redirect("Users");
        }

		public ActionResult Users()
		{
			return View(CreatedUsers);
		}
	}
}