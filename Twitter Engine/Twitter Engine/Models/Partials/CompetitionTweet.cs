using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetinCore.Interfaces;

namespace Twitter_Engine.Models
{
    public partial class CompetitionTweet
    {
        public CompetitionTweet()
        {
            
        }

        public CompetitionTweet(ITweet tweet, int currentQuestionID)
        {
            QuestionID = currentQuestionID;
            TweetID = tweet.Id;
        }
    }
}
