using CinemaManager.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Models
{
    internal class DatabaseManager
    {
        private void ClearDatabase()
        {
            Database.Initialize();
            Database.ExecuteQuery("DROP TABLE movies");
            Database.Close();
        }

        private void CreateMovieTable()
        {
            string createMoviesTable = "CREATE TABLE IF NOT EXISTS movies (id INTEGER PRIMARY KEY AUTOINCREMENT, title TEXT, year TEXT, rated TEXT, released TEXT, runtime TEXT, genre TEXT, director TEXT, writer TEXT, actors TEXT, plot TEXT, language TEXT, country TEXT, awards TEXT, poster TEXT, metascore TEXT, imdbRating TEXT, imdbVotes TEXT, imdbID TEXT, type TEXT, dvd TEXT, boxOffice TEXT, production TEXT, website TEXT, dubbed INTEGER)";
            Database.Initialize();
            Database.ExecuteQuery(createMoviesTable);
            Database.Close();
        }
    }
}
