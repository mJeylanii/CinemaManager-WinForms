using CinemaManager.Models;
using CinemaManager.Utilities;
using CinemaManager.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CinemaManager.Forms
{
    public partial class MovieView : Form, IMovieView


        private readonly MoviePresenter _presenter;
    public MovieView()
        {
            InitializeComponent();
        _presenter = presenter;
    }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            //Enable the disabled text fields
            MovieTitleText.Enabled = true;
            MovieIdText.Enabled = true;
            /*Check if user wants to search online */
            if (OnlineDatabaseRadio.Checked == true)
            {
                var movie = await MovieManager.GetMoviesAsync(MovieTitleText.Text, MovieIdText.Text, YearText.Text);
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
            /*Check if user wants to search locally */
            else if (LocalDatabaseRadio.Checked == true)
            {
                MoviesGridView.DataSource = MovieManager.GetMovie(MovieTitleText.Text);
                MoviesGridView.Refresh();
            }
            else
            {

                MessageBox.Show("Please select a database");

            }
        }
        private void AddToDatabaseBtn_Click(object sender, EventArgs e)//On click event of Add to database button
        {
            //First check if movie already exists in the movies table
            if (MovieManager.GetMovie(MovieTitleText.Text).Count == 0)
            {
                var grid = MoviesGridView;
                var btn = (Button)sender;
                var columnNames = new List<string>();
                var values = new List<string>();
                // Check if any row is selected
                if (grid.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow row = grid.SelectedRows[0];
                    // Get the values of the row
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //check if cell value is null
                        if (cell.Value != null)
                        {
                            // Add the column name and value to the lists
                            columnNames.Add(cell.OwningColumn.Name);
                            //Put value in single quotes

                            values.Add("\'" + cell.Value.ToString() + "\'");
                        }
                        //Else add null to the lists
                        else
                        {
                            columnNames.Add(cell.OwningColumn.Name);
                            values.Add("null");
                        }

                    }
                    //Check if radio button subbed or dubbed is checked and add dubbed column
                    if (DubbedRadio.Checked == true)
                    {
                        //Add true to the value of last cell
                        values[values.Count - 1] = "1";
                        MovieManager.AddMovie(columnNames, values);
                        MessageBox.Show("Movie added to database");
                    }
                    else if (SubbedRadio.Checked == true)
                    {
                        values[values.Count - 1] = "1";
                        // Add the values to the database
                        MovieManager.AddMovie(columnNames, values);
                        MessageBox.Show("Movie added to database");
                    }
                    else
                    {
                        MessageBox.Show("Please select a language");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a movie");
                }


            }
            else
            {
                MessageBox.Show("Movie already in database");
            }


        }
        private void MoviesGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Rows[e.RowIndex].Cells[13].Value.ToString() != "N/A")
            {
                MoviePoster.Load(grid.Rows[e.RowIndex].Cells[13].Value.ToString());
            }
            else
            {
                //set default poster
                MoviePoster.Load("C:\\Users\\mohje\\source\\repos\\CinemaManager\\src\\posters\\default-poster.jpg");

            }
            foreach (TextBox tb in MovieDetailsGroup.Controls.OfType<TextBox>().OrderBy(c => int.Parse((string)c.Tag)))
            {
                tb.Text = grid.Rows[e.RowIndex].Cells[int.Parse((string)tb.Tag) - 1].Value.ToString();
            }
            MoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void DisplayAllMoviesBtn_Click(object sender, EventArgs e)
        {
            List<Movie> movies = MovieManager.GetMoviesDatabase();
            MoviesGridView.DataSource = movies;
        }
        private void UpdateMoviesList()
        {
            List<Movie> movieList = MovieManager.GetMoviesDatabase();
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
            string createMoviesTable = "CREATE TABLE IF NOT EXISTS movies (id INTEGER PRIMARY KEY AUTOINCREMENT, title TEXT, year TEXT, rated TEXT, released TEXT, runtime TEXT, genre TEXT, director TEXT, writer TEXT, actors TEXT, plot TEXT, language TEXT, country TEXT, awards TEXT, poster TEXT, metascore TEXT, imdbRating TEXT, imdbVotes TEXT, imdbID TEXT, type TEXT, dvd TEXT, boxOffice TEXT, production TEXT, website TEXT, dubbed INTEGER)";
            Database.Initialize();
            Database.ExecuteQuery(createMoviesTable);
            Database.Close();
        }


    }
}
