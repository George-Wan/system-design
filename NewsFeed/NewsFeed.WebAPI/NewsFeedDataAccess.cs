using System.Data.SQLite;
using TinyUrl.Data;

namespace NewsFeed.WebAPI
{
    public class NewsFeedDataAccess
    {
        Sqlite database;
        private readonly string getNewsFeed = "SELECT n.Id, n.Post, u.Name FROM NewsFeed n, Followers f, User u, WHERE u.Id = n.Sender, n.Sender = f.Followee and f.Follower = @id";

        public NewsFeedDataAccess()
        {
            database = new Sqlite();
        }

        public NewsFeed GetNewsFeed(int userId)
        {
            SQLiteCommand sqLiteCommand = new SQLiteCommand(getNewsFeed, database.conn);
            sqLiteCommand.Parameters.AddWithValue("@id", userId);
            database.conn.Open();

            sqLiteCommand.ExecuteReader();

            database.conn.Close();

            return new NewsFeed();
        }
    }
}
