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

        public TinyUrlController(ILogger<TinyUrlController> logger, ITinyUrlService tinyUrlService)
        {
            _logger = logger;
            _tinyUrlService =_tinyUrlService;
        }

        [HttpGet]
        public string Get(string shortURL)
        {
            return _tinyUrlService.Dncode(shortURL);
        }

        [HttpPost]
        public string Shorten([FromBody] string longURL)
        {
            return _tinyUrlService.Encode(longURL);
        }
    }
}
