using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TweetinCore.Interfaces;
using Tweetinvi;
using Twitter_Engine;
using Assert = NUnit.Framework.Assert;

namespace Twitter_Engine_Tests
{
    [TestClass]
    public class TweetFetcherTester
    {
        [TestFixture]
        public class TestTweetInvi
        {
            [Test]
            public void doesTweetMatchHashTag()
            {
                List<ITweet> matchingTweets = new TwitterFetcher().GetListOfTweetsWithHashTag("nicetrydickheadbob");
                ITweet tweet = matchingTweets.First();
                Assert.That(tweet.Hashtags.First().Text, Is.EqualTo("nicetrydickheadbob"));
            }

            [Test]
            public void testGetNumberOfTweetsForHashtag()
            {
                List<ITweet> matchingTweets = new TwitterFetcher().GetListOfTweetsWithHashTag("nicetrydickheadbob");
                Assert.That(matchingTweets.Count, Is.GreaterThan(0));
            }
        }

        [TestFixture]
        public class TestTweetManipulation : ITweetFetcher
        {
            public List<ITweet> GetListOfTweetsWithHashTag(string hashTag)
            {
                var listOfTweets = new List<ITweet>();
                ITweet tweet = new Tweet();
                tweet.Creator = new User("Jimmy");
                listOfTweets.Add(tweet);
                return listOfTweets;
            }

            [Test]
            public void testTwitterUsernamePresence()
            {
                string sender = new CompetitionTweet(this).Sender();
                Assert.That(sender, Is.EqualTo("Jimmy"));
            }
        }
    }
}