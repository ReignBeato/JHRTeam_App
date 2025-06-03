namespace JHRTeam_App
{
    partial class Hotels
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
            this.panelTabs = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonPackages = new System.Windows.Forms.Button();
            this.buttonAirlines = new System.Windows.Forms.Button();
            this.buttonHotels = new System.Windows.Forms.Button();
            this.buttonTickets = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.Transparent;
            this.panelTabs.Controls.Add(this.buttonHome);
            this.panelTabs.Controls.Add(this.buttonPackages);
            this.panelTabs.Controls.Add(this.buttonAirlines);
            this.panelTabs.Controls.Add(this.buttonHotels);
            this.panelTabs.Controls.Add(this.buttonTickets);
            this.panelTabs.Controls.Add(this.pictureBox1);
            this.panelTabs.Controls.Add(this.label1);
            this.panelTabs.Location = new System.Drawing.Point(10, 12);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(1555, 78);
            this.panelTabs.TabIndex = 13;
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(523, 8);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(174, 55);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonPackages
            // 
            this.buttonPackages.Location = new System.Drawing.Point(710, 8);
            this.buttonPackages.Name = "buttonPackages";
            this.buttonPackages.Size = new System.Drawing.Size(174, 55);
            this.buttonPackages.TabIndex = 2;
            this.buttonPackages.Text = "Packages";
            this.buttonPackages.UseVisualStyleBackColor = true;
            this.buttonPackages.Click += new System.EventHandler(this.buttonPackages_Click);
            // 
            // buttonAirlines
            // 
            this.buttonAirlines.Location = new System.Drawing.Point(901, 8);
            this.buttonAirlines.Name = "buttonAirlines";
            this.buttonAirlines.Size = new System.Drawing.Size(174, 55);
            this.buttonAirlines.TabIndex = 3;
            this.buttonAirlines.Text = "Airlines";
            this.buttonAirlines.UseVisualStyleBackColor = true;
            this.buttonAirlines.Click += new System.EventHandler(this.buttonAirlines_Click);
            // 
            // buttonHotels
            // 
            this.buttonHotels.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHotels.Location = new System.Drawing.Point(1093, 8);
            this.buttonHotels.Name = "buttonHotels";
            this.buttonHotels.Size = new System.Drawing.Size(174, 55);
            this.buttonHotels.TabIndex = 4;
            this.buttonHotels.Text = "Hotels";
            this.buttonHotels.UseVisualStyleBackColor = false;
            this.buttonHotels.Click += new System.EventHandler(this.buttonHotels_Click);
            // 
            // buttonTickets
            // 
            this.buttonTickets.Location = new System.Drawing.Point(1283, 8);
            this.buttonTickets.Name = "buttonTickets";
            this.buttonTickets.Size = new System.Drawing.Size(174, 55);
            this.buttonTickets.TabIndex = 5;
            this.buttonTickets.Text = "Tickets";
            this.buttonTickets.UseVisualStyleBackColor = true;
            this.buttonTickets.Click += new System.EventHandler(this.buttonTickets_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::JHRTeam_App.Properties.Resources.travelLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(206, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "JHR TR  VELS";
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1577, 950);
            this.Controls.Add(this.panelTabs);
            this.Name = "Hotels";
            this.Text = "Hotels";
            this.panelTabs.ResumeLayout(false);
            this.panelTabs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonPackages;
        private System.Windows.Forms.Button buttonAirlines;
        private System.Windows.Forms.Button buttonHotels;
        private System.Windows.Forms.Button buttonTickets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}