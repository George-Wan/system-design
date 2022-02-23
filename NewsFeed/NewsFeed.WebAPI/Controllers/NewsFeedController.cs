using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace NewsFeed.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsFeedController : ControllerBase
    {
        private NewsFeedService _newsFeedService;

        public NewsFeedController()
        {
            _newsFeedService = new NewsFeedService();
        }

        [HttpGet]
        public IEnumerable<NewsFeed> Get(int userId)
        {

            return _newsFeedService.GetNewsFeed(userId);
        }
    }
}
