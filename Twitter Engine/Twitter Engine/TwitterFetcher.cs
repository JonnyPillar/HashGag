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
using TwitterToken;

namespace Twitter_Engine
{
    public class TwitterFetcher : ITweetFetcher
    {
        private IToken token;
        public TwitterFetcher()
        {
            token = new Token(
            ConfigurationManager.AppSettings["token_AccessToken"],
            ConfigurationManager.AppSettings["token_AccessTokenSecret"],
            ConfigurationManager.AppSettings["token_ConsumerKey"],
            ConfigurationManager.AppSettings["token_ConsumerSecret"]);

        }
        public List<ITweet> GetListOfTweetsWithHashTag(string hashTag)
        {
           return GetListOfTweetsWithHashTag(hashTag, 0);
        }

        public List<ITweet> GetListOfTweetsWithHashTag(string hashTag, long maxID)
        {
            List<ITweet> tweetsForHashtag = new List<ITweet>();

            ObjectResponseDelegate responseDelegate = tweetsMatchingQuery =>
            {
                foreach (var matchingTweet in StatusesOf(tweetsMatchingQuery))
                {
                    tweetsForHashtag.Add(new Tweet(matchingTweet));
                }
            };
            if (maxID == 0)
            {
                token.ExecuteGETQuery(SearchQuery(hashTag), responseDelegate);
            }
            else
            {
                token.ExecuteGETQuery(SearchQueryWithMaxID(hashTag, maxID), responseDelegate);
            }

            return tweetsForHashtag;
        }

        private static IEnumerable<Dictionary<string, object>> StatusesOf(Dictionary<string, object> tweetsMatchingQuery)
        {
            return tweetsMatchingQuery.GetPropCollection<Dictionary<string, object>>("statuses");
        }

        private static string SearchQuery(string hashTag)
        {
            return String.Format("https://api.twitter.com/1.1/search/tweets.json?q=%23{0}&count=100", hashTag);
        }

        private static string SearchQueryWithMaxID(String hashtag, long maxID)
        {
            return String.Format("https://api.twitter.com/1.1/search/tweets.json?max_id={0}&q=%23{1}&count=100", maxID,
                hashtag);
        }
    }

    
}
