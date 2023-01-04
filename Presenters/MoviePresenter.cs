using CinemaManager.Models;
using CinemaManager.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CinemaManager.Presenters
{
    internal class MoviePresenter
    {
        private readonly IMoviesView _view;
        //Constructor
        public MoviePresenter(IMoviesView view)
        {
            _view = view;
            _view.DeleteMovieClicked += (s, e) => DeleteMovie(e);
            _view.SearchMovieClicked += (s, e) => SearchMovie();
            _view.AddMovieClicked += (s, movie) => AddMovie(movie);
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
                Movie movie  = await MovieManager.GetMoviesApiAsync(_view.MovieTitle, _view.MovieId, _view.MovieYear);
                List<Movie> movies = new List<Movie> { movie };
                //Bind the search results to the datagridview
                _view.ShowMovies(movies);
            }  
        }

        public void AddMovie(Tuple<List<string>, List<string>> movie)
        {
            // Add movie to database
            MovieManager.AddMovie(movie.Item1, movie.Item2);
        }


        //Delete movie from database
        public void DeleteMovie(string title)
        {
            MovieManager.DeleteMovie(title);
            //Delete movie from database
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
