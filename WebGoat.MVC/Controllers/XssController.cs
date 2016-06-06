using System;
using System.Data.SqlClient;
using System.Web.Mvc;
using WebGoat.MVC.Models;

namespace WebGoat.MVC.Controllers
{
    public class XssController : Controller
    {
        public ActionResult JsEncode(XssViewModel model)
        {
            return View(model);
        }

		public ActionResult Classical(HtmlXssViewModel model)
		{
			return View(model);
		}
	}
}