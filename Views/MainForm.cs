using CinemaManager.Utilities;
using System;
using System.Windows.Forms;

namespace CinemaManager.Forms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Database.Initialize();
            Database.CreateDatabase("Database", "cinema.db");



            //TabPage ticketsTabPage = TabControl.TabPages[2];
            //ticketsTabPage.Controls.Add(ticketsForm);
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    // Create an instance of the movie form
                    MovieView movieForm = new MovieView();
                    movieForm.TopLevel = false;
                    //movieForm.FormBorderStyle = FormBorderStyle.None;

                    // Add the movie form to the tab page
                    TabPage movieTabPage = TabControl.TabPages[1];
                    movieTabPage.Controls.Add(movieForm);
                    // Show the movie form
                    movieForm.Show();
                    break;
                case 2:
                    //Do the same for TicketsForm
                    TicketsView ticketsForm = new TicketsView();
                    ticketsForm.TopLevel = false;
                    TabPage ticketsTabPage = TabControl.TabPages[2];
                    ticketsTabPage.Controls.Add(ticketsForm);
                    ticketsForm.Show();
                    break;
            }

        }
    }
}
