using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TinyUrl.Service;

namespace TinyUrl.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TinyUrlController : ControllerBase
    {

        private readonly ILogger<TinyUrlController> _logger;
        private readonly ITinyUrlService _tinyUrlService;
        private readonly string baseUrl =  "mytinyurl.com/";
        public TinyUrlController(ILogger<TinyUrlController> logger, ITinyUrlService tinyUrlService)
        {
            _logger = logger;
            _tinyUrlService = tinyUrlService;
        }

        [HttpGet]
        public string Get(string shortURL)
        {
            return _tinyUrlService.TinyToLong(shortURL.Replace(baseUrl, ""));
        }

        [HttpPost]
        public string Shorten(string longURL)
        {
            return baseUrl + _tinyUrlService.LongToTiny(longURL);
        }
    }
}
