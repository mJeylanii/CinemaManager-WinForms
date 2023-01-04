using System.Collections.Generic;

namespace CinemaManager.Models
{
    internal class Theater
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Movie> CurrentlyShowing { get; set; }

        public Theater(string name, string address)
        {
            Name = name;
            Address = address;
            CurrentlyShowing = new List<Movie>();
        }

        public void AddMovie(Movie movie)
        {
            CurrentlyShowing.Add(movie);
        }

        public void RemoveMovie(Movie movie)
        {
            CurrentlyShowing.Remove(movie);
        }
    }
}
