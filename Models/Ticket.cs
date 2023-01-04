namespace CinemaManager.Models
{
    internal class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MovieTitle { get; set; }
        public string MovieDate { get; set; }
        public string MovieTime { get; set; }
        public string MovieHall { get; set; }
        public string Seat { get; set; }
        public string Price { get; set; }
        public string Date { get; set; }
        public ShowTime ShowTime { get; set; }

    }
}
