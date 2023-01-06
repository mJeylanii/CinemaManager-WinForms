namespace CinemaManager.Forms
{
    partial class MoviesView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.MovieDetailsBox = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SetShowTimeButton = new System.Windows.Forms.Button();
            this.CreateMovieTableButton = new System.Windows.Forms.Button();
            this.ClearDatabaseButton = new System.Windows.Forms.Button();
            this.DeleteMovieButton = new System.Windows.Forms.Button();
            this.DubbedRadioButton = new System.Windows.Forms.RadioButton();
            this.SubbedRadioButton = new System.Windows.Forms.RadioButton();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.MovieDetailsGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imdbID = new System.Windows.Forms.TextBox();
            this.BoxOfficelbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.IMDbRatingDetailsTxt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.MetascoreDetailsTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.AwardsDetailsTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CountryDetailsTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.LanguageDetailsTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ActorsDetailsTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WriteDetailsTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DirectorDetailsTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GenreDetailsTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RuntimeDetailsTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ReleasedDetailsTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PlotDetailsTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TitleDetailsTxt = new System.Windows.Forms.TextBox();
            this.TypeDetailsTxt = new System.Windows.Forms.TextBox();
            this.YearDetailstxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MoviesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.MovieIdText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetAllMoviesButton = new System.Windows.Forms.Button();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.LocalDatabaseRadio = new System.Windows.Forms.RadioButton();
            this.OnlineDatabaseRadio = new System.Windows.Forms.RadioButton();
            this.SearchMovieButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MovieYearText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTitlelbl = new System.Windows.Forms.Label();
            this.MovieTitleText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.MovieDetailsBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.MovieDetailsGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviePoster
            // 
            this.MoviePoster.Dock = System.Windows.Forms.DockStyle.Left;
            this.MoviePoster.Location = new System.Drawing.Point(3, 22);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(410, 675);
            this.MoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePoster.TabIndex = 0;
            this.MoviePoster.TabStop = false;
            // 
            // MovieDetailsBox
            // 
            this.MovieDetailsBox.AutoSize = true;
            this.MovieDetailsBox.Controls.Add(this.groupBox5);
            this.MovieDetailsBox.Controls.Add(this.MovieDetailsGroup);
            this.MovieDetailsBox.Controls.Add(this.MoviePoster);
            this.MovieDetailsBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MovieDetailsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MovieDetailsBox.Location = new System.Drawing.Point(0, 380);
            this.MovieDetailsBox.MinimumSize = new System.Drawing.Size(0, 700);
            this.MovieDetailsBox.Name = "MovieDetailsBox";
            this.MovieDetailsBox.Size = new System.Drawing.Size(1920, 700);
            this.MovieDetailsBox.TabIndex = 1;
            this.MovieDetailsBox.TabStop = false;
            this.MovieDetailsBox.Text = "Selected Movie";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SetShowTimeButton);
            this.groupBox5.Controls.Add(this.CreateMovieTableButton);
            this.groupBox5.Controls.Add(this.ClearDatabaseButton);
            this.groupBox5.Controls.Add(this.DeleteMovieButton);
            this.groupBox5.Controls.Add(this.DubbedRadioButton);
            this.groupBox5.Controls.Add(this.SubbedRadioButton);
            this.groupBox5.Controls.Add(this.AddMovieButton);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(1563, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(354, 675);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Options";
            // 
            // SetShowTimeButton
            // 
            this.SetShowTimeButton.Location = new System.Drawing.Point(39, 422);
            this.SetShowTimeButton.Name = "SetShowTimeButton";
            this.SetShowTimeButton.Size = new System.Drawing.Size(236, 50);
            this.SetShowTimeButton.TabIndex = 6;
            this.SetShowTimeButton.Text = "Set Show Time";
            this.SetShowTimeButton.UseVisualStyleBackColor = true;
            // 
            // CreateMovieTableButton
            // 
            this.CreateMovieTableButton.Location = new System.Drawing.Point(39, 353);
            this.CreateMovieTableButton.Name = "CreateMovieTableButton";
            this.CreateMovieTableButton.Size = new System.Drawing.Size(236, 50);
            this.CreateMovieTableButton.TabIndex = 5;
            this.CreateMovieTableButton.Text = "Create Table Movies";
            this.CreateMovieTableButton.UseVisualStyleBackColor = true;
            this.CreateMovieTableButton.Click += new System.EventHandler(this.CreateMovieTableButton_Click);
            // 
            // ClearDatabaseButton
            // 
            this.ClearDatabaseButton.Location = new System.Drawing.Point(39, 283);
            this.ClearDatabaseButton.Name = "ClearDatabaseButton";
            this.ClearDatabaseButton.Size = new System.Drawing.Size(236, 50);
            this.ClearDatabaseButton.TabIndex = 4;
            this.ClearDatabaseButton.Text = "Clear Database";
            this.ClearDatabaseButton.UseVisualStyleBackColor = true;
            this.ClearDatabaseButton.Click += new System.EventHandler(this.ClearDatabaseButton_Click);
            // 
            // DeleteMovieButton
            // 
            this.DeleteMovieButton.Location = new System.Drawing.Point(39, 215);
            this.DeleteMovieButton.Name = "DeleteMovieButton";
            this.DeleteMovieButton.Size = new System.Drawing.Size(236, 46);
            this.DeleteMovieButton.TabIndex = 3;
            this.DeleteMovieButton.Text = "Remove from Database";
            this.DeleteMovieButton.UseVisualStyleBackColor = true;
         
            // 
            // DubbedRadioButton
            // 
            this.DubbedRadioButton.AutoSize = true;
            this.DubbedRadioButton.Location = new System.Drawing.Point(169, 101);
            this.DubbedRadioButton.Name = "DubbedRadioButton";
            this.DubbedRadioButton.Size = new System.Drawing.Size(84, 24);
            this.DubbedRadioButton.TabIndex = 2;
            this.DubbedRadioButton.TabStop = true;
            this.DubbedRadioButton.Text = "Dubbed";
            this.DubbedRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubbedRadioButton
            // 
            this.SubbedRadioButton.AutoSize = true;
            this.SubbedRadioButton.Location = new System.Drawing.Point(54, 101);
            this.SubbedRadioButton.Name = "SubbedRadioButton";
            this.SubbedRadioButton.Size = new System.Drawing.Size(83, 24);
            this.SubbedRadioButton.TabIndex = 1;
            this.SubbedRadioButton.TabStop = true;
            this.SubbedRadioButton.Text = "Subbed";
            this.SubbedRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Location = new System.Drawing.Point(39, 145);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(236, 46);
            this.AddMovieButton.TabIndex = 0;
            this.AddMovieButton.Text = "Add To Database";
            this.AddMovieButton.UseVisualStyleBackColor = true;
            // 
            // MovieDetailsGroup
            // 
            this.MovieDetailsGroup.AutoSize = true;
            this.MovieDetailsGroup.Controls.Add(this.label4);
            this.MovieDetailsGroup.Controls.Add(this.imdbID);
            this.MovieDetailsGroup.Controls.Add(this.BoxOfficelbl);
            this.MovieDetailsGroup.Controls.Add(this.textBox1);
            this.MovieDetailsGroup.Controls.Add(this.label20);
            this.MovieDetailsGroup.Controls.Add(this.textBox2);
            this.MovieDetailsGroup.Controls.Add(this.label19);
            this.MovieDetailsGroup.Controls.Add(this.IMDbRatingDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.label18);
            this.MovieDetailsGroup.Controls.Add(this.MetascoreDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.label17);
            this.MovieDetailsGroup.Controls.Add(this.AwardsDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.label16);
            this.MovieDetailsGroup.Controls.Add(this.CountryDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.label15);
            this.MovieDetailsGroup.Controls.Add(this.LanguageDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.label14);
            this.MovieDetailsGroup.Controls.Add(this.ActorsDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.label13);
            this.MovieDetailsGroup.Controls.Add(this.WriteDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.label12);
            this.MovieDetailsGroup.Controls.Add(this.DirectorDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.label11);
            this.MovieDetailsGroup.Controls.Add(this.GenreDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.label10);
            this.MovieDetailsGroup.Controls.Add(this.RuntimeDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.label9);
            this.MovieDetailsGroup.Controls.Add(this.ReleasedDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.label8);
            this.MovieDetailsGroup.Controls.Add(this.PlotDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.label7);
            this.MovieDetailsGroup.Controls.Add(this.label6);
            this.MovieDetailsGroup.Controls.Add(this.label5);
            this.MovieDetailsGroup.Controls.Add(this.TitleDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.TypeDetailsTxt);
            this.MovieDetailsGroup.Controls.Add(this.YearDetailstxt);
            this.MovieDetailsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MovieDetailsGroup.Location = new System.Drawing.Point(443, 16);
            this.MovieDetailsGroup.Name = "MovieDetailsGroup";
            this.MovieDetailsGroup.Size = new System.Drawing.Size(1079, 580);
            this.MovieDetailsGroup.TabIndex = 4;
            this.MovieDetailsGroup.TabStop = false;
            this.MovieDetailsGroup.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "IMDb ID:";
            // 
            // imdbID
            // 
            this.imdbID.Enabled = false;
            this.imdbID.Location = new System.Drawing.Point(513, 277);
            this.imdbID.Name = "imdbID";
            this.imdbID.Size = new System.Drawing.Size(138, 26);
            this.imdbID.TabIndex = 35;
            this.imdbID.Tag = "18";
            // 
            // BoxOfficelbl
            // 
            this.BoxOfficelbl.AutoSize = true;
            this.BoxOfficelbl.Location = new System.Drawing.Point(397, 313);
            this.BoxOfficelbl.Name = "BoxOfficelbl";
            this.BoxOfficelbl.Size = new System.Drawing.Size(86, 20);
            this.BoxOfficelbl.TabIndex = 34;
            this.BoxOfficelbl.Text = "Box Office:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(513, 307);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 26);
            this.textBox1.TabIndex = 33;
            this.textBox1.Tag = "21";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(395, 251);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 20);
            this.label20.TabIndex = 32;
            this.label20.Text = "IMDb Votes:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(513, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 26);
            this.textBox2.TabIndex = 31;
            this.textBox2.Tag = "17";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(395, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 20);
            this.label19.TabIndex = 30;
            this.label19.Text = "IMDb Rating:";
            // 
            // IMDbRatingDetailsTxt
            // 
            this.IMDbRatingDetailsTxt.Enabled = false;
            this.IMDbRatingDetailsTxt.Location = new System.Drawing.Point(513, 213);
            this.IMDbRatingDetailsTxt.Name = "IMDbRatingDetailsTxt";
            this.IMDbRatingDetailsTxt.Size = new System.Drawing.Size(50, 26);
            this.IMDbRatingDetailsTxt.TabIndex = 29;
            this.IMDbRatingDetailsTxt.Tag = "16";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(395, 184);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 20);
            this.label18.TabIndex = 28;
            this.label18.Text = "Metascore:";
            // 
            // MetascoreDetailsTxt
            // 
            this.MetascoreDetailsTxt.Enabled = false;
            this.MetascoreDetailsTxt.Location = new System.Drawing.Point(513, 181);
            this.MetascoreDetailsTxt.Name = "MetascoreDetailsTxt";
            this.MetascoreDetailsTxt.Size = new System.Drawing.Size(50, 26);
            this.MetascoreDetailsTxt.TabIndex = 27;
            this.MetascoreDetailsTxt.Tag = "15";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(395, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "Awards:";
            // 
            // AwardsDetailsTxt
            // 
            this.AwardsDetailsTxt.Enabled = false;
            this.AwardsDetailsTxt.Location = new System.Drawing.Point(513, 149);
            this.AwardsDetailsTxt.Multiline = true;
            this.AwardsDetailsTxt.Name = "AwardsDetailsTxt";
            this.AwardsDetailsTxt.Size = new System.Drawing.Size(299, 26);
            this.AwardsDetailsTxt.TabIndex = 25;
            this.AwardsDetailsTxt.Tag = "13";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(395, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 24;
            this.label16.Text = "Country:";
            // 
            // CountryDetailsTxt
            // 
            this.CountryDetailsTxt.Enabled = false;
            this.CountryDetailsTxt.Location = new System.Drawing.Point(513, 117);
            this.CountryDetailsTxt.Name = "CountryDetailsTxt";
            this.CountryDetailsTxt.Size = new System.Drawing.Size(299, 26);
            this.CountryDetailsTxt.TabIndex = 23;
            this.CountryDetailsTxt.Tag = "12";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(395, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Language:";
            // 
            // LanguageDetailsTxt
            // 
            this.LanguageDetailsTxt.Enabled = false;
            this.LanguageDetailsTxt.Location = new System.Drawing.Point(513, 85);
            this.LanguageDetailsTxt.Name = "LanguageDetailsTxt";
            this.LanguageDetailsTxt.Size = new System.Drawing.Size(299, 26);
            this.LanguageDetailsTxt.TabIndex = 10;
            this.LanguageDetailsTxt.Tag = "11";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(395, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Actors:";
            // 
            // ActorsDetailsTxt
            // 
            this.ActorsDetailsTxt.Enabled = false;
            this.ActorsDetailsTxt.Location = new System.Drawing.Point(513, 53);
            this.ActorsDetailsTxt.Multiline = true;
            this.ActorsDetailsTxt.Name = "ActorsDetailsTxt";
            this.ActorsDetailsTxt.Size = new System.Drawing.Size(299, 26);
            this.ActorsDetailsTxt.TabIndex = 9;
            this.ActorsDetailsTxt.Tag = "9";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Writer:";
            // 
            // WriteDetailsTxt
            // 
            this.WriteDetailsTxt.Enabled = false;
            this.WriteDetailsTxt.Location = new System.Drawing.Point(96, 307);
            this.WriteDetailsTxt.Multiline = true;
            this.WriteDetailsTxt.Name = "WriteDetailsTxt";
            this.WriteDetailsTxt.Size = new System.Drawing.Size(209, 48);
            this.WriteDetailsTxt.TabIndex = 8;
            this.WriteDetailsTxt.Tag = "8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Director:";
            // 
            // DirectorDetailsTxt
            // 
            this.DirectorDetailsTxt.Enabled = false;
            this.DirectorDetailsTxt.Location = new System.Drawing.Point(96, 253);
            this.DirectorDetailsTxt.Multiline = true;
            this.DirectorDetailsTxt.Name = "DirectorDetailsTxt";
            this.DirectorDetailsTxt.Size = new System.Drawing.Size(248, 48);
            this.DirectorDetailsTxt.TabIndex = 7;
            this.DirectorDetailsTxt.Tag = "7";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Genre:";
            // 
            // GenreDetailsTxt
            // 
            this.GenreDetailsTxt.Enabled = false;
            this.GenreDetailsTxt.Location = new System.Drawing.Point(96, 218);
            this.GenreDetailsTxt.Multiline = true;
            this.GenreDetailsTxt.Name = "GenreDetailsTxt";
            this.GenreDetailsTxt.Size = new System.Drawing.Size(214, 29);
            this.GenreDetailsTxt.TabIndex = 6;
            this.GenreDetailsTxt.Tag = "6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Runtime:";
            // 
            // RuntimeDetailsTxt
            // 
            this.RuntimeDetailsTxt.Enabled = false;
            this.RuntimeDetailsTxt.Location = new System.Drawing.Point(96, 186);
            this.RuntimeDetailsTxt.Name = "RuntimeDetailsTxt";
            this.RuntimeDetailsTxt.Size = new System.Drawing.Size(214, 26);
            this.RuntimeDetailsTxt.TabIndex = 5;
            this.RuntimeDetailsTxt.Tag = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Released:";
            // 
            // ReleasedDetailsTxt
            // 
            this.ReleasedDetailsTxt.Enabled = false;
            this.ReleasedDetailsTxt.Location = new System.Drawing.Point(96, 154);
            this.ReleasedDetailsTxt.Name = "ReleasedDetailsTxt";
            this.ReleasedDetailsTxt.Size = new System.Drawing.Size(214, 26);
            this.ReleasedDetailsTxt.TabIndex = 4;
            this.ReleasedDetailsTxt.Tag = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Plot:";
            // 
            // PlotDetailsTxt
            // 
            this.PlotDetailsTxt.Enabled = false;
            this.PlotDetailsTxt.Location = new System.Drawing.Point(77, 422);
            this.PlotDetailsTxt.Multiline = true;
            this.PlotDetailsTxt.Name = "PlotDetailsTxt";
            this.PlotDetailsTxt.Size = new System.Drawing.Size(646, 129);
            this.PlotDetailsTxt.TabIndex = 7;
            this.PlotDetailsTxt.Tag = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rated:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Title:";
            // 
            // TitleDetailsTxt
            // 
            this.TitleDetailsTxt.Enabled = false;
            this.TitleDetailsTxt.Location = new System.Drawing.Point(96, 59);
            this.TitleDetailsTxt.Name = "TitleDetailsTxt";
            this.TitleDetailsTxt.Size = new System.Drawing.Size(213, 26);
            this.TitleDetailsTxt.TabIndex = 1;
            this.TitleDetailsTxt.Tag = "1";
            // 
            // TypeDetailsTxt
            // 
            this.TypeDetailsTxt.Enabled = false;
            this.TypeDetailsTxt.Location = new System.Drawing.Point(96, 123);
            this.TypeDetailsTxt.Name = "TypeDetailsTxt";
            this.TypeDetailsTxt.Size = new System.Drawing.Size(213, 26);
            this.TypeDetailsTxt.TabIndex = 3;
            this.TypeDetailsTxt.Tag = "3";
            // 
            // YearDetailstxt
            // 
            this.YearDetailstxt.Enabled = false;
            this.YearDetailstxt.Location = new System.Drawing.Point(96, 91);
            this.YearDetailstxt.Name = "YearDetailstxt";
            this.YearDetailstxt.Size = new System.Drawing.Size(213, 26);
            this.YearDetailstxt.TabIndex = 2;
            this.YearDetailstxt.Tag = "2";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.MoviesDataGridView);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1920, 334);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movies";
            // 
            // MoviesDataGridView
            // 
            this.MoviesDataGridView.AllowUserToAddRows = false;
            this.MoviesDataGridView.AllowUserToDeleteRows = false;
            this.MoviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MoviesDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.MoviesDataGridView.Location = new System.Drawing.Point(3, 114);
            this.MoviesDataGridView.Name = "MoviesDataGridView";
            this.MoviesDataGridView.ReadOnly = true;
            this.MoviesDataGridView.Size = new System.Drawing.Size(1914, 217);
            this.MoviesDataGridView.TabIndex = 4;
            this.MoviesDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MoviesGridView_RowHeaderMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.MovieIdText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.GetAllMoviesButton);
            this.groupBox2.Controls.Add(this.SearchGroupBox);
            this.groupBox2.Controls.Add(this.SearchMovieButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.MovieYearText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SearchTitlelbl);
            this.groupBox2.Controls.Add(this.MovieTitleText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1914, 98);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(420, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 20);
            this.label22.TabIndex = 14;
            this.label22.Text = "OR";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label21.Location = new System.Drawing.Point(468, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 24);
            this.label21.TabIndex = 13;
            this.label21.Text = "IMDb ID:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MovieIdText
            // 
            this.MovieIdText.Location = new System.Drawing.Point(555, 23);
            this.MovieIdText.MinimumSize = new System.Drawing.Size(4, 30);
            this.MovieIdText.Multiline = true;
            this.MovieIdText.Name = "MovieIdText";
            this.MovieIdText.Size = new System.Drawing.Size(158, 30);
            this.MovieIdText.TabIndex = 12;
            this.MovieIdText.TextChanged += new System.EventHandler(this.MovieIdText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(719, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Required";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GetAllMoviesButton
            // 
            this.GetAllMoviesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetAllMoviesButton.Location = new System.Drawing.Point(1508, 15);
            this.GetAllMoviesButton.Name = "GetAllMoviesButton";
            this.GetAllMoviesButton.Size = new System.Drawing.Size(231, 50);
            this.GetAllMoviesButton.TabIndex = 10;
            this.GetAllMoviesButton.Text = "Display All Movies";
            this.GetAllMoviesButton.UseVisualStyleBackColor = true;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchGroupBox.AutoSize = true;
            this.SearchGroupBox.Controls.Add(this.LocalDatabaseRadio);
            this.SearchGroupBox.Controls.Add(this.OnlineDatabaseRadio);
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(1006, 8);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(220, 68);
            this.SearchGroupBox.TabIndex = 9;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Where to search?";
            // 
            // LocalDatabaseRadio
            // 
            this.LocalDatabaseRadio.AutoSize = true;
            this.LocalDatabaseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalDatabaseRadio.Location = new System.Drawing.Point(8, 22);
            this.LocalDatabaseRadio.Name = "LocalDatabaseRadio";
            this.LocalDatabaseRadio.Size = new System.Drawing.Size(79, 22);
            this.LocalDatabaseRadio.TabIndex = 7;
            this.LocalDatabaseRadio.TabStop = true;
            this.LocalDatabaseRadio.Text = "Locally";
            this.LocalDatabaseRadio.UseVisualStyleBackColor = true;
            // 
            // OnlineDatabaseRadio
            // 
            this.OnlineDatabaseRadio.AutoSize = true;
            this.OnlineDatabaseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlineDatabaseRadio.Location = new System.Drawing.Point(129, 21);
            this.OnlineDatabaseRadio.Name = "OnlineDatabaseRadio";
            this.OnlineDatabaseRadio.Size = new System.Drawing.Size(74, 22);
            this.OnlineDatabaseRadio.TabIndex = 8;
            this.OnlineDatabaseRadio.TabStop = true;
            this.OnlineDatabaseRadio.Text = "Online";
            this.OnlineDatabaseRadio.UseVisualStyleBackColor = true;
            // 
            // SearchMovieButton
            // 
            this.SearchMovieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchMovieButton.AutoSize = true;
            this.SearchMovieButton.Location = new System.Drawing.Point(1249, 15);
            this.SearchMovieButton.Name = "SearchMovieButton";
            this.SearchMovieButton.Size = new System.Drawing.Size(239, 50);
            this.SearchMovieButton.TabIndex = 6;
            this.SearchMovieButton.Text = "Search";
            this.SearchMovieButton.UseVisualStyleBackColor = true;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label3.Location = new System.Drawing.Point(954, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Optional";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MovieYearText
            // 
            this.MovieYearText.Location = new System.Drawing.Point(825, 22);
            this.MovieYearText.MaxLength = 4;
            this.MovieYearText.MinimumSize = new System.Drawing.Size(4, 30);
            this.MovieYearText.Name = "MovieYearText";
            this.MovieYearText.Size = new System.Drawing.Size(123, 30);
            this.MovieYearText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(774, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchTitlelbl
            // 
            this.SearchTitlelbl.AutoSize = true;
            this.SearchTitlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SearchTitlelbl.Location = new System.Drawing.Point(188, 26);
            this.SearchTitlelbl.Name = "SearchTitlelbl";
            this.SearchTitlelbl.Size = new System.Drawing.Size(50, 24);
            this.SearchTitlelbl.TabIndex = 1;
            this.SearchTitlelbl.Text = "Title:";
            this.SearchTitlelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MovieTitleText
            // 
            this.MovieTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleText.Location = new System.Drawing.Point(244, 23);
            this.MovieTitleText.MinimumSize = new System.Drawing.Size(4, 30);
            this.MovieTitleText.Multiline = true;
            this.MovieTitleText.Name = "MovieTitleText";
            this.MovieTitleText.Size = new System.Drawing.Size(158, 30);
            this.MovieTitleText.TabIndex = 0;
            this.MovieTitleText.TextChanged += new System.EventHandler(this.MovieTitleText_TextChanged);
            // 
            // MoviesView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MovieDetailsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoviesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movie";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.MovieDetailsBox.ResumeLayout(false);
            this.MovieDetailsBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.MovieDetailsGroup.ResumeLayout(false);
            this.MovieDetailsGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoviesDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.GroupBox MovieDetailsBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox MovieTitleText;
        private System.Windows.Forms.Label SearchTitlelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MovieYearText;
        private System.Windows.Forms.Button SearchMovieButton;
        private System.Windows.Forms.RadioButton OnlineDatabaseRadio;
        private System.Windows.Forms.RadioButton LocalDatabaseRadio;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.GroupBox MovieDetailsGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TitleDetailsTxt;
        private System.Windows.Forms.TextBox TypeDetailsTxt;
        private System.Windows.Forms.TextBox YearDetailstxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PlotDetailsTxt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton DubbedRadioButton;
        private System.Windows.Forms.RadioButton SubbedRadioButton;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.DataGridView MoviesDataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ReleasedDetailsTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox LanguageDetailsTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ActorsDetailsTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox WriteDetailsTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DirectorDetailsTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox GenreDetailsTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RuntimeDetailsTxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox MetascoreDetailsTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox AwardsDetailsTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CountryDetailsTxt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox IMDbRatingDetailsTxt;
        private System.Windows.Forms.Button GetAllMoviesButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imdbID;
        private System.Windows.Forms.Label BoxOfficelbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteMovieButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox MovieIdText;
        private System.Windows.Forms.Button ClearDatabaseButton;
        private System.Windows.Forms.Button CreateMovieTableButton;
        private System.Windows.Forms.Button SetShowTimeButton;
    }
}