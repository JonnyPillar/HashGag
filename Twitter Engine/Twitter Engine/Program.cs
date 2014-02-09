using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterToken;
using TweetinCore.Interfaces.TwitterToken;
using Twitter_Engine.Models;

namespace Twitter_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FetchTweets();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        public static void FetchTweets()
        {
            TwitterFetcher fetcher = new TwitterFetcher();
            TweetManager cTweet = new TweetManager(fetcher);
        }
    }
}
