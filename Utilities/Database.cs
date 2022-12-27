using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace CinemaManager.Utilities
{
    internal class Database
    {
        private static SQLiteConnection connection;
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

            connection.Close();
        }
    }
}

