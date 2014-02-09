using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HashGag.Models;

namespace HashGag.Controllers
{
    public class CompetitionController : Controller
    {
        //
        // GET: /Competition/
        public ActionResult Index()
        {
            TwitterUser tu = new TwitterUser();
            tu.ScreenName = "Gary_Claret";

            Question question = new Question();
            question.Text = "The current Hashgag is: #SadToys";
 
            question.CreationDate = new DateTimeOffset(new DateTime(2014,02,08));
    
            question.QuestionID = 1;
            question.StartDate = new DateTimeOffset(new DateTime(2014,02,08));
            question.TwitterUser = tu;

            question.TwitterUser = new TwitterUser();
            hashgagEntities db = new hashgagEntities();

            

            //db.Questions.Add(question);

            //db.SaveChanges();

            //Question newQuestion = db.Questions.First();

            return View(question);
        }
	}
}