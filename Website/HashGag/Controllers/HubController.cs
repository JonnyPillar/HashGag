using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HashGag.Models;
using HashGag.Models.ViewModels;

namespace HashGag.Controllers
{
    public class HubController : Controller
    {
        //
        // GET: /Hub/
        public ActionResult Index()
        {
            hashgagEntities db = new hashgagEntities();
            List<Question> questionList = new List<Question>();

            Question sdf = new Question();

            sdf.Text = "New Question";
            sdf.TwitterUser = new TwitterUser();
            sdf.TwitterUser.ProfileImageURL = "https://pbs.twimg.com/profile_images/3685227674/67c501ba4eb74c8b7426f1109b38e70a_bigger.jpeg";
            sdf.EndDate = new DateTimeOffset(DateTime.Now);

            questionList.Add(sdf);
            Question sdfa = new Question();
            sdfa.Text = "New Question Two";
            sdfa.TwitterUser = new TwitterUser();
            sdfa.TwitterUser.ProfileImageURL = "https://pbs.twimg.com/profile_images/3685227674/67c501ba4eb74c8b7426f1109b38e70a_bigger.jpeg";
            sdfa.EndDate = new DateTimeOffset(DateTime.Now);
            questionList.Add(sdfa);
            Question sdsf = new Question();
            sdsf.Text = "New Question Three";
            sdsf.TwitterUser = new TwitterUser();
            sdsf.TwitterUser.ProfileImageURL = "https://pbs.twimg.com/profile_images/3685227674/67c501ba4eb74c8b7426f1109b38e70a_bigger.jpeg";
            sdsf.EndDate = new DateTimeOffset(DateTime.Now);
            questionList.Add(sdsf);
            Question sddf = new Question();
            sddf.Text = "New Question Four";
            sddf.TwitterUser = new TwitterUser();
            sddf.TwitterUser.ProfileImageURL = "https://pbs.twimg.com/profile_images/3685227674/67c501ba4eb74c8b7426f1109b38e70a_bigger.jpeg";
            sddf.EndDate = new DateTimeOffset(DateTime.Now);
            questionList.Add(sddf);
            Question sfdf = new Question();
            sfdf.Text = "New Question Five";
            sfdf.TwitterUser = new TwitterUser();
            sfdf.TwitterUser.ProfileImageURL = "https://pbs.twimg.com/profile_images/3685227674/67c501ba4eb74c8b7426f1109b38e70a_bigger.jpeg";
            sfdf.EndDate = new DateTimeOffset(DateTime.Now);
            questionList.Add(sfdf);

            HubViewModel model = new HubViewModel(questionList, questionList, questionList);

            return View(model);
        }
	}
}