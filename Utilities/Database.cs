using System.Data.SQLite;
using System.IO;

namespace CinemaManager.Utilities
{
    internal class Database
    {
        public static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;

        public static void Initialize()
        {
            connection = new SQLiteConnection("Data Source=cinema.db;Version=3;");
            connection.Open();
        }

        public static void Close()
        {
            connection.Close();
        }

        public static void ExecuteQuery(string query)
        {
            command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public static SQLiteDataReader ExecuteReader(string query)
        {
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();
            return reader;
        }
        public static void CreateDatabase(string targetFolder, string fileName)
        {

            string targetPath = "C:\\Users\\mohje\\source\\repos\\CinemaManager\\Database\\";

            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            string databasePath = Path.Combine(targetPath, fileName);

            if (!File.Exists(databasePath))
            {
                SQLiteConnection.CreateFile(databasePath);
            }

            SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath};Version=3;");
            connection.Open();

            // Execute SQL statements to create the database structure here...
            string createMoviesTable = "CREATE TABLE IF NOT EXISTS movies (id INTEGER PRIMARY KEY AUTOINCREMENT, title TEXT, year TEXT, rated TEXT, released TEXT, runtime TEXT, genre TEXT, director TEXT, writer TEXT, actors TEXT, plot TEXT, language TEXT, country TEXT, awards TEXT, poster TEXT, metascore TEXT, imdbRating TEXT, imdbVotes TEXT, imdbID TEXT, type TEXT, dvd TEXT, boxOffice TEXT, production TEXT, website TEXT)";
            ExecuteQuery(createMoviesTable);

            connection.Close();
        }
    }
}

