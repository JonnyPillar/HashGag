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
            public void DoesTweetMatchHashTag()
            {
                List<ITweet> matchingTweets = new TwitterFetcher().GetListOfTweetsWithHashTag("nicetrydickheadbob");
                ITweet tweet = matchingTweets.First();
                Assert.That(tweet.Hashtags.First().Text, Is.EqualTo("nicetrydickheadbob"));
            }

            [Test]
            public void TestGetNumberOfTweetsForHashtag()
            {
                List<ITweet> matchingTweets = new TwitterFetcher().GetListOfTweetsWithHashTag("sochiproblems");
                Assert.That(matchingTweets.Count, Is.GreaterThan(0));
            }
        }
    }
}