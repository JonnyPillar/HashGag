using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using HashGag.Models;
using HashGag.Models.ViewModels;
using Microsoft.Ajax.Utilities;

namespace HashGag.Controllers
{
    public class HubController : Controller
    {
        //
        // GET: /Hub/
        //public ActionResult Index()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        string tempas = string.Empty;
        //    }
        //    hashgagEntities db = new hashgagEntities();
            
        //    string username = User.Identity.Name;
        //    List<Question> temp = db.Questions.ToList();
        //    HubViewModel model = new HubViewModel(temp, temp, temp);

        //    return View(model);
        //}

        public ActionResult Index(string id, string status)
        {
            if(!id.IsNullOrWhiteSpace() && !status.IsNullOrWhiteSpace() )
            {
                FormsAuthentication.SetAuthCookie(id, true);
            }
            
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                        
            }
            hashgagEntities      db = new hashgagEntities();
            List<Question> temp = db.Questions.ToList();
            HubViewModel model = new HubViewModel(temp, temp, temp);

            return View(model);
        }
	}
}