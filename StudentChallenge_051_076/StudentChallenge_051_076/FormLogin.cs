using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentChallenge_051_076
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Database connection
        SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\Student Challenge\StudentChallenge_051_076\Database_SmartExpensesSystem.mdf; Integrated Security = True; Connect Timeout = 30");

        // Declare global variable
        bool visible = false;
        List<string> listUsername = new List<string>();
        List<string> listPassword = new List<string>();

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Set back color for all label and several picture box
            Color backGroundColor = Color.FromArgb(25, Color.Black);
            Color backGroundColor2 = Color.FromArgb(0, Color.Black);
            labelBackGround.BackColor = backGroundColor;
            pictureBoxUserIcon.BackColor = backGroundColor;
            pictureBoxPasswordIcon.BackColor = backGroundColor;
            labelDontHave.BackColor = backGroundColor;
            labelRegister.BackColor = backGroundColor;
            labelHeader.BackColor = backGroundColor2;
            labelFooter.BackColor = backGroundColor2;

            // Reset textbox value
            textBoxUsername.Clear();
            textBoxPassword.Clear();

            // Set back color for visibility icon in textbox password
            pictureBoxVisibility.BackColor = Color.White;

            // Limit character length for textbox username and password
            textBoxUsername.MaxLength = 15;
            textBoxPassword.MaxLength = 12;
        }

        private void pictureBoxVisibility_Click(object sender, EventArgs e)
        {
            // Visibility check
            if (!visible) {
                // User can see character in textboxpassword
                visible = true;
                textBoxPassword.PasswordChar = '\0';
                pictureBoxVisibility.Image = Properties.Resources.visibilityon;
            } else {
                // User only see character in textboxpassword as '*'
                visible = false;
                textBoxPassword.PasswordChar = '*';
                pictureBoxVisibility.Image = Properties.Resources.visibilityoff;
            }
        }

        private void pictureBoxVisibility_MouseHover(object sender, EventArgs e)
        {
            pictureBoxVisibility.Cursor = Cursors.Hand;
        }

        private void labelRegister_MouseHover(object sender, EventArgs e)
        {
            labelRegister.Cursor = Cursors.Hand;
            labelRegister.Font = new Font(labelRegister.Font.Name, labelRegister.Font.SizeInPoints, FontStyle.Underline);
        }

        private void labelRegister_MouseLeave(object sender, EventArgs e)
        {
            labelRegister.Font = new Font(labelRegister.Font.Name, labelRegister.Font.SizeInPoints, FontStyle.Regular);
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister register = new FormRegister();
            register.Owner = this;
            register.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Declare variable and fill it with value
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Clear list
            listUsername.Clear();
            listPassword.Clear();
            
            // Open connection database
            databaseConnection.Open();

            // Select all username and password in account table and store it to list
            SqlCommand searchUsernamePassword = new SqlCommand("SELECT Username, Password from AccountTable", databaseConnection);
            SqlDataReader readUsernamePassword = searchUsernamePassword.ExecuteReader();
            while (readUsernamePassword.Read()) {
                listUsername.Add(readUsernamePassword["Username"].ToString());
                listPassword.Add(readUsernamePassword["Password"].ToString());
            }

            // Close connection database
            databaseConnection.Close();

            // Check if there is same username or password in list
            bool login = false;
            for (int i = 0; i < listUsername.Count(); i++) {
                if (username == listUsername[i] && password == listPassword[i]) {
                    login = true;
                    break;
                } else {
                    login = false;
                }
            }

            // Check bool login
            if (login) {
                // Redirect to main page after user successfully login
                this.Hide();
                FormMain formMain = new FormMain(textBoxUsername.Text);
                formMain.Show();
            }  else {
                // Message if wrong username or password
                MessageBox.Show("Username or Password is incorrect.", "Alert");
            }
        }
    }
}
