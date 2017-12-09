using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace xmas.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            string User = Session["Username"].ToString();
            if (User == null) RedirectToAction("Index", "Home");
            Utilities.Utility.GetGifts(User);
            return View();
        }
    }
}