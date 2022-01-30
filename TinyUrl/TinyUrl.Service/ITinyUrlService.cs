namespace TinyUrl.Service
{
    public interface ITinyUrlService
    {
        public string LongToTiny(string longURL);
        public string TinyToLong(string shortURL);
    }
}
