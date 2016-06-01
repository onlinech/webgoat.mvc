using System;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace WebGoat.MVC.Controllers
{
    public class XssController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Xss Example";

            return View();
        }

    }
}