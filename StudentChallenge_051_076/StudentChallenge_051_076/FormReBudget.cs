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
    public partial class FormReBudget : Form
    {
        // To make sure whose username was logged in
        string username;
        public FormReBudget(string user)
        {
            InitializeComponent();
            username = user;
        }

        FormMain formMain = null;

        // Database connection
        SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Student Challenge\StudentChallenge_051_076\Database_SmartExpensesSystem.mdf;Integrated Security=True;Connect Timeout=30");

        // Declare global variable
        string month = "", year = "", from = "", to = "";
        int id, budget, education, food, others, fromValue, toValue, amount = 0;

        private void FormReBudget_Load(object sender, EventArgs e)
        {
            formMain = (FormMain)this.Owner;

            // Set back color for all label
            Color backGroundColor = Color.FromArgb(100, Color.Black);
            labelBackground.BackColor = labelMonth.BackColor = labelYear.BackColor = labelFrom.BackColor = labelTo.BackColor = labelAmount.BackColor = labelColon1.BackColor =
                labelColon2.BackColor = labelColon3.BackColor = labelColon4.BackColor = labelColon5.BackColor = backGroundColor;

            // Disable several input while loading
            buttonConfirm.Enabled = false;
            comboBoxTo.Enabled = false;

            // Set comboBoxYear value
            for (int i = 2010; i <= 2030; i++) {
                comboBoxYear.Items.Add(i);
            }
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make sure users can only type numbers and controls like backspace button
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear value in comboBoxTo while changing value in comboBoxFrom and enable comboBoxTo
            comboBoxTo.Items.Clear();
            comboBoxTo.Enabled = true;

            // If user choose specific budget in comboBoxFrom, it's value wouldn't display in comboBoxTo
            if (comboBoxFrom.Text == "Education") {
                comboBoxTo.Items.Add("Food");
                comboBoxTo.Items.Add("Others");
            } else if (comboBoxFrom.Text == "Food") {
                comboBoxTo.Items.Add("Education");
                comboBoxTo.Items.Add("Others");
            } else {
                comboBoxTo.Items.Add("Education");
                comboBoxTo.Items.Add("Food");
            }
        }

        private void ClearOutput()
        {
            comboBoxMonth.SelectedIndex = -1;
            comboBoxYear.SelectedIndex = -1;
            comboBoxFrom.SelectedIndex = -1;
            comboBoxTo.SelectedIndex = -1;
            comboBoxTo.Enabled = false;
            textBoxAmount.Clear();
            listBoxInfo.Items.Clear();
            buttonConfirm.Enabled = false;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            // Check empty input
            if (comboBoxMonth.Text == "" || comboBoxYear.Text == "" || comboBoxFrom.Text == "" || comboBoxTo.Text == "" || textBoxAmount.Text == "") {
                MessageBox.Show("Please fill out the empty field", "Alert");
            } else {
                from = comboBoxFrom.Text;
                to = comboBoxTo.Text;
                amount = int.Parse(textBoxAmount.Text);
                month = comboBoxMonth.Text;
                year = comboBoxYear.Text;

                // The program will execute the code in 'try' block and if the error was exist, 
                // the program will execute the 'catch' block and prevent program closure
                try {
                    // Select the latest Id in database table
                    SqlCommand querySelectId = new SqlCommand("Select Id from " + username + "_" + month + "_" + year + "_table Where Id = (SELECT MAX(ID)  from " + username + "_" + month + "_" + year + "_table)", databaseConnection);
                    databaseConnection.Open();
                    SqlDataReader idValue = querySelectId.ExecuteReader();
                    if (idValue.Read()) {
                        id = (int)idValue.GetValue(0);
                    }
                    databaseConnection.Close();

                    // Select latest data needed in database table
                    SqlCommand querySelectLatestData = new SqlCommand("Select Budget, Education, Food, Others from " + username + "_" + month + "_" + year + "_table Where Id = (SELECT MAX(ID)  from " + username + "_" + month + "_" + year + "_table)", databaseConnection);
                    databaseConnection.Open();
                    SqlDataReader latestValue = querySelectLatestData.ExecuteReader();
                    if (latestValue.Read()) {
                        budget = (int)latestValue.GetValue(0);
                        education = (int)latestValue.GetValue(1);
                        food = (int)latestValue.GetValue(2);
                        others = (int)latestValue.GetValue(3);
                    }
                    databaseConnection.Close();

                    // Select remaining for specific budget which user choose in comboBoxFrom and comboBoxTo
                    SqlCommand querySpecificBudget = new SqlCommand("Select " + from + ", " + to + " from " + username + "_" + month + "_" + year + "_table Where Id = " + id, databaseConnection);
                    databaseConnection.Open();
                    SqlDataReader specificValue = querySpecificBudget.ExecuteReader();
                    if (specificValue.Read()) {
                        fromValue = (int)specificValue[from];
                        toValue = (int)specificValue[to];
                    }
                    databaseConnection.Close();
                    
                    // Check if amount money that user input can be move from cross budget
                    if (amount > fromValue) {
                        // Message when insufficient amount
                        MessageBox.Show("Money doesn't enough", "Alert");

                        // Clear output in list box
                        listBoxInfo.Items.Clear();

                        buttonConfirm.Enabled = false;
                    } else {
                        fromValue -= amount;
                        toValue += amount;
                        buttonConfirm.Enabled = true;

                        // Clear output in list box
                        listBoxInfo.Items.Clear();

                        // Output display
                        listBoxInfo.Items.Add("Transfer\t: Rp " + amount.ToString("N0"));
                        listBoxInfo.Items.Add("");
                        listBoxInfo.Items.Add("From\t: " + from + " Budget");
                        listBoxInfo.Items.Add("To\t: " + to + " Budget");
                        listBoxInfo.Items.Add("");
                        listBoxInfo.Items.Add("After transfer\t:");
                        listBoxInfo.Items.Add(from + " Budget\t: Rp " + fromValue.ToString("N0"));
                        listBoxInfo.Items.Add(to + " Budget\t: Rp " + toValue.ToString("N0"));
                    }
                } catch {
                    // Error message while program error cause by unexist budget for certain month and year
                    MessageBox.Show("Budget for " + month + " " + year.ToString() + " doesn't exist", "Alert");

                    // Close database while there is an error in 'try' block
                    databaseConnection.Close();

                    // Reset output in the form
                    ClearOutput();
                }
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            databaseConnection.Open();

            // Query insert data to the database table
            string queryInsert = "INSERT INTO " + username + "_" + month + "_" + year + "_table(Id, Information, Date, Month, Year, Budget, Remaining_Money, Education, Food, Others, Expenses_Name, Expenses_Type, Expenses_Price" +
                ") VALUES (@Id, @Information, @Date, @Month, @Year, @Budget, @Remaining_Money, @Education, @Food, @Others, @Expenses_Name, @Expenses_Type, @Expenses_Price)";
            SqlCommand insertCommand = new SqlCommand(queryInsert, databaseConnection);

            // Insert data to database table
            insertCommand.Parameters.AddWithValue("@Id", id + 1);
            insertCommand.Parameters.AddWithValue("@Information", "Re-Budget, " + from + " --> " + to + " : Rp " + amount.ToString());
            insertCommand.Parameters.AddWithValue("@Date", 0);
            insertCommand.Parameters.AddWithValue("@Month", month);
            insertCommand.Parameters.AddWithValue("@Year", year);
            insertCommand.Parameters.AddWithValue("@Budget", budget);
            insertCommand.Parameters.AddWithValue("@Remaining_Money", education + food + others);

            if (from == "Education") {
                insertCommand.Parameters.AddWithValue("@Education", fromValue);
                if (to == "Food") {
                    insertCommand.Parameters.AddWithValue("@Food", toValue);
                    insertCommand.Parameters.AddWithValue("@Others", others);
                } else {
                    insertCommand.Parameters.AddWithValue("@Food", food);
                    insertCommand.Parameters.AddWithValue("@Others", toValue);
                }
            } else if (from == "Food") {
                insertCommand.Parameters.AddWithValue("@Food", fromValue);
                if (to == "Education") {
                    insertCommand.Parameters.AddWithValue("@Education", toValue);
                    insertCommand.Parameters.AddWithValue("@Others", others);
                } else {
                    insertCommand.Parameters.AddWithValue("@Education", education);
                    insertCommand.Parameters.AddWithValue("@Others", toValue);
                }
            } else {
                insertCommand.Parameters.AddWithValue("@Others", fromValue);
                if (to == "Education") {
                    insertCommand.Parameters.AddWithValue("@Education", toValue);
                    insertCommand.Parameters.AddWithValue("@Food", food);
                } else {
                    insertCommand.Parameters.AddWithValue("@Education", education);
                    insertCommand.Parameters.AddWithValue("@Food", toValue);
                }
            }

            insertCommand.Parameters.AddWithValue("@Expenses_Name", "-");
            insertCommand.Parameters.AddWithValue("@Expenses_Type", "-");
            insertCommand.Parameters.AddWithValue("@Expenses_Price", 0);
            insertCommand.ExecuteNonQuery();
            databaseConnection.Close();

            // Message after successfully transfer cross budget
            MessageBox.Show("Transfer cross budget successfully","Notice");

            // Reset output in the form
            ClearOutput();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain.Show();
        }
    }
}
