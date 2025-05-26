namespace JHRTeam_App
{
    partial class DashboardForm
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
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonPackages = new System.Windows.Forms.Button();
            this.buttonAirlines = new System.Windows.Forms.Button();
            this.buttonHotels = new System.Windows.Forms.Button();
            this.buttonTickets = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "JHR TRAVELS";
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(479, 20);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(174, 55);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonPackages
            // 
            this.buttonPackages.Location = new System.Drawing.Point(696, 20);
            this.buttonPackages.Name = "buttonPackages";
            this.buttonPackages.Size = new System.Drawing.Size(174, 55);
            this.buttonPackages.TabIndex = 2;
            this.buttonPackages.Text = "Packages";
            this.buttonPackages.UseVisualStyleBackColor = true;
            // 
            // buttonAirlines
            // 
            this.buttonAirlines.Location = new System.Drawing.Point(920, 20);
            this.buttonAirlines.Name = "buttonAirlines";
            this.buttonAirlines.Size = new System.Drawing.Size(174, 55);
            this.buttonAirlines.TabIndex = 3;
            this.buttonAirlines.Text = "Airlines";
            this.buttonAirlines.UseVisualStyleBackColor = true;
            // 
            // buttonHotels
            // 
            this.buttonHotels.Location = new System.Drawing.Point(1142, 20);
            this.buttonHotels.Name = "buttonHotels";
            this.buttonHotels.Size = new System.Drawing.Size(174, 55);
            this.buttonHotels.TabIndex = 4;
            this.buttonHotels.Text = "Hotels";
            this.buttonHotels.UseVisualStyleBackColor = true;
            // 
            // buttonTickets
            // 
            this.buttonTickets.Location = new System.Drawing.Point(1363, 20);
            this.buttonTickets.Name = "buttonTickets";
            this.buttonTickets.Size = new System.Drawing.Size(174, 55);
            this.buttonTickets.TabIndex = 5;
            this.buttonTickets.Text = "Tickets";
            this.buttonTickets.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(458, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(678, 123);
            this.label2.TabIndex = 6;
            this.label2.Text = "WELCOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(601, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 110);
            this.label3.TabIndex = 7;
            this.label3.Text = "तपाईंलाई यहाँ स्वागत छ\n ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(618, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "Your Adventure, Our Guide\r\nDiscover Nepal with Ease";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JHRTeam_App.Properties.Resources.Untitled_design__5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1577, 950);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTickets);
            this.Controls.Add(this.buttonHotels);
            this.Controls.Add(this.buttonAirlines);
            this.Controls.Add(this.buttonPackages);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.label1);
            this.Name = "DashboardForm";
            this.Text = "Dashboard Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonPackages;
        private System.Windows.Forms.Button buttonAirlines;
        private System.Windows.Forms.Button buttonHotels;
        private System.Windows.Forms.Button buttonTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

