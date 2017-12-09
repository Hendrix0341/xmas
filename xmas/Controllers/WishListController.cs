using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using xmas.Models; 
namespace xmas.Controllers
{
    public class WishListController : Controller
    {
        // GET: WishList
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            return PartialView("_Product");
        }

        public ActionResult ConfirmProduct(string product, string url)
        {
            string User = Session["Username"].ToString();
            var x = Utilities.Utility.AddGift(User, product, url);
            if(x == 1)  return Json(new { success = true, message = "Artikel is opgeslagen" });
            return Json(new { success = false, message = "Artikel kon niet worden opgeslagen" });
        }
    }
}