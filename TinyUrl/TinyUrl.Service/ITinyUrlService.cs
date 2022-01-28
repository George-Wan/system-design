using System;

namespace TinyUrl.Service
{
    public interface ITinyUrlService
    {
        public string Encode(string longURL);
        public string Dncode(string shortURL);
    }
}
