using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace xmas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string username, string password)
        {
            if (ModelState.IsValid)
            {
               var x = Utilities.Utility.CheckIfUserExist(username, password);
               if(x == 1)
                {
                    Session["Username"] = username;
                    return RedirectToAction("Index", "Dashboard");
                }
                return Json(new { success = false, message = "Inlog klopt niet .. " });
            }
            return Json(new { success = false, message = "Fout opgetreden met het inloggen. FFkes je admin bellen." });
        }
    }
}