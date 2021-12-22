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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        FormLogin formLogin = null;

        // Database connection
        SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\Student Challenge\StudentChallenge_051_076\Database_SmartExpensesSystem.mdf; Integrated Security = True; Connect Timeout = 30");

        // Declare global variable
        List<string> listUsername = new List<string>();

        private void FormRegister_Load(object sender, EventArgs e)
        {
            formLogin = (FormLogin)this.Owner;

            // Set back color for all label
            Color backGroundColor = Color.FromArgb(25, Color.Black);
            Color backGroundColor2 = Color.FromArgb(0, Color.Black);
            labelBackGround.BackColor = backGroundColor;
            labelHaveAccount.BackColor = backGroundColor;
            labelLogin.BackColor = backGroundColor;
            labelHeader.BackColor = backGroundColor2;
            labelFooter.BackColor = backGroundColor2;

            // Limit character length for textbox
            textBoxFirstName.MaxLength = 10;
            textBoxLastName.MaxLength = 10;
            textBoxUsername.MaxLength = 15;
            textBoxPassword.MaxLength = 12;
            textBoxConfirmPassword.MaxLength = 12;
        }

        private void FirstNamePlaceHolder()
        {
            if (textBoxFirstName.Text == "First Name . . . .") {
                textBoxFirstName.Text = "";
            }
            textBoxFirstName.ForeColor = Color.Black;
        }

        private void LastNamePlaceHolder()
        {
            if (textBoxLastName.Text == "Last Name . . . .") {
                textBoxLastName.Text = "";
            }
            textBoxLastName.ForeColor = Color.Black;
        }

        private void UsernamePlaceHolder()
        {
            if (textBoxUsername.Text == "Username . . . .") {
                textBoxUsername.Text = "";
            }
            textBoxUsername.ForeColor = Color.Black;
        }

        private void PasswordPlaceHolder()
        {
            if (textBoxPassword.Text == "Password . . . .") {
                textBoxPassword.Text = "";
            }
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.PasswordChar = '*';
        }

        private void ConfirmPasswordPlaceHolder()
        {
            if (textBoxConfirmPassword.Text == "Confirm Password . . . .") {
                textBoxConfirmPassword.Text = "";
            }
            textBoxConfirmPassword.ForeColor = Color.Black;
            textBoxConfirmPassword.PasswordChar = '*';
        }

        private void textBoxFirstName_Click(object sender, EventArgs e)
        {
            FirstNamePlaceHolder();
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            FirstNamePlaceHolder();
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "") {
                textBoxFirstName.Text = "First Name . . . .";
                textBoxFirstName.ForeColor = Color.Gray;
            }
        }

        private void textBoxLastName_Click(object sender, EventArgs e)
        {
            LastNamePlaceHolder();
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            LastNamePlaceHolder();
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "") {
                textBoxLastName.Text = "Last Name . . . .";
                textBoxLastName.ForeColor = Color.Gray;
            }
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            UsernamePlaceHolder();
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            UsernamePlaceHolder();
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "") {
                textBoxUsername.Text = "Username . . . .";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            PasswordPlaceHolder();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            PasswordPlaceHolder();
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "") {
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = "Password . . . .";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxConfirmPassword_Click(object sender, EventArgs e)
        {
            ConfirmPasswordPlaceHolder();
        }

        private void textBoxConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmPasswordPlaceHolder();
        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxConfirmPassword.Text == "") {
                textBoxConfirmPassword.PasswordChar = '\0';
                textBoxConfirmPassword.Text = "Confirm Password . . . .";
                textBoxConfirmPassword.ForeColor = Color.Gray;
            }
        }

        private void labelLogin_MouseHover(object sender, EventArgs e)
        {
            Cursor cur = Cursors.Hand;
            labelLogin.Cursor = cur;
            labelLogin.Font = new Font(labelLogin.Font.Name, labelLogin.Font.SizeInPoints, FontStyle.Underline);
        }

        private void labelLogin_MouseLeave(object sender, EventArgs e)
        {
            labelLogin.Font = new Font(labelLogin.Font.Name, labelLogin.Font.SizeInPoints, FontStyle.Regular);
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {   
            // Empty data in textbox (marked with gray forecolor)
            if(textBoxFirstName.ForeColor == Color.Gray || textBoxPassword.ForeColor == Color.Gray || textBoxConfirmPassword.ForeColor == Color.Gray || textBoxUsername.ForeColor == Color.Gray) {
                MessageBox.Show("Please fill out the empty field", "Alert");
            // Check if password and confirm password not same
            } else if(textBoxConfirmPassword.Text != textBoxPassword.Text) {
                MessageBox.Show("The password doesn't match", "Alert");
            } else {
                string firstName = textBoxFirstName.Text.Trim();
                string lastName = textBoxLastName.Text.Trim();
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text.Trim();

                // Open database connection
                databaseConnection.Open();

                // Clear list
                listUsername.Clear();

                // Select all username in account table and store it to list
                SqlCommand searchUsername = new SqlCommand("SELECT Username from AccountTable", databaseConnection);
                SqlDataReader readUsername = searchUsername.ExecuteReader();
                while (readUsername.Read()) {
                    listUsername.Add(readUsername["Username"].ToString());
                }

                // Close database connection
                databaseConnection.Close();

                // Check if there is same username exist in database table
                bool accountExist = false;
                for (int i = 0; i < listUsername.Count(); i++) {
                    if (username == listUsername[i]) {
                        accountExist = true;
                        break;
                    } else {
                        accountExist = false;
                    }
                }

                if (accountExist) {
                    MessageBox.Show("This username already used","Alert");
                } else {
                    // Open database connection
                    databaseConnection.Open();

                    // Query insert new account to database
                    SqlCommand createAccount = new SqlCommand("INSERT INTO AccountTable(FirstName, LastName,Username, Password)VALUES(@FirstName, @LastName, @Username, @Password)", databaseConnection);
                    createAccount.Parameters.AddWithValue("@FirstName", firstName);
                    createAccount.Parameters.AddWithValue("@LastName", lastName);
                    createAccount.Parameters.AddWithValue("@Username", username);
                    createAccount.Parameters.AddWithValue("@Password", password);
                    createAccount.ExecuteNonQuery();

                    // Close database connection
                    databaseConnection.Close();

                    // Message after successfully create account
                    MessageBox.Show("Register successfully.", "Register Account");

                    // Redirect to login page after successfully create account
                    this.Hide();
                    formLogin.Show();
                }
            }
        }
    }
}
