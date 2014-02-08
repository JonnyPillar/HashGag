using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TweetinCore.Events;
using TweetinCore.Extensions;
using TweetinCore.Interfaces;
using TweetinCore.Interfaces.TwitterToken;
using Tweetinvi;
using Tweetinvi.TwitterEntities;
using TwitterToken;

namespace Twitter_Engine
{
    public class CompetitionTweet
    {
        private String sender;

        public CompetitionTweet(ITweetFetcher tweetFetcher, String hashtag)
        {
            var tweets = tweetFetcher.GetListOfTweetsWithHashTag(hashtag);
            sender = tweets.First().Creator.ScreenName;
        }

        public string Sender()
        {
            return sender;
        }
    }
}
