using CinemaManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Data.SQLite;
using CinemaManager.Utilities;
using System.Reflection;
using System.IO;

namespace CinemaManager.Forms
{
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }

        private async Task<Movie> GetMoviesAsync(string title, string id, string date)
        {
            string key = "cbedc33";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"http://www.omdbapi.com/");
            string resourceUri = $"?apikey={key}{(title!= "" ? $"&t={title}" : $"&i={id}" ) }&type=movie{(date != "0"  ? "&year=" + date : null)}";

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
        private List<Movie> GetMoviesDatabase()
        {
            List<Movie> movieList = new List<Movie>();
            Database.Initialize();
            var reader =  Database.ExecuteReader("SELECT * FROM movies");
            while (reader.Read())
            {
                Movie movie = new Movie();
                movie.Title =  reader.GetString(1);
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
        private List<Movie> GetMovie(string title)
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
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            //Enable the disabled text fields
            MovieTitleText.Enabled = true;
            MovieIdText.Enabled = true;
            if (OnlineDatabaseRadio.Checked == true)
            {
                var movie = await GetMoviesAsync(MovieTitleText.Text, MovieIdText.Text, YearText.Text);
                List<Movie> movieList = new List<Movie> { movie };
                if (movie == null)
                {
                    MessageBox.Show("No movies found");

                }
                else
                {
                    MoviesGridView.DataSource = movieList;
                    MoviesGridView.Refresh();
                }
            }
            else if (DatabaseRadio.Checked == true)
            {
                MoviesGridView.DataSource = GetMovie(MovieTitleText.Text);
                MoviesGridView.Refresh();
            }
            else
            {

                MessageBox.Show("Please select a database");

            }
        }
        private void AddToDatabaseBtn_Click(object sender, EventArgs e)
        {
           if(GetMovie(MovieTitleText.Text).Count == 0)
            {
                var grid = MoviesGridView;
                var btn = (Button)sender;
                var columnNames = new List<string>();
                var values = new List<string>();

                foreach (DataGridViewCell cell in grid.SelectedCells)
                {
                    string cellVal = cell.Value.ToString().Replace("'", "''"); // Escape single quotes in the value
                    string columnName = grid.Columns[cell.ColumnIndex].Name;

                    if (!columnNames.Contains(columnName)) // Add column name only once
                    {
                        columnNames.Add(columnName);
                    }

                    values.Add("'" + cellVal + "'"); // Wrap value in single quotes
                }

                var query = $"INSERT INTO movies ({string.Join(",", columnNames)}) VALUES ({string.Join(",", values)})";

                Database.Initialize();
                Database.ExecuteQuery(query);
                Database.Close();
            }
            else
            {
                MessageBox.Show("Movie already in database");
            }
         

        }
        private void MoviesGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = (DataGridView)sender;
            if(grid.Rows[e.RowIndex].Cells[13].Value.ToString() != "N/A")
            {
                MoviePoster.Load(grid.Rows[e.RowIndex].Cells[13].Value.ToString());
            }
            else
            {
                //set default poster
                MoviePoster.Load("C:\\Users\\mohje\\source\\repos\\CinemaManager\\src\\posters\\default-poster.jpeg");

            }
            foreach (TextBox tb in MovieDetailsGroup.Controls.OfType<TextBox>().OrderBy(c => int.Parse((string)c.Tag)))
            {
                tb.Text = grid.Rows[e.RowIndex].Cells[int.Parse((string)tb.Tag) - 1].Value.ToString();
            }
            MoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void DisplayAllMoviesBtn_Click(object sender, EventArgs e)
        {
            List<Movie> movies = GetMoviesDatabase();
            MoviesGridView.DataSource = movies;
        }
        private void UpdateMoviesList()
        {
            List<Movie> movieList = GetMoviesDatabase();
            MoviesGridView.DataSource = movieList;
        }
        private void DeleteMovieBtn_Click(object sender, EventArgs e)
        {
            var grid = MoviesGridView;
            var btn = (Button)sender;

            var columnNames = new List<string>();
            var values = new List<string>();

            foreach (DataGridViewCell cell in grid.SelectedCells)
            {
                string cellVal = cell.Value.ToString().Replace("'", "''"); // Escape single quotes in the value
                string columnName = grid.Columns[cell.ColumnIndex].Name;

                if (!columnNames.Contains(columnName)) // Add column name only once
                {
                    columnNames.Add(columnName);
                }

                values.Add("'" + cellVal + "'"); // Wrap value in single quotes
            }

            var query = $"DELETE FROM movies WHERE title = {values[0]}";

            Database.Initialize();
            Database.ExecuteQuery(query);
            Database.Close();
            UpdateMoviesList();
        }
        private void MovieIdText_TextChanged(object sender, EventArgs e)
        {
            MovieTitleText.Enabled = false;
            MovieTitleText.Text = "";
        }
        private void MovieTitleText_TextChanged(object sender, EventArgs e)
        {
            MovieIdText.Enabled = false;
            MovieIdText.Text = "";
        }
        private void ClearDatabaseButton_Click(object sender, EventArgs e)
        {
            Database.Initialize();
            Database.ExecuteQuery("DROP TABLE movies");
            Database.Close();
        }

        private void CreateMovieTableButton_Click(object sender, EventArgs e)
        {
            string createMoviesTable = "CREATE TABLE IF NOT EXISTS movies (id INTEGER PRIMARY KEY AUTOINCREMENT, title TEXT, year TEXT, rated TEXT, released TEXT, runtime TEXT, genre TEXT, director TEXT, writer TEXT, actors TEXT, plot TEXT, language TEXT, country TEXT, awards TEXT, poster TEXT, metascore TEXT, imdbRating TEXT, imdbVotes TEXT, imdbID TEXT, type TEXT, dvd TEXT, boxOffice TEXT, production TEXT, website TEXT)";
            Database.ExecuteQuery(createMoviesTable);
            Database.Close();
        }

        
    }
}
