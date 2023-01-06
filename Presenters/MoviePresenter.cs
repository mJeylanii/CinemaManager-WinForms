using CinemaManager.Models;
using CinemaManager.Views;
using System;
using System.Collections.Generic;

namespace CinemaManager.Presenters
{
    internal class MoviePresenter
    {
        private readonly IMoviesView _view;
        //Constructor
        public MoviePresenter(IMoviesView view)
        {
            
            _view = view;
            //<Summary>
            //Binding event handlers to the methods
            //</Summary>
            _view.DeleteMovieClicked += (s, e) => DeleteMovie(e);
            _view.SearchMovieClicked += (s, e) => SearchMovie();
            _view.AddMovieClicked += (s, movie) => AddMovie(movie);
            _view.GetAllMovies += (s, e) => GetAllMovies();
        }

        private void GetAllMovies()
        {
            var movies = MovieManager.GetAllMoviesLocal();
            _view.ShowMovies(movies);
        }

        //Make a searchmovie method that returns a list of movies using method found in MovieManager
        public async void SearchMovie()
        {
            //Check if user wants to search locally or online
            if (_view.LocalDatabaseChecked)
            {
                //Search locally
                //Get the search results
                List<Movie> movies = MovieManager.GetAllMoviesLocal();
                //Bind the search results to the datagridview
                _view.ShowMovies(movies);
            }
            else if (_view.OnlineDatabaseChecked)
            {
                //Search online
                //Get the search results
                Movie movie = await MovieManager.GetMoviesApiAsync(_view.MovieTitle, _view.MovieId, _view.MovieYear);
                List<Movie> movies = new List<Movie> { movie };
                //Bind the search results to the datagridview
                _view.ShowMovies(movies);
            }
        }

        public void AddMovie(Tuple<List<string>, List<string>> movie)
        {
            //Check if movie exist using the GetMovie method in MovieManager
            List<Movie> movieList = MovieManager.GetMovie(_view.MovieTitle);
            if (MovieManager.GetMovie(_view.MovieTitle).Count <= 0)
            {
                try
                {
                    MovieManager.AddMovie(movie.Item1, movie.Item2);
                    DialogMessages.SuccessMessage("Movie added successfully");
                }
                catch (Exception ex)
                {
                    DialogMessages.ErrorMessage(ex.Message);

                }
            }
            else
            {
                DialogMessages.ErrorMessage("Movie already exists in Database");
            }
            // Add movie to database
          
        }


        //Delete movie from database
        public void DeleteMovie(string title)
        {
            MovieManager.DeleteMovie(title);
            DialogMessages.SuccessMessage("Movie deleted successfully");      
        }
        //Update movie in database
        public void UpdateMovie()
        {
            //Update movie in database
        }
        //set show time
        public void SetShowTime()
        {
            //set show time
        }
    }
}



