using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HashGag.Models.ViewModels;
using HashGag.Utils;

namespace HashGag.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string twitterName = CookieUtil.GetUserFromAuthCookie(User);
            //NavigationBar navigationBar = new NavigationBar(twitterName);
            //return this.View(navigationBar);
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
    }
}