namespace CinemaManager.Forms
{
    partial class MainForm
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.MoviesTab = new System.Windows.Forms.TabPage();
            this.TicketsTab = new System.Windows.Forms.TabPage();
            this.SalonTab = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MainPage);
            this.TabControl.Controls.Add(this.MoviesTab);
            this.TabControl.Controls.Add(this.TicketsTab);
            this.TabControl.Controls.Add(this.SalonTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ItemSize = new System.Drawing.Size(100, 30);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1187, 754);
            this.TabControl.TabIndex = 0;
            // 
            // MainPage
            // 
            this.MainPage.Location = new System.Drawing.Point(4, 34);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(1179, 716);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Home";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // MoviesTab
            // 
            this.MoviesTab.Location = new System.Drawing.Point(4, 34);
            this.MoviesTab.Name = "MoviesTab";
            this.MoviesTab.Padding = new System.Windows.Forms.Padding(3);
            this.MoviesTab.Size = new System.Drawing.Size(1179, 660);
            this.MoviesTab.TabIndex = 1;
            this.MoviesTab.Text = "Movies";
            this.MoviesTab.UseVisualStyleBackColor = true;
            // 
            // TicketsTab
            // 
            this.TicketsTab.Location = new System.Drawing.Point(4, 34);
            this.TicketsTab.Name = "TicketsTab";
            this.TicketsTab.Size = new System.Drawing.Size(1179, 660);
            this.TicketsTab.TabIndex = 2;
            this.TicketsTab.Text = "Tickets";
            this.TicketsTab.UseVisualStyleBackColor = true;
            // 
            // SalonTab
            // 
            this.SalonTab.Location = new System.Drawing.Point(4, 34);
            this.SalonTab.Name = "SalonTab";
            this.SalonTab.Size = new System.Drawing.Size(1179, 660);
            this.SalonTab.TabIndex = 3;
            this.SalonTab.Text = "Salons";
            this.SalonTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1187, 754);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage MoviesTab;
        private System.Windows.Forms.TabPage TicketsTab;
        private System.Windows.Forms.TabPage SalonTab;
    }
}