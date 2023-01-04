using CinemaManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Views
{
    public interface  IMovieView
    {

        string MovieTitleText { get; }
        string MovieIdText { get; }
        string YearText { get; }
        bool OnlineDatabaseRadioChecked { get; }
        bool LocalDatabaseRadioChecked { get; }
        List<string> Columns { get; set; }
        List<string> Values { get; set; }
        void ShowMovies(List<Movie> movies);
        void ShowError(string message);
        event EventHandler SearchMovie;
        event EventHandler AddMovie;
    }
}
