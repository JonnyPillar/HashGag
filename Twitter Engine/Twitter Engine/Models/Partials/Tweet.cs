using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetinCore.Interfaces;

namespace Twitter_Engine.Models
{
   public partial class Tweet
    {
       public Tweet()
       {
           
       }
       public Tweet(ITweet tweet)
       {
           TweetID = tweet.Id;
           TwitterUserID = tweet.Creator.Id;
           CreatedAt = tweet.CreatedAt;
           Favourited = tweet.Favourited;
           IDString = tweet.IdStr;
           InReplyToScreenName = tweet.InReplyToScreenName;
           InReplyToStatusID = tweet.InReplyToStatusId;
           InReplyToStatusIDString = tweet.InReplyToStatusIdStr;
           InReplyToUserID = tweet.InReplyToUserId;
           InReplyToStatusIDString = tweet.InReplyToUserIdStr;
           if (tweet.LocationCoordinates != null)
           {
               Lat = tweet.LocationCoordinates.Lattitude;
               Long = tweet.LocationCoordinates.Longitude;
           }
           RetweetCount = tweet.RetweetCount;
           Retweeted = tweet.Retweeted;
           Text = tweet.Text;

       }
    }
}
