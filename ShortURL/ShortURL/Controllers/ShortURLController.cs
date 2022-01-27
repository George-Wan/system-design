using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShortURLWebAPI.Services;

namespace ShortURL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShortURLController : ControllerBase
    {
      
        private readonly ILogger<ShortURLController> _logger;
        private readonly IShortURLService _shortURLService;

        public ShortURLController(ILogger<ShortURLController> logger, IShortURLService shortURLService)
        {
            _logger = logger;
            _shortURLService = shortURLService;
        }

        [HttpGet]
        public string Get(string shortURL)
        {
            return _shortURLService.Dncode(shortURL);
        }

        [HttpPost]
        public string Shorten([FromBody]string longURL)
        {
            return _shortURLService.Encode(longURL);
        }
    }
}
