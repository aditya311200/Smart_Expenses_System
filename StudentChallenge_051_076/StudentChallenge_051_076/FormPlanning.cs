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
    public partial class FormPlanning : Form
    {
        // To make sure whose username was logged in
        string username;
        public FormPlanning(string user)
        {
            InitializeComponent();
            username = user;
        }

        FormMain formMain = null;

        // Database connection
        SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Student Challenge\StudentChallenge_051_076\Database_SmartExpensesSystem.mdf;Integrated Security=True;Connect Timeout=30");
        
        // Declare global variable
        string month, queryInsert;
        int year, budget, education, food, others;
        SqlCommand insertCommand;

        private void FormPlanning_Load(object sender, EventArgs e)
        {
            formMain = (FormMain)this.Owner;

            // Set back color for all label
            Color backGroundColor = Color.FromArgb(100, Color.Black);
            labelBackground.BackColor = backGroundColor;
            labelMonth.BackColor = labelYear.BackColor = labelBudget.BackColor = labelEducation.BackColor = labelFood.BackColor = labelOthers.BackColor = labelColon1.BackColor = labelColon2.BackColor =
                labelColon3.BackColor = labelColon4.BackColor = labelColon5.BackColor = labelColon6.BackColor = labelCurrency1.BackColor = labelCurrency2.BackColor = labelCurrency3.BackColor =
                labelCurrency4.BackColor = labelPlanning.BackColor = backGroundColor;

            // Set comboBoxYear value
            for (int i = 2010; i <= 2030; i++) {
               comboBoxYear.Items.Add(i);
            }

            // Disable input while loading
            buttonConfirm.Enabled = false;
        }

        private void textBoxBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make sure users can only type numbers and controls like backspace button
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxEducation_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make sure users can only type numbers and controls like backspace button
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make sure users can only type numbers and controls like backspace button
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxOthers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make sure users can only type numbers and controls like backspace button
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void InsertDataToDatabaseTable()
        {
            insertCommand.Parameters.AddWithValue("@Id", 1);
            insertCommand.Parameters.AddWithValue("@Information", "Create Budget");
            insertCommand.Parameters.AddWithValue("@Date", 0);
            insertCommand.Parameters.AddWithValue("@Month", month);
            insertCommand.Parameters.AddWithValue("@Year", year);
            insertCommand.Parameters.AddWithValue("@Budget", budget);
            insertCommand.Parameters.AddWithValue("@Remaining_Money", budget);
            insertCommand.Parameters.AddWithValue("@Education", education);
            insertCommand.Parameters.AddWithValue("@Food", food);
            insertCommand.Parameters.AddWithValue("@Others", others);
            insertCommand.Parameters.AddWithValue("@Expenses_Name", "-");
            insertCommand.Parameters.AddWithValue("@Expenses_Type", "-");
            insertCommand.Parameters.AddWithValue("@Expenses_Price", 0);
            insertCommand.ExecuteNonQuery();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            // Check empty input
            if (comboBoxMonth.Text == "" || comboBoxYear.Text == "" || textBoxBudget.Text == "" || textBoxEducation.Text == "" || textBoxFood.Text == "" || textBoxOthers.Text == "") {
                MessageBox.Show("Please fill out the empty field", "Alert");
            } else {
                // Fill variable with value
                month = comboBoxMonth.Text;
                year = int.Parse(comboBoxYear.Text);
                budget = int.Parse(textBoxBudget.Text);
                education = int.Parse(textBoxEducation.Text);
                food = int.Parse(textBoxFood.Text);
                others = int.Parse(textBoxOthers.Text);

                // Check if all specific budget is more than budget
                if ( (education + food + others) > budget) {
                    MessageBox.Show("Insufficient budget for education, food and others", "Alert");
                    buttonConfirm.Enabled = false;
                    listBoxInfo.Items.Clear();
                } else {
                    buttonConfirm.Enabled = true;
                    // Check Budget Remaining. If the remaining amount exist, add it to 'others' budget
                    if ( (education + food + others) < budget) {
                        int remains = budget - education - food - others;
                        MessageBox.Show("Your budget remains  :  Rp " + remains.ToString("N0") + "\nIt will be added to 'Others' budget","Notice");
                        others += remains;
                    }

                    // Output display
                    listBoxInfo.Items.Clear();
                    listBoxInfo.Items.Add("Budget for " + month + " " + year.ToString() + "  :   Rp " + budget.ToString("N0"));
                    listBoxInfo.Items.Add("");
                    listBoxInfo.Items.Add("Education      :      Rp " + education.ToString("N0"));
                    listBoxInfo.Items.Add("Food\t      :      Rp " + food.ToString("N0"));
                    listBoxInfo.Items.Add("Others\t      :      Rp " + others.ToString("N0"));
                }
            }
        }
        
        private void buttonConfirm_Click(object sender, EventArgs e)
        {   
            // Query create table in database for certain month and year
            string queryCreate = "CREATE TABLE " + username + "_" + month + "_" + year + "_table (Id int,Information varchar(50), Date int, Month varchar(50), Year int, Budget int, Remaining_Money int, Education int, " +
                "Food int, Others int, Expenses_Name varchar(50), Expenses_Type varchar(50), Expenses_Price int)";
            SqlCommand createDatabaseTable;

            // The program will execute the code in 'try' block and if the error was exist, 
            // the program will execute the 'catch' block and prevent program closure
            try {
                // Open database connection
                databaseConnection.Open();

                // Create table in database using query Create
                createDatabaseTable = new SqlCommand(queryCreate, databaseConnection);
                createDatabaseTable.ExecuteNonQuery();

                // Query insert data 
                queryInsert = "INSERT INTO " + username + "_" + month + "_" + year + "_table(Id, Information, Date, Month, Year, Budget, Remaining_Money, Education, Food, Others, Expenses_Name, Expenses_Type, Expenses_Price" +
                    ") VALUES (@Id, @Information, @Date, @Month, @Year, @Budget, @Remaining_Money, @Education, @Food, @Others, @Expenses_Name, @Expenses_Type, @Expenses_Price)";
                insertCommand = new SqlCommand(queryInsert, databaseConnection);

                // Insert data into database table
                InsertDataToDatabaseTable();

                // Close database connection
                databaseConnection.Close();

                // Notice if database table successfully created
                MessageBox.Show("Budget for " + month + " " + year.ToString() + " successfully registered", "Notice");

                // Redirect to main page after successfully create table for certain month and year
                this.Hide();
                formMain.Show();
            } catch {
                // Message when a table for certain month and year already exist
                DialogResult response = MessageBox.Show("Budget for " + month + " " + year.ToString() + " already exist\nDo you want to remove it with the new one?", "Alert", MessageBoxButtons.YesNo);
                
                if (response == DialogResult.Yes) {
                    // Delete table in database using query Drop
                    SqlCommand deleteQuery = new SqlCommand("DROP TABLE " + username + "_" + month + "_" + year + "_table", databaseConnection);
                    deleteQuery.ExecuteNonQuery();

                    // Create table in database using query Create
                    createDatabaseTable = new SqlCommand(queryCreate, databaseConnection);
                    createDatabaseTable.ExecuteNonQuery();

                    // Query insert data 
                    queryInsert = "INSERT INTO " + username + "_" + month + "_" + year + "_table(Id, Information, Date, Month, Year, Budget, Remaining_Money, Education, Food, Others, Expenses_Name, Expenses_Type, Expenses_Price" +
                    ") VALUES (@Id, @Information, @Date, @Month, @Year, @Budget, @Remaining_Money, @Education, @Food, @Others, @Expenses_Name, @Expenses_Type, @Expenses_Price)";
                    insertCommand = new SqlCommand(queryInsert, databaseConnection);

                    // Insert data into database table
                    InsertDataToDatabaseTable();

                    // Notice if database table successfully created
                    MessageBox.Show("Budget for " + month + " " + year.ToString() + " successfully registered", "Notice");

                    // Redirect to main page after successfully create table for certain month and year
                    this.Hide();
                    formMain.Show();
                }

                // Close database connection
                databaseConnection.Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain.Show();
        }
    }
}
