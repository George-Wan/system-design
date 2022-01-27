using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortURLWebAPI.Services
{
    public interface IShortURLService
    {
        public string Encode(string longURL);
        public string Dncode(string shortURL);
    }
}
