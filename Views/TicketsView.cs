using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManager.Forms;

namespace CinemaManager.Forms
{
    public partial class TicketsForm : BaseForm
    {
        public TicketsForm()
        {
            InitializeComponent();
        }
        //<summary>
           /// This method is called when the user clicks the "Add" button.
         //</summary>
        //display tickets
        //private void TicketsForm_Load(object sender, EventArgs e)
        //{
        //    TicketsGridView.DataSource = TicketManager.GetTickets();
        //    TicketsGridView.Refresh();
        //}

        //add ticket
        //private void AddTicketButton_Click(object sender, EventArgs e)
        //{
        //    TicketManager.AddTicket(TicketIdText.Text, MovieTitleText.Text, MovieIdText.Text, MovieDateText.Text, MovieTimeText.Text, MovieHallText.Text, MovieSeatText.Text, MoviePriceText.Text);
        //    TicketsGridView.DataSource = TicketManager.GetTickets();
        //    TicketsGridView.Refresh();
        //}

        //delete ticket
        //private void DeleteTicketButton_Click(object sender, EventArgs e)

        //update ticket 
        //private void UpdateTicketButton_Click(object sender, EventArgs e)

        //search ticket
        //private void SearchTicketButton_Click(object sender, EventArgs e)
    }
}
