using CinemaManager.Forms;
using CinemaManager.Models;
using CinemaManager.Utilities;
using CinemaManager.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManager.Presenters
{
    internal class MoviePresenter
    {
        private readonly IMovieView _view;
        public MovieManager(MovieView view)
        {
            _view = view;
            _view.SearchMovie += OnSearchMovie;
            _view.AddMovie += OnAddMovie;
            //_view.DeleteMovie += OnDeleteMovie;
            //_view.UpdateMovie += OnUpdateMovie;
            //_view.LoadMovies += OnLoadMovies;
        }
        public async Task<List<Movie>> SearchMovie(string title, string id, string year)
        {
            /* Check if user wants to search online */
            if (this._view.OnlineDatabaseRadioChecked == true)
            {
                var movie = await MovieManager.GetMoviesOnlineAsync(title, id, year);
                if (movie == null)
                {
                    return new List<Movie>();
                }
                else
                {
                    return new List<Movie> { movie };
                }
            }
            /* Check if user wants to search locally */
            else if (this._view.LocalDatabaseRadioChecked == true)
            {
                return MovieManager.GetMovie(title);
            }
            else
            {
                return new List<Movie>();
            }
        }
        //Method to get all movies in database
        public List<Movie> GetMovies()
        {
            return MovieManager.GetMoviesDatabase();
        }
        //Method to add movie to database by recieving a movie object
        public void AddMovie(_view.MovieTitleText)
        {

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
                    if (_view.DubbedRadio.Checked == true)
                    {
                        //Add true to the value of last cell
                        values[values.Count - 1] = "1";
                        MovieManager.AddMovie(columnNames, values);
                        MessageBox.Show("Movie added to database");
                    }
                    else if (_view.SubbedRadio.Checked == true)
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

    }

}

