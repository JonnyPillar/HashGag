using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HashGag.Models;

namespace HashGag.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult Index()
        {
            TwitterUser tu = new TwitterUser();
            tu.ScreenName = "Gary_Claret";
            
            return View(tu);
        }
	}
}