using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HashGag.Models.ViewModels
{
    public class CompTweetModel
    {
        public Tweet tweet;
        public TwitterUser user;

        public CompTweetModel(Tweet newTweet, TwitterUser tUser)
        {
            this.tweet = newTweet;
            this.user = tUser;
        }
    }
}