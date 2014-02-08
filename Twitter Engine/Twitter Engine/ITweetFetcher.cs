using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetinCore.Interfaces;

namespace Twitter_Engine
{
    public interface ITweetFetcher
    {
        List<ITweet> GetListOfTweetsWithHashTag(string hashTag);
        List<ITweet> GetListOfTweetsWithHashTag(string hashTag, long maxID);
    }
}
