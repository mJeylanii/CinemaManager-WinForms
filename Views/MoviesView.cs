using CinemaManager.Models;
using CinemaManager.Presenters;
using CinemaManager.Utilities;
using CinemaManager.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CinemaManager.Forms
{
    public partial class MoviesView : Form, IMoviesView
    {
        //Create a new instance of the movie presenter
        private readonly MoviePresenter _moviePresenter;
        //Properties
        public string MovieTitle { get { return MovieTitleText.Text; } }//Movie title
        public string MovieId { get { return MovieIdText.Text; } }   //Movie IMdb id   
        public string MovieYear { get { return MovieYearText.Text; } } //Movie year
           //Online database radio button checked
        public bool OnlineDatabaseChecked => OnlineDatabaseRadio.Checked;
        //Local database radio button checked
        public bool LocalDatabaseChecked => LocalDatabaseRadio.Checked;
        



        //Event handlers
        public event EventHandler SearchMovieClicked;
        public event EventHandler<Tuple<List<string>, List<string>>> AddMovieClicked;
        public event EventHandler<string> DeleteMovieClicked;
        public event EventHandler UpdateMovieClicked;
        public event EventHandler SetShowTimeClicked;

        public MoviesView()
        {
            InitializeComponent();
            //Presenter
            _moviePresenter = new MoviePresenter(this);
            //Event handlers
            SearchMovieButton.Click += SearchMovieButtonClicked;
            AddMovieButton.Click += AddMovieButtonClicked;
            DeleteMovieButton.Click += DeleteMovieButtonClicked;
            SetShowTimeButton.Click += SetShowTimeButtonClicked;

        }
        //Implement event handlers
        public void SearchMovieButtonClicked(object sender, EventArgs e)
        {
            //Search for movie
            //Enable the disabled text fields
            MovieTitleText.Enabled = true;
            MovieIdText.Enabled = true;
          
            //Get the search results
            //Invoke the event handler
            SearchMovieClicked?.Invoke(this, e);
            //Get the search results
            //Bind the search results to the datagridview
            //MoviesDataGridView.DataSource = ;
        }

        public void AddMovieButtonClicked(object sender, EventArgs e)
        {
            var grid = MoviesDataGridView;
            List<string> columns = new List<string>();
            List<string> values = new List<string>();
            //Check if row is selected
            if (grid.SelectedRows.Count > 0)
            {
                //Check if subbed or dubbed radio button is checked
                if (SubbedRadioButton.Checked)
                {
                    //Add the subbed value to last column
                    grid.SelectedRows[0].Cells[grid.Columns.Count - 1].Value = "Subbed";
                    //Get the selected row
                    DataGridViewRow row = grid.SelectedRows[0];
                    foreach (DataGridViewColumn column in grid.Columns)
                    {
                        columns.Add(column.Name);
                        values.Add("'" + grid.SelectedRows[0].Cells[column.Name].Value.ToString() + "'");
                    }
                    //Get the selected row
                    var movie = Tuple.Create(columns, values);
                    //Invoke the event handler
                    AddMovieClicked?.Invoke(this, movie);
                }
                else if (DubbedRadioButton.Checked)
                {
                    //Add the dubbed value to last column
                    grid.SelectedRows[0].Cells[grid.Columns.Count - 1].Value = "Dubbed";
                    //Get the selected row
                    DataGridViewRow row = grid.SelectedRows[0];
                    foreach (DataGridViewColumn column in grid.Columns)
                    {
                        columns.Add(column.Name);
                        values.Add("'" + grid.SelectedRows[0].Cells[column.Name].Value.ToString() + "'" );
                    }
                    //Get the selected row
                    var movie = Tuple.Create(columns, values);
                    //Invoke the event handler
                    AddMovieClicked?.Invoke(this, movie);
                }
                else
                {
                    //Show error message
                    MessageBox.Show("Please select a language");
                }
            }
            else
            {
                DialogMessages.ErrorMessage("Please select a movie to add");
            }

        }
        public void DeleteMovieButtonClicked(object sender, EventArgs e)
        {

            var grid = MoviesDataGridView;
            //Get the title of the movie from grid
            var title = grid.CurrentRow.Cells[0].Value.ToString();
            //Invoke method in presenter
            DeleteMovieClicked?.Invoke(this, title);
            UpdateMoviesList();
        }
        public void UpdateMovieButtonClicked(object sender, EventArgs e)
        {
            //Update movie in database
            //Invoke the presenter
            _moviePresenter.UpdateMovie();
        }
        public void SetShowTimeButtonClicked(object sender, EventArgs e)
        {
            //set show time
            //Invoke the presenter
            _moviePresenter.SetShowTime();
        }
        private async void SearchButton_Click(object sender, EventArgs e)
        {

        }
        private void AddToDatabaseBtn_Click(object sender, EventArgs e)
        {

            //Check if movie exists in database first check count

            if (MovieManager.GetMovie(MovieTitleText.Text).Count > 0)
            {
                //Declare Columns and values by looping through grid
                string columns = "";
                string values = "";
                for (int i = 0; i < MoviesDataGridView.Columns.Count; i++)
                {
                    columns += MoviesDataGridView.Columns[i].Name + ",";
                    values += "'" + MoviesDataGridView.Rows[0].Cells[i].Value + "',";
                }

                MessageBox.Show("Movie already exists in database");
            }
            else
            {
                //Get columns and rows
                MessageBox.Show("Movie added to database");
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
            //List<Movie> movies = MovieManager.GetMoviesDatabase();
            //MoviesDataGridView.DataSource = movies;
        }
        private void UpdateMoviesList()
        {
            //List<Movie> movieList = MovieManager.GetMoviesDatabase();
            //MoviesDataGridView.DataSource = movieList;
        }
        private void DeleteMovieBtn_Click(object sender, EventArgs e)
        {
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
            //User confirmation
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the database?", "Clear Database", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Clear database
                Database.Initialize();
                Database.ExecuteQuery("DROP TABLE movies");
                Database.Close();
                UpdateMoviesList();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Do nothing
            }

        }

        private void CreateMovieTableButton_Click(object sender, EventArgs e)
        {
            string createMoviesTable = "CREATE TABLE IF NOT EXISTS movies (id INTEGER PRIMARY KEY AUTOINCREMENT, title TEXT, year TEXT, rated TEXT, released TEXT, runtime TEXT, genre TEXT, director TEXT, writer TEXT, actors TEXT, plot TEXT, language TEXT, country TEXT, awards TEXT, poster TEXT, metascore TEXT, imdbRating TEXT, imdbVotes TEXT, imdbID TEXT, type TEXT, dvd TEXT, boxOffice TEXT, production TEXT, website TEXT, dubbed TEXT)";
            Database.Initialize();
            Database.ExecuteQuery(createMoviesTable);
            Database.Close();
        }

        //implement Showmovies method
        //public void ShowMovies(List<Movie> movies)
        //{
        //    MoviesGridView.DataSource = movies;
        //}
        //Implement yes or no confirmation message

      

        void IMoviesView.ShowMovies(List<Movie> movies)
        {
            MoviesDataGridView.DataSource = movies;
            MoviesDataGridView.Refresh();
        }

     
    }
}

