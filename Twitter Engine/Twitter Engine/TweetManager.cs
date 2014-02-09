using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using NUnit.Framework;
using TweetinCore.Interfaces;
using Twitter_Engine.Models;

namespace Twitter_Engine
{
    public class TweetManager
    {
        hashgagEntities db = new hashgagEntities();
        public TweetManager(ITweetFetcher tweetFetcher)
        {
            var questions = db.Questions
                .Where (q=> q.StartDate <= DateTime.Now )
                .Where(q=> q.EndDate >= DateTime.Now);

            foreach (Question currentQuestion in questions )
            {
                string hashtag = currentQuestion.Text;
                List<ITweet> tweets = new List<ITweet>();
                List<ITweet> currentTweetFetch = tweetFetcher.GetListOfTweetsWithHashTag(hashtag);
                tweets.AddRange(currentTweetFetch);
                int numberofCalls = 0;
                while (currentTweetFetch.Count > 0 && numberofCalls <=25)
                {
                        currentTweetFetch = tweetFetcher.GetListOfTweetsWithHashTag(hashtag,
                            (long) currentTweetFetch.Last().Id - 1);
                        tweets.AddRange(currentTweetFetch);
                    numberofCalls++;
                }
                ProcessTweets(tweets, currentQuestion.QuestionID);
            }

           
        }

        public void ProcessTweets(List<ITweet> tweets, int currentQuestionID)
        {
            List<TwitterUser> addedUsers = db.TwitterUsers.ToList();
            foreach (ITweet tweet in tweets)
            {
                TwitterUser newUser = new TwitterUser(tweet);
                bool alreadyAdded = false;
               foreach (TwitterUser user in addedUsers)
                {
                    if (user.TwitterID == newUser.TwitterID)
                    {
                        alreadyAdded = true;
                    }
                }
                if(alreadyAdded == false)
                {
                    db.TwitterUsers.Add(newUser);
                    addedUsers.Add(newUser);
                }
                var lookupTweet = db.Tweets
                    .FirstOrDefault(t => t.TweetID == tweet.Id);
                if (lookupTweet == null)
                {
                    if (!tweet.Text.StartsWith("RT"))
                    {
                        db.Tweets.Add(new Tweet(tweet));
                        db.CompetitionTweets.Add(new CompetitionTweet(tweet, currentQuestionID));
                    }
                }
                else
                {
                    if (lookupTweet.RetweetCount != tweet.RetweetCount)
                    {
                        lookupTweet.RetweetCount = tweet.RetweetCount;
                    }
                }
               
            }
            if (db.ChangeTracker.HasChanges())
            {
                db.SaveChanges();
            }
            Console.WriteLine("Committed Changes");
        }
    }
}