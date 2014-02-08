using System;
using System.Collections.Generic;
using System.Linq;
using TweetinCore.Interfaces;

namespace Twitter_Engine
{
    public class CompetitionTweet
    {
        private readonly String sender;

        public CompetitionTweet(ITweetFetcher tweetFetcher, String hashtag)
        {
            List<ITweet> tweets = tweetFetcher.GetListOfTweetsWithHashTag(hashtag);
            sender = tweets.First().Creator.ScreenName;
        }

        public string Sender()
        {
            return sender;
        }
    }
}