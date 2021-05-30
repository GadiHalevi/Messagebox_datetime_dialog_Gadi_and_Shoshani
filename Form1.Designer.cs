namespace Messagebox_datetime_dialog_Gadi_and_Shoshani
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.NewUserTextBox = new System.Windows.Forms.TextBox();
            this.NewUserLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.DobPicker = new System.Windows.Forms.DateTimePicker();
            this.DoBLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.EditProfileButton = new System.Windows.Forms.Button();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ComplaintsList = new System.Windows.Forms.ListBox();
            this.ComplaintsLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.ComplaintDate = new System.Windows.Forms.DateTimePicker();
            this.ComplaintTextBox = new System.Windows.Forms.TextBox();
            this.SendComplaintButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(320, 170);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(151, 45);
            this.SignInButton.TabIndex = 0;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.Location = new System.Drawing.Point(320, 253);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(151, 45);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // NewUserTextBox
            // 
            this.NewUserTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NewUserTextBox.Location = new System.Drawing.Point(118, 275);
            this.NewUserTextBox.Name = "NewUserTextBox";
            this.NewUserTextBox.Size = new System.Drawing.Size(126, 20);
            this.NewUserTextBox.TabIndex = 1;
            this.NewUserTextBox.Visible = false;
            this.NewUserTextBox.WordWrap = false;
            // 
            // NewUserLabel
            // 
            this.NewUserLabel.BackColor = System.Drawing.Color.Silver;
            this.NewUserLabel.Location = new System.Drawing.Point(12, 275);
            this.NewUserLabel.Name = "NewUserLabel";
            this.NewUserLabel.Size = new System.Drawing.Size(100, 23);
            this.NewUserLabel.TabIndex = 2;
            this.NewUserLabel.Text = "Username:";
            this.NewUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewUserLabel.Visible = false;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.BackColor = System.Drawing.Color.Silver;
            this.NewPasswordLabel.Location = new System.Drawing.Point(12, 314);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(100, 23);
            this.NewPasswordLabel.TabIndex = 2;
            this.NewPasswordLabel.Text = "Password:";
            this.NewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewPasswordLabel.Visible = false;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NewPasswordTextBox.Location = new System.Drawing.Point(118, 316);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(126, 20);
            this.NewPasswordTextBox.TabIndex = 1;
            this.NewPasswordTextBox.Visible = false;
            this.NewPasswordTextBox.WordWrap = false;
            // 
            // DobPicker
            // 
            this.DobPicker.Location = new System.Drawing.Point(118, 356);
            this.DobPicker.Name = "DobPicker";
            this.DobPicker.Size = new System.Drawing.Size(126, 20);
            this.DobPicker.TabIndex = 3;
            this.DobPicker.Value = new System.DateTime(2021, 3, 4, 0, 0, 0, 0);
            this.DobPicker.Visible = false;
            // 
            // DoBLabel
            // 
            this.DoBLabel.BackColor = System.Drawing.Color.Silver;
            this.DoBLabel.Location = new System.Drawing.Point(12, 353);
            this.DoBLabel.Name = "DoBLabel";
            this.DoBLabel.Size = new System.Drawing.Size(100, 23);
            this.DoBLabel.TabIndex = 2;
            this.DoBLabel.Text = "Date of Birth:";
            this.DoBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DoBLabel.Visible = false;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsernameTextBox.Location = new System.Drawing.Point(385, 91);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(126, 20);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.WordWrap = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordTextBox.Location = new System.Drawing.Point(385, 128);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(126, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.WordWrap = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.BackColor = System.Drawing.Color.Silver;
            this.UsernameLabel.Location = new System.Drawing.Point(279, 88);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(100, 23);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.Silver;
            this.PasswordLabel.Location = new System.Drawing.Point(279, 126);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 23);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.BackColor = System.Drawing.Color.Silver;
            this.SignUpLabel.Location = new System.Drawing.Point(343, 227);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(100, 23);
            this.SignUpLabel.TabIndex = 2;
            this.SignUpLabel.Text = "Don\'t have a user?";
            this.SignUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Location = new System.Drawing.Point(15, 398);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(151, 45);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "Return to Sign In";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Visible = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Silver;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TitleLabel.Location = new System.Drawing.Point(267, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(254, 61);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Welcome to F3A!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.Silver;
            this.WelcomeLabel.Location = new System.Drawing.Point(0, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(100, 23);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Welcome, ";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLabel.Visible = false;
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditProfileButton.ForeColor = System.Drawing.Color.White;
            this.EditProfileButton.Location = new System.Drawing.Point(3, 117);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Size = new System.Drawing.Size(97, 41);
            this.EditProfileButton.TabIndex = 0;
            this.EditProfileButton.Text = "Add Profile Picture";
            this.EditProfileButton.UseVisualStyleBackColor = false;
            this.EditProfileButton.Visible = false;
            this.EditProfileButton.Click += new System.EventHandler(this.EditProfileButton_Click);
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.BackColor = System.Drawing.Color.White;
            this.ProfilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProfilePictureBox.ImageLocation = "";
            this.ProfilePictureBox.Location = new System.Drawing.Point(3, 36);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(97, 75);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePictureBox.TabIndex = 4;
            this.ProfilePictureBox.TabStop = false;
            this.ProfilePictureBox.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "OpenFileDialog";
            // 
            // ComplaintsList
            // 
            this.ComplaintsList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ComplaintsList.FormattingEnabled = true;
            this.ComplaintsList.HorizontalScrollbar = true;
            this.ComplaintsList.Location = new System.Drawing.Point(602, 145);
            this.ComplaintsList.Name = "ComplaintsList";
            this.ComplaintsList.Size = new System.Drawing.Size(149, 290);
            this.ComplaintsList.TabIndex = 5;
            this.ComplaintsList.Visible = false;
            this.ComplaintsList.DoubleClick += new System.EventHandler(this.ComplaintsList_DoubleClick);
            // 
            // ComplaintsLabel
            // 
            this.ComplaintsLabel.BackColor = System.Drawing.Color.Silver;
            this.ComplaintsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ComplaintsLabel.Location = new System.Drawing.Point(602, 110);
            this.ComplaintsLabel.Name = "ComplaintsLabel";
            this.ComplaintsLabel.Size = new System.Drawing.Size(149, 32);
            this.ComplaintsLabel.TabIndex = 2;
            this.ComplaintsLabel.Text = "All Former Complaints";
            this.ComplaintsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComplaintsLabel.Visible = false;
            // 
            // TextLabel
            // 
            this.TextLabel.BackColor = System.Drawing.Color.Silver;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextLabel.Location = new System.Drawing.Point(267, 316);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(254, 61);
            this.TextLabel.TabIndex = 2;
            this.TextLabel.Text = "Now that you\'ve signed in, here you can send Roni all your complaints about the c" +
    "lass! Just put today\'s date and click \"Send\"! Have fun!";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextLabel.Visible = false;
            // 
            // ComplaintDate
            // 
            this.ComplaintDate.Location = new System.Drawing.Point(270, 389);
            this.ComplaintDate.Name = "ComplaintDate";
            this.ComplaintDate.Size = new System.Drawing.Size(126, 20);
            this.ComplaintDate.TabIndex = 3;
            this.ComplaintDate.Value = new System.DateTime(2021, 3, 4, 0, 0, 0, 0);
            this.ComplaintDate.Visible = false;
            // 
            // ComplaintTextBox
            // 
            this.ComplaintTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ComplaintTextBox.Location = new System.Drawing.Point(270, 415);
            this.ComplaintTextBox.Name = "ComplaintTextBox";
            this.ComplaintTextBox.Size = new System.Drawing.Size(251, 20);
            this.ComplaintTextBox.TabIndex = 1;
            this.ComplaintTextBox.Visible = false;
            this.ComplaintTextBox.WordWrap = false;
            // 
            // SendComplaintButton
            // 
            this.SendComplaintButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SendComplaintButton.ForeColor = System.Drawing.Color.White;
            this.SendComplaintButton.Location = new System.Drawing.Point(270, 441);
            this.SendComplaintButton.Name = "SendComplaintButton";
            this.SendComplaintButton.Size = new System.Drawing.Size(62, 31);
            this.SendComplaintButton.TabIndex = 0;
            this.SendComplaintButton.Text = "Send";
            this.SendComplaintButton.UseVisualStyleBackColor = false;
            this.SendComplaintButton.Visible = false;
            this.SendComplaintButton.Click += new System.EventHandler(this.SendComplaintButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Messagebox_datetime_dialog_Gadi_and_Shoshani.Properties.Resources.f2a;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(539, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.ComplaintsList);
            this.Controls.Add(this.ComplaintDate);
            this.Controls.Add(this.DobPicker);
            this.Controls.Add(this.DoBLabel);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.ComplaintsLabel);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.NewUserLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.ComplaintTextBox);
            this.Controls.Add(this.NewUserTextBox);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.EditProfileButton);
            this.Controls.Add(this.SendComplaintButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProfilePictureBox);
            this.Name = "Form1";
            this.Text = "F3A";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox NewUserTextBox;
        private System.Windows.Forms.Label NewUserLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.DateTimePicker DobPicker;
        private System.Windows.Forms.Label DoBLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button EditProfileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox ComplaintsList;
        private System.Windows.Forms.Label ComplaintsLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.DateTimePicker ComplaintDate;
        private System.Windows.Forms.TextBox ComplaintTextBox;
        private System.Windows.Forms.Button SendComplaintButton;
        public System.Windows.Forms.PictureBox ProfilePictureBox;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

