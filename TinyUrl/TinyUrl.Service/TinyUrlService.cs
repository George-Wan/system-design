using System;
using TinyUrl.Data;

namespace TinyUrl.Service
{
    public class TinyUrlService : ITinyUrlService
    {
        private readonly ITinyUrlDataAccess _tinyUrlDataAccess;
        public TinyUrlService(ITinyUrlDataAccess tinyUrlDataAccess)
        {
            _tinyUrlDataAccess = tinyUrlDataAccess;
        }
        public string Decode(string shortURL)
        {
            _tinyUrlDataAccess.doSomething();
            return "ss";
        }

        public string Encode(string longURL)
        {
            _tinyUrlDataAccess.doSomething();
            return "bb";
        }
    }
}
