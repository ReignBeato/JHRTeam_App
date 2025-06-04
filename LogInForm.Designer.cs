namespace JHRTeam_App
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.linklblforgotpassword = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblWelcomeBack = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonSignIn);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.linklblforgotpassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.lblWelcomeBack);
            this.panel1.Location = new System.Drawing.Point(442, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 267);
            this.panel1.TabIndex = 0;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSignIn.Location = new System.Drawing.Point(134, 214);
            this.buttonSignIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(77, 28);
            this.buttonSignIn.TabIndex = 6;
            this.buttonSignIn.Text = "SIGN IN";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnlogin.Location = new System.Drawing.Point(47, 214);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(77, 28);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "LOG IN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // linklblforgotpassword
            // 
            this.linklblforgotpassword.AutoSize = true;
            this.linklblforgotpassword.Location = new System.Drawing.Point(73, 168);
            this.linklblforgotpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklblforgotpassword.Name = "linklblforgotpassword";
            this.linklblforgotpassword.Size = new System.Drawing.Size(92, 13);
            this.linklblforgotpassword.TabIndex = 4;
            this.linklblforgotpassword.TabStop = true;
            this.linklblforgotpassword.Text = "Forgot Password?";
            this.linklblforgotpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblforgotpassword_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(47, 132);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(47, 84);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(166, 20);
            this.txtemail.TabIndex = 2;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(97, 46);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(69, 20);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "LOG IN";
            this.lblLogin.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblWelcomeBack
            // 
            this.lblWelcomeBack.AutoSize = true;
            this.lblWelcomeBack.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblWelcomeBack.Location = new System.Drawing.Point(51, 13);
            this.lblWelcomeBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcomeBack.Name = "lblWelcomeBack";
            this.lblWelcomeBack.Size = new System.Drawing.Size(179, 26);
            this.lblWelcomeBack.TabIndex = 0;
            this.lblWelcomeBack.Text = "WELCOME BACK!";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 494);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogInForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Log In Form";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcomeBack;
        private System.Windows.Forms.Label lblLogin;

        private System.Windows.Forms.TextBox txtemail;

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel linklblforgotpassword;
        private System.Windows.Forms.Button buttonSignIn;
    }
}