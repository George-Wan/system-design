namespace TinyUrl.Service
{
    public interface ITinyUrlService
    {
        public string LongToShort(string longURL);
        public string ShortToLong(string shortURL);
    }
}
