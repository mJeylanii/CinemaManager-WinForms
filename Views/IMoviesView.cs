using CinemaManager.Models;
using System;
using System.Collections.Generic;

namespace CinemaManager.Views
{
    internal interface IMoviesView
    {
        string MovieTitle { get; }
        string MovieYear { get; }
        string MovieId { get; }
        //LocalDatabaseRadio checked
        bool LocalDatabaseChecked { get; }
        //OnlineDatabaseRadio checked
        bool OnlineDatabaseChecked { get; }

        void ShowMovies(List<Movie> movies);
        //Event handlers clicked
        event EventHandler SearchMovieClicked;
        event EventHandler<Tuple<List<string>, List<string>>> AddMovieClicked;
        event EventHandler<string> DeleteMovieClicked;
        event EventHandler UpdateMovieClicked;
        event EventHandler SetShowTimeClicked;
        event EventHandler GetAllMovies;

    }
}
