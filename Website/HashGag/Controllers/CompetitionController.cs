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
            Question question = new Question();
            question.Text = "Hello Gary";
            hashgagEntities db = new hashgagEntities();

            db.Questions.Add(question);


            db.SaveChanges();

            Question newQuestion = db.Questions.First();

            return View(newQuestion);
        }
	}
}