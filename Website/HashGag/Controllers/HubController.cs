﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HashGag.Models;

namespace HashGag.Controllers
{
    public class HubController : Controller
    {
        //
        // GET: /Hub/
        public ActionResult Index()
        {
            hashgagEntities db = new hashgagEntities();
            List<Question> questionList = db.Questions.ToList();



            Question q1 = new Question();

            q1.Text = "#SadToys";
            
            return View();
        }
	}
}