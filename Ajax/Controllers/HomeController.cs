using Ajax.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetPartialView(string name)
        {
            return PartialView("_Greetings", name);
        }

        [HttpPost]
        public ActionResult SaveData(FriendViewModel vm)
        {
            return Json(ModelState.IsValid);
        }
    }
}