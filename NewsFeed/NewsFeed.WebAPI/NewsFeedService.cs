using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeed.WebAPI
{
    public class NewsFeedService
    {
        public NewsFeed GetNewsFeed(int userId)
        {
            NewsFeedDataAccess newsFeedDataAccess = new NewsFeedDataAccess();
            return newsFeedDataAccess.GetNewsFeed(userId);
        }
    }
}
