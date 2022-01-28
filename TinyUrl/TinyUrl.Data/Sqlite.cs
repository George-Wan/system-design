using System;
using System.Data.SQLite;
using System.IO;

namespace TinyUrl.Data
{
    public class Sqlite
    {
        public SQLiteConnection conn;

        public Sqlite()
        {
            conn = new SQLiteConnection("Data Source=tinyurl.database");

            if (!File.Exists("./tinyurl.database")) 
            {
                SQLiteConnection.CreateFile("tinyurl.database");
            }
        }
    }
}
