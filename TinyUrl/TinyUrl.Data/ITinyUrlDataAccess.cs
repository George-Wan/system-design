namespace TinyUrl.Data
{
    public interface ITinyUrlDataAccess
    {
        public int CreateTinyUrl(string longUrl);
        public string GetLongUrl(int id);
    }
}
