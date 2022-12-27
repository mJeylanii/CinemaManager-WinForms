using CinemaManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Data.SQLite;
namespace CinemaManager.Forms
{
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }



        private async Task<MovieSearchResult> GetMoviesAsync(string title, string date)
        {
            string key = "cbedc33";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"http://www.omdbapi.com/");
            string resourceUri = $"?apikey={key}&s={title}&type=movie&plot=short";

            HttpResponseMessage response = await client.GetAsync(resourceUri);
            try
            {
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                MovieSearchResult movies = JsonConvert.DeserializeObject<MovieSearchResult>(responseBody);
                if (movies.Response == "True")
                {
                    return movies;
                }
                else
                {
                    return null;
                }
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {

            var movie = await GetMoviesAsync(MoveTitle.Text, YearText.Text == "" ? "0" : YearText.Text);    
            if(movie == null)
            {
                MessageBox.Show("No movies found");

            }else{
               MoviesGridView.DataSource = movie.Search;
            }

            
        }

        private void MoviesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MoviesGridView.Rows[e.RowIndex].Cells[4].Value.ToString() != "N/A")
            {

                MoviePoster.Load(MoviesGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                MoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
                MoviePoster.Image = null;
        }    
        
    }
}
