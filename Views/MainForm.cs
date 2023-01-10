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
            // Create an instance of the movie form
            MoviesView movieForm = new MoviesView();
            movieForm.TopLevel = false;
            movieForm.Dock = DockStyle.Fill;
            //movieForm.FormBorderStyle = FormBorderStyle.None;

            // Add the movie form to the tab page
            TabPage movieTabPage = TabControl.TabPages[1];
            movieTabPage.Controls.Add(movieForm);
            // Show the movie form
            movieForm.Show();
        }
    }
}
