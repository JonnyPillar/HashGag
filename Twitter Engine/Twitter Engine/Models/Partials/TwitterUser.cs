using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetinCore.Interfaces;

namespace Twitter_Engine.Models
{
   public partial class TwitterUser
    {
       public TwitterUser(ITweet tweet)
       {
           if (tweet.Creator.Id != null) TwitterID = (long)tweet.Creator.Id;
           CreatedAt = tweet.Creator.CreatedAt;
           Description = tweet.Creator.Description;
           FavouritesCount = tweet.Creator.FavouritesCount;
           if (tweet.Creator.FollowersCount != null) FollowersCount = (int) tweet.Creator.FollowersCount;
           if (tweet.Creator.FriendsCount != null) FriendsCount = (int)tweet.Creator.FriendsCount;
           IDStr = tweet.Creator.IdStr;
           if (tweet.Creator.ListedCount != null) ListedCount = (int) tweet.Creator.ListedCount;
           Location = tweet.Creator.Location;
           Name = tweet.Creator.Name;
           ProfileImageURL = tweet.Creator.ProfileImageURL;
           ProfileImageURLHttps = tweet.Creator.ProfileImageURLHttps;
           ScreenName = tweet.Creator.ScreenName;
           if (tweet.Creator.StatusesCount != null) StatusesCount = (int)tweet.Creator.StatusesCount;
       }
    }
}
