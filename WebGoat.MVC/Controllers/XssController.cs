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
            ViewBag.Message = "Welcome to the Xss Example";

            return View(model);
        }
    }
}