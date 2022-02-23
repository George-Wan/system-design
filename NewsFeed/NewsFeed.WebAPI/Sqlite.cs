using System.Data.SQLite;
using System.IO;

namespace TinyUrl.Data
{
    public class Sqlite
    {
        public SQLiteConnection conn;

        public Sqlite()
        {
            conn = new SQLiteConnection("Data Source=news_feed_db.db");

            if (!File.Exists("./news_feed_db.db")) 
            {
                SQLiteConnection.CreateFile("news_feed_db.db");
            }
        }
    }
}
