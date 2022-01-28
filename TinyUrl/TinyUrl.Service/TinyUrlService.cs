using TinyUrl.Data;

namespace TinyUrl.Service
{
    public class TinyUrlService : ITinyUrlService
    {
        private readonly ITinyUrlDataAccess _tinyUrlDataAccess;
        private readonly string base62 = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public TinyUrlService(ITinyUrlDataAccess tinyUrlDataAccess)
        {
            _tinyUrlDataAccess = tinyUrlDataAccess;
        }
        public string ShortToLong(string shortURL)
        {
            int id = 0;
            foreach (var s in shortURL)
            {
                id = id * 62 + base62.IndexOf(s);
            }
            _tinyUrlDataAccess.doSomething();
            return "ss";
        }

        public string LongToShort(string longURL)
        {
            _tinyUrlDataAccess.doSomething();
            int id = 100;
            return IdToUrl(id);
        }

        private string IdToUrl(int id) 
        {
            
            string tinyUrl = "";

            while (id > 0){
                tinyUrl = base62[id % 62] + tinyUrl;
                id /= 62;
            }

            while (tinyUrl.Length < 6) {
                tinyUrl += "0";
            }

            return tinyUrl;

        }
    }
}
