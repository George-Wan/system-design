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

        public string TinyToLong(string tinyURL)
        {
            int id = 0;
            foreach (var s in tinyURL)
            {
                id = id * 62 + base62.IndexOf(s);
            }
            string longUrl = _tinyUrlDataAccess.GetLongUrl(id);
            return longUrl;
        }

        public string LongToTiny(string longURL)
        {
            int lastInsertedId = _tinyUrlDataAccess.CreateTinyUrl(longURL);
            return IdToTinyUrl(lastInsertedId);
        }

        private string IdToTinyUrl(int id) 
        {
            
            string tinyUrl = "";

            while (id > 0){
                tinyUrl = base62[id % 62] + tinyUrl;
                id /= 62;
            }

            while (tinyUrl.Length < 6) {
                tinyUrl = "0" + tinyUrl;
            }

            return tinyUrl;

        }
    }
}
