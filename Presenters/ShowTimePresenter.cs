//using CinemaManager.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CinemaManager.Presenters
//{
//    internal class ShowTimePresenter
//    {
//        private IShowTimeView view;
//        private IShowTimeModel model;

//        public ShowTimePresenter(IShowTimeView view, IShowTimeModel model)
//        {
//            this.view = view;
//            this.model = model;

//            view.SelectSeat += OnSelectSeat;
//            view.PurchaseTicket += OnPurchaseTicket;
//        }

//        public void LoadShowTimes(string theaterName, string movieTitle)
//        {
//            // Retrieve show times from the model
//            List<ShowTime> showTimes = model.GetShowTimes(theaterName, movieTitle);

//            // Display the show times to the user
//            view.DisplayShowTimes(showTimes);
//        }

//        private void OnSelectSeat(object sender, SeatSelectedEventArgs e)
//        {
//            // Handle the seat selection event
//            // Update the model and the view as needed
//        }

//        private void OnPurchaseTicket(object sender, TicketPurchasedEventArgs e)
//        {
//            // Handle the ticket purchase event
//            // Update the model and the view as needed
//        }
//    }
//}
