using CinemaManager.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManager.Models
{
    internal class MovieManager
    {

        public static async Task<Movie> GetMoviesApiAsync(string title, string id, string date)
        {
            string key = "cbedc33";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"http://www.omdbapi.com/");
            string resourceUri = $"?apikey={key}{(title != "" ? $"&t={title}" : $"&i={id}")}&type=movie{(date != "0" ? "&year=" + date : null)}";

            HttpResponseMessage response = await client.GetAsync(resourceUri);
            try
            {
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Movie movies = JsonConvert.DeserializeObject<Movie>(responseBody);

                if (movies.Title != null)
                {
                    return movies;
                }
                else
                {
                    MovieSearchResult result = JsonConvert.DeserializeObject<MovieSearchResult>(responseBody);
                    MessageBox.Show(result.Error);
                    return null;
                }
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public static List<Movie> GetAllMoviesLocal()
        {
            List<Movie> movieList = new List<Movie>();
            Database.Initialize();
            var reader = Database.ExecuteReader("SELECT * FROM movies");
            while (reader.Read())
            {
                Movie movie = new Movie();
                movie.Title = reader.GetString(1);
                movie.Year = reader.GetString(2);
                movie.Rated = reader.GetString(3);
                movie.Released = reader.GetString(4);
                movie.Runtime = reader.GetString(5);
                movie.Genre = reader.GetString(6);
                movie.Director = reader.GetString(7);
                movie.Writer = reader.GetString(8);
                movie.Actors = reader.GetString(9);
                movie.Plot = reader.GetString(10);
                movie.Language = reader.GetString(11);
                movie.Country = reader.GetString(12);
                movie.Awards = reader.GetString(13);
                movie.Poster = reader.GetString(14);
                movie.Metascore = reader.GetString(15);
                movie.imdbRating = reader.GetString(16);
                movie.imdbVotes = reader.GetString(17);
                movie.imdbID = reader.GetString(18);
                movie.Type = reader.GetString(19);
                movie.DVD = reader.GetString(20);
                movie.BoxOffice = reader.GetString(21);
                movie.Production = reader.GetString(22);


                // Add the movie object to a list or do something else with it
                movieList.Add(movie);
            }
            Database.Close();
            return movieList;
        }
        public static List<Movie> GetMovie(string title)
        {
            List<Movie> movieList = new List<Movie>();
            Database.Initialize();

            var reader = Database.ExecuteReader($"SELECT * FROM movies WHERE title = '{title}'");
            while (reader.Read())
            {
                Movie movie = new Movie();
                movie.Title = reader.GetString(1);
                movie.Year = reader.GetString(2);
                movie.Rated = reader.GetString(3);
                movie.Released = reader.GetString(4);
                movie.Runtime = reader.GetString(5);
                movie.Genre = reader.GetString(6);
                movie.Director = reader.GetString(7);
                movie.Writer = reader.GetString(8);
                movie.Actors = reader.GetString(9);
                movie.Plot = reader.GetString(10);
                movie.Language = reader.GetString(11);
                movie.Country = reader.GetString(12);
                movie.Awards = reader.GetString(13);
                movie.Poster = reader.GetString(14);
                movie.Metascore = reader.GetString(15);
                movie.imdbRating = reader.GetString(16);
                movie.imdbVotes = reader.GetString(17);
                movie.imdbID = reader.GetString(18);
                movie.Type = reader.GetString(19);
                movie.DVD = reader.GetString(20);
                movie.BoxOffice = reader.GetString(21);
                movie.Production = reader.GetString(22);
                movieList.Add(movie);
            }
            return movieList;
        }
        //Delete movie method that accepts title as a parameter
        public static void DeleteMovie(string title)
        {
            Database.Initialize();
            Database.ExecuteQuery($"DELETE FROM movies WHERE title = '{title}'");
            //Eyvallah database
            Database.Close();
        }
        //Add movie method; takes Columns and Values List as parameters
        public static void AddMovie(List<string> columns, List<string> values)
        {
           

            Database.Initialize();
            Database.ExecuteQuery($"INSERT INTO movies ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values)})");
            Database.Close();
        }

    }
}
