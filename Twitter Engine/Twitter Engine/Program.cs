using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterToken;
using TweetinCore.Interfaces.TwitterToken;

namespace Twitter_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FetchTweets("studenthack");
        }

        public static void FetchTweets(String hashtag)
        {
            TwitterFetcher fetcher = new TwitterFetcher();
            CompetitionTweet cTweet = new CompetitionTweet(fetcher, hashtag);
        }
    }
}
