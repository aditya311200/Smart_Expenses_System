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
    public partial class FormMain : Form
    {
        // To make sure whose username was logged in
        string username;
        string firstName;

        public FormMain(string user)
        {
            InitializeComponent();
            username = user;
        }

        FormLogin formLogin = null;

        // Database connection
        SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\Student Challenge\StudentChallenge_051_076\Database_SmartExpensesSystem.mdf; Integrated Security = True; Connect Timeout = 30");

        private void FormMain_Load(object sender, EventArgs e)
        {
            formLogin = (FormLogin)this.Owner;

            // Open database connection
            databaseConnection.Open();

            // Pick firstname of user account
            SqlCommand queryPickFirstName = new SqlCommand("SELECT FirstName from AccountTable where Username = '" + username + "'", databaseConnection);
            SqlDataReader readFirstName = queryPickFirstName.ExecuteReader();
            if (readFirstName.Read()) {
                firstName = readFirstName["FirstName"].ToString();
            }

            // Close database connection
            databaseConnection.Close();

            // Header
            labelHeader.Text = firstName + ", What do you want to do today?";

            // Display username
            labelUsername.Text = username;

            // Small picture box and label background color while loading form
            Color backGroundColor = Color.FromArgb(0, Color.Black);
            labelSignOut.BackColor = backGroundColor;
            pictureBoxUserPP.BackColor = backGroundColor;
            pictureBoxSignOut.BackColor = backGroundColor;

            // Big picture box background color while loading form
            pictureBoxPlanning.BackColor = Color.FromArgb(255, 137, 200, 33);
            pictureBoxInputExpenses.BackColor = Color.FromArgb(255, 255, 165, 0);
        }

        private void SignOutMouseHover()
        {
            Color signOutBgColor = Color.FromArgb(15, Color.Black);
            labelBgSignOut.BackColor = signOutBgColor;
            pictureBoxSignOut.BackColor = signOutBgColor;
            labelSignOut.BackColor = signOutBgColor;
        }

        private void SignOutMouseLeave()
        {
            Color signOutBgColor = Color.FromArgb(0, Color.Black);
            labelBgSignOut.BackColor = signOutBgColor;
            pictureBoxSignOut.BackColor = signOutBgColor;
            labelSignOut.BackColor = signOutBgColor;
        }

        private void labelBgSignOut_MouseHover(object sender, EventArgs e)
        {
            labelBgSignOut.Cursor = Cursors.Hand;
            SignOutMouseHover();
        }

        private void pictureBoxSignOut_MouseHover(object sender, EventArgs e)
        {
            pictureBoxSignOut.Cursor = Cursors.Hand;
            SignOutMouseHover();
        }

        private void labelSignOut_MouseHover(object sender, EventArgs e)
        {
            labelSignOut.Cursor = Cursors.Hand;
            SignOutMouseHover();
        }

        private void labelBgSignOut_MouseLeave(object sender, EventArgs e)
        {
            SignOutMouseLeave();
        }

        private void pictureBoxSignOut_MouseLeave(object sender, EventArgs e)
        {
            SignOutMouseLeave();
        }

        private void labelSignOut_MouseLeave(object sender, EventArgs e)
        {
            SignOutMouseLeave();
        }

        private void SignOutMessage()
        {
            // Message when user click sign out
            DialogResult answer = MessageBox.Show("Are you sure want to sign out?", "Sign Out", MessageBoxButtons.YesNo);
            
            // If user click yes, redirect it to login page  
            if(answer == DialogResult.Yes) {
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }

        private void labelBgSignOut_Click(object sender, EventArgs e)
        {
            SignOutMessage();
        }

        private void pictureBoxSignOut_Click(object sender, EventArgs e)
        {
            SignOutMessage();
        }

        private void labelSignOut_Click(object sender, EventArgs e)
        {
            SignOutMessage();
        }

        private void pictureBoxPlanning_MouseHover(object sender, EventArgs e)
        {
            pictureBoxPlanning.BackColor = Color.FromArgb(255, 117, 180, 13);
            pictureBoxPlanning.Cursor = Cursors.Hand;
        }

        private void pictureBoxPlanning_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPlanning.BackColor = Color.FromArgb(255, 137, 200, 33);
        }

        private void pictureBoxPlanning_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPlanning formPlanning = new FormPlanning(username);
            formPlanning.Owner = this;
            formPlanning.Show();
        }

        private void pictureBoxInputExpenses_MouseHover(object sender, EventArgs e)
        {
            pictureBoxInputExpenses.BackColor = Color.FromArgb(255, 220, 130, 0 );
            pictureBoxInputExpenses.Cursor = Cursors.Hand;
        }

        private void pictureBoxInputExpenses_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxInputExpenses.BackColor = Color.FromArgb(255, 255, 165, 0);
        }

        private void pictureBoxInputExpenses_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInputExpenses formInputExpenses = new FormInputExpenses(username);
            formInputExpenses.Owner = this;
            formInputExpenses.Show();
        }

        private void pictureBoxHistory_MouseHover(object sender, EventArgs e)
        {
            pictureBoxHistory.BackColor = Color.Gray;
            pictureBoxHistory.Cursor = Cursors.Hand;
        }

        private void pictureBoxHistory_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxHistory.BackColor = Color.DarkGray;
        }

        private void pictureBoxHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHistory formHistory = new FormHistory(username);
            formHistory.Owner = this;
            formHistory.Show();
        }

        private void pictureBoxReBudget_MouseHover(object sender, EventArgs e)
        {
            pictureBoxReBudget.BackColor = Color.IndianRed;
            pictureBoxReBudget.Cursor = Cursors.Hand;
        }

        private void pictureBoxReBudget_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxReBudget.BackColor = Color.LightCoral;
        }

        private void pictureBoxReBudget_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReBudget formReBudget = new FormReBudget(username);
            formReBudget.Owner = this;
            formReBudget.Show();
        }
    }
}
