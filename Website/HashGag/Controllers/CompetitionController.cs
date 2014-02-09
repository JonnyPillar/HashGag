using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HashGag.Models;
using HashGag.Models.ViewModels;

namespace HashGag.Controllers
{
    public class CompetitionController : Controller
    {
        //
        // GET: /Competition/
        public ActionResult Index()
        {
            var model = new CompetitionViewModel(null, null, null, null);
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var db = new hashgagEntities();

            var query = from q in db.Questions
                join cpt in db.CompetitionTweets on q.QuestionID equals cpt.QuestionID
                join t in db.Tweets on cpt.TweetID equals t.TweetID
                join tu in db.TwitterUsers on t.TwitterUserID equals tu.TwitterID
                where q.QuestionID == id
                select new {q, t, tu, cpt};

            var list = new List<CompTweetModel>();
            Question question = null;
            if (query.Count() == 0) question = new Question();
            foreach (var item in query)
            {
                if (question == null) question = item.q;
                Tweet tweet = item.t;
                tweet.RetweetCount++;
                TwitterUser tUser = item.tu;

                var cTUser = new CompTweetModel(tweet, tUser);

                list.Add(cTUser);
            }

            var highestscoringOrderedTweets = new List<CompTweetModel>();
            var mostRecentOrderedTweets = new List<CompTweetModel>();
            var myOrdereedTweets = new List<CompTweetModel>();

            highestscoringOrderedTweets.AddRange(from atweet in list
                orderby atweet.tweet.RetweetCount descending
                select atweet);
            mostRecentOrderedTweets.AddRange(from atweet in list orderby atweet.tweet.CreatedAt descending select atweet);

            HttpCookie requestCookie = Request.Cookies["HashGaga"];

            if (requestCookie != null)
            {
                int FirstInstanceOfUser =
                    highestscoringOrderedTweets.IndexOf((from alltweets in highestscoringOrderedTweets
                        where alltweets.user.ScreenName == requestCookie.Value
                        orderby alltweets.tweet.RetweetCount descending
                        select alltweets).FirstOrDefault());

                int totalNeeded = highestscoringOrderedTweets.Count >= 10
                    ? 10
                    : highestscoringOrderedTweets.Count;


                if (FirstInstanceOfUser - 5 < 0)
                {
                    FirstInstanceOfUser = FirstInstanceOfUser - (FirstInstanceOfUser - 5);
                }
                if (FirstInstanceOfUser + 5 > highestscoringOrderedTweets.Count)
                {
                    FirstInstanceOfUser = FirstInstanceOfUser -
                                          ((FirstInstanceOfUser + 5) - highestscoringOrderedTweets.Count);
                }

                if (totalNeeded < 10)
                {
                    myOrdereedTweets = highestscoringOrderedTweets;
                }
                else
                {
                    foreach (CompTweetModel atweetmodel in highestscoringOrderedTweets)
                    {
                        if (highestscoringOrderedTweets.IndexOf(atweetmodel) >= (FirstInstanceOfUser - 5)
                            && highestscoringOrderedTweets.IndexOf(atweetmodel) < (FirstInstanceOfUser + 5))
                        {
                            myOrdereedTweets.Add(atweetmodel);
                        }
                    }
                }
            }
            ;

            var cmodel = new CompetitionViewModel(question, highestscoringOrderedTweets, myOrdereedTweets,
                mostRecentOrderedTweets);

            return View("Index", cmodel);
        }
    }
}