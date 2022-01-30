using System;
using System.Data.SQLite;

namespace TinyUrl.Data
{
    public class TinyUrlDataAccess: ITinyUrlDataAccess
    {
        Sqlite database;
        private readonly string insertLongUrl = "INSERT INTO LongUrl (`longUrl`) VALUES (@longUrl)";
        private readonly string getLastInsertId = "SELECT last_insert_rowid()";
        private readonly string getLongUrl = "SELECT longUrl FROM LongUrl WHERE id = @id";

        public TinyUrlDataAccess()
        {
            database = new Sqlite();
        }

        public int CreateTinyUrl(string longUrl)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand(insertLongUrl, database.conn);
            database.conn.Open();

            sqLiteCommand.Parameters.AddWithValue("@longUrl", longUrl);
            sqLiteCommand.ExecuteNonQuery();

            sqLiteCommand.CommandText = getLastInsertId;

            Int64 lastInsertRowId = (Int64)sqLiteCommand.ExecuteScalar();

            database.conn.Close();

            return (int)lastInsertRowId;
        }

        public string GetLongUrl(int id)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand(getLongUrl, database.conn);
            sqLiteCommand.Parameters.AddWithValue("@id", id);
            database.conn.Open();

            string longUrl = (string)sqLiteCommand.ExecuteScalar();
           
            database.conn.Close();

            return longUrl;
        }

    }
}
