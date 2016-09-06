using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGoat.MVC.Controllers
{
    public class DirectRefController : Controller
    {
	    public ActionResult Index()
	    {
		    return View();
	    }

        public ActionResult Files(string fileName)
        {
			string path = HttpContext.Server.MapPath("~/Content/files/" + fileName);
	        return new ContentResult {ContentType = "text", Content = System.IO.File.ReadAllText(path)};
        }
    }
}