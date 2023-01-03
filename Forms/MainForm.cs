using CinemaManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            MovieForm movieForm = new MovieForm();
            movieForm.TopLevel = false;
            //movieForm.FormBorderStyle = FormBorderStyle.None;

            // Add the movie form to the tab page
            TabPage movieTabPage = TabControl.TabPages[1];
            movieTabPage.Controls.Add(movieForm);
            // Show the movie form
            movieForm.Show();
        }
    }
}
