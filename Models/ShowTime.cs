using System;

namespace CinemaManager.Models
{
    internal class ShowTime
    {
        public string TheaterName { get; set; }
        public string MovieTitle { get; set; }
        public DateTime StartTime { get; set; }
        public int AvailableSeats { get; set; }
        public decimal TicketPrice { get; set; }
        private bool[] seats;
        public ShowTime(string theaterName, string movieTitle, DateTime startTime, int availableSeats, decimal ticketPrice)
        {
            TheaterName = theaterName;
            MovieTitle = movieTitle;
            StartTime = startTime;
            AvailableSeats = availableSeats;
            TicketPrice = ticketPrice;
        }
        public ShowTime(int numberOfSeats)
        {
            seats = new bool[numberOfSeats];
        }

        public void SelectSeat(int seatNumber)
        {
            if (seatNumber < 0 || seatNumber >= seats.Length)
            {
                throw new ArgumentOutOfRangeException("Seat number is out of range.");
            }

            if (seats[seatNumber])
            {
                throw new InvalidOperationException("Seat is already selected.");
            }

            seats[seatNumber] = true;
        }
    }
}
