using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HashGag.Models;
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

            Tweet tweet = new Tweet();
            tweet.Text =
                "Plopopoly PlopopolyPlopopoly";
            tweet.TwitterUser = new TwitterUser();
            tweet.TwitterUser.ScreenName = "Gary_Claret";
            tweet.TwitterUser.ProfileImageURL = "https://pbs.twimg.com/profile_images/96779181/chelsea2.jpg";
            tweet.RetweetCount = 326;

            return View(tweet);
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