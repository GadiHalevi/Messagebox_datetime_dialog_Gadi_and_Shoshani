using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messagebox_datetime_dialog_Gadi_and_Shoshani
{
    public partial class Form1 : Form
    {
        private string username = "";
        private string password = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // כפתור כניסת משתמש - לאחר יצירת משתמש, מכניסים את שם המשתמש והסיסמה
        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == username && PasswordTextBox.Text == password && UsernameTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                WelcomeLabel.Text = WelcomeLabel.Text + username;
                // מעלימים את כל כפתורי מסך הפתיחה
                UsernameLabel.Visible = false;
                UsernameTextBox.Visible = false;
                PasswordLabel.Visible = false;
                PasswordTextBox.Visible = false;
                SignInButton.Visible = false;
                SignUpLabel.Visible = false;
                SignUpButton.Visible = false;

                // חושפים את האפשרות להוסיף תמונת משתמש ואת תוכן העמוד בצד ימין
                WelcomeLabel.Visible = true;
                ProfilePictureBox.Visible = true;
                EditProfileButton.Visible = true;
                ComplaintsLabel.Visible = true;
                ComplaintsList.Visible = true;

                // חושפים ומזיזים את תוכן העמוד למרכז
                TextLabel.Visible = true;
                TextLabel.Location = new Point(TitleLabel.Location.X, TitleLabel.Location.Y + 80);
                ComplaintDate.Visible = true;
                ComplaintDate.Location = new Point(TextLabel.Location.X, TextLabel.Location.Y + 70);
                ComplaintTextBox.Visible = true;
                ComplaintTextBox.Location = new Point(ComplaintDate.Location.X, ComplaintDate.Location.Y + 40);
                SendComplaintButton.Visible = true;
                SendComplaintButton.Location = new Point(ComplaintTextBox.Location.X, ComplaintTextBox.Location.Y + 40);
            }
            // אם שם המשתמש או הסיסמה לא נכונים, מופיעה הודעה בהתאם
            else
            {
                MessageBox.Show("Wrong input, try again");
                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";
            }
        }

        // כפתור יצירת המשתמש - מביא למסך יצירת המשתמש
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // מעלימים את מסך הפתיחה
            UsernameLabel.Visible = false;
            UsernameTextBox.Visible = false;
            PasswordLabel.Visible = false;
            PasswordTextBox.Visible = false;
            SignInButton.Visible = false;
            SignUpLabel.Visible = false;
            SignUpButton.Visible = false;

            // מעבירים וחושפים את אפשרות יצירת המשתמש למרכז
            NewUserLabel.Visible = true;
            NewUserLabel.Location = new Point(UsernameLabel.Location.X, UsernameLabel.Location.Y);
            NewUserTextBox.Visible = true;
            NewUserTextBox.Location = new Point(UsernameTextBox.Location.X, UsernameTextBox.Location.Y);
            NewPasswordLabel.Visible = true;
            NewPasswordLabel.Location = new Point(PasswordLabel.Location.X, PasswordLabel.Location.Y);
            NewPasswordTextBox.Visible = true;
            NewPasswordTextBox.Location = new Point(PasswordTextBox.Location.X, PasswordTextBox.Location.Y);
            DoBLabel.Visible = true;
            DoBLabel.Location = new Point(PasswordLabel.Location.X, PasswordLabel.Location.Y + 38);
            DobPicker.Visible = true;
            DobPicker.Location = new Point(PasswordTextBox.Location.X, PasswordTextBox.Location.Y + 38);
            ReturnButton.Visible = true;
            ReturnButton.Location = new Point(SignInButton.Location.X, SignInButton.Location.Y + 38);
        }

        // כפתור סיום יצירת המשתמש - מחזיר למסך הפתיחה
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            // אם המשתמש והסיסמה טובים, שומרים אותם במשתנה הראשי ומחזירים את מסך הפתיחה
            if (GoodUsername(NewUserTextBox.Text) && GoodPassword(NewPasswordTextBox.Text) && NewUserTextBox.Text != "" && NewPasswordTextBox.Text != "")
            {
                username = NewUserTextBox.Text;
                password = NewPasswordTextBox.Text;

                UsernameLabel.Visible = true;
                UsernameTextBox.Visible = true;
                PasswordLabel.Visible = true;
                PasswordTextBox.Visible = true;
                SignInButton.Visible = true;
                SignUpLabel.Visible = true;
                SignUpButton.Visible = true;

                NewUserLabel.Visible = false;
                NewUserTextBox.Visible = false;
                NewPasswordLabel.Visible = false;
                NewPasswordTextBox.Visible = false;
                DoBLabel.Visible = false;
                DobPicker.Visible = false;
                ReturnButton.Visible = false;
            }

            // אם לא, הודעה מתאימה מופיעה
            else
            {
                MessageBox.Show("Username has space / Password not strong enough");
                NewUserTextBox.Text = "";
                NewPasswordTextBox.Text = "";
            }
        }

        // פעולת עזר - בודקת אם שם המשתמש אינו בעל רווח
        private bool GoodUsername(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    return false;
                }
            }
            return true;
        }

        // פעולת עזר - בודקת אם בסיסמה יש אות גדולה ומספר
        private bool GoodPassword(string s)
        {
            bool CapsLetter = false;
            bool number = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 65 && s[i] <= 90)
                    CapsLetter = true;
                if (s[i] >= 48 && s[i] <= 57)
                    number = true;
            }
            return (CapsLetter && number);
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            //הגדרת סוגי הקבצים המותרים - לקבצים מסוג תמונה בלבד
            openFileDialog1.Filter = "pics (*.png)|*.png|pics (*.jpg)|*.jpg|All files (*.*)|*.*";
            
            //פתיחת תיבת הדו-שיח של בחירת פתיחת קובץ
            openFileDialog1.ShowDialog();

            //עדכון קובץ התמונה - בהתאם לנבחר
            ProfilePictureBox.ImageLocation = openFileDialog1.FileName;

            EditProfileButton.Text = "Change Profile Picture";
        }
        private void SendComplaintButton_Click(object sender, EventArgs e)
        {
            string date = ComplaintDate.Value.ToShortDateString();
            string complaint = ComplaintTextBox.Text;

            ComplaintsList.Items.Add($"{date}, {complaint}");

            ComplaintTextBox.Text = "";
        }

        private void ComplaintsList_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to delete this complaint?", "Delete complaint", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ComplaintsList.Items.RemoveAt(ComplaintsList.SelectedIndex);
        }

        
    }
}
