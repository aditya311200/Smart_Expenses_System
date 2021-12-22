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
    public partial class FormInputExpenses : Form
    {
        // To make sure whose username was logged in
        string username;
        public FormInputExpenses(string user)
        {
            InitializeComponent();
            username = user;
        }

        FormMain formMain = null;

        // Database connection
        SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Student Challenge\StudentChallenge_051_076\Database_SmartExpensesSystem.mdf;Integrated Security=True;Connect Timeout=30");

        // Declare global variable
        int day, year, expensePrice, specificBudget, debt;
        string month, expenseName, expenseType;
        DateTime date;

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make sure users can only type numbers and controls like backspace button
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        private void FormInputExpenses_Load(object sender, EventArgs e)
        {
            formMain = (FormMain)this.Owner;

            // Set Back color for all label
            Color backGroundColor = Color.FromArgb(100, Color.Black);
            labelBackground.BackColor = labelDate.BackColor = labelExpenses.BackColor = labelType.BackColor = labelPrice.BackColor = labelColon1.BackColor =
                labelColon2.BackColor = labelColon3.BackColor = labelColon4.BackColor = labelCurrency.BackColor = backGroundColor;

            // Disable button while loading
            buttonConfirm.Enabled = false;
        }

        private string MonthToString(int month) {
            string[] monthString = new string[12] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            return monthString[month - 1];
        }

        private void ClearOutput()
        {
            dateTimePickerDate.Value = DateTime.Now;
            textBoxExpenses.Clear();
            comboBoxExpensesType.SelectedIndex = -1;
            textBoxPrice.Clear();
            buttonConfirm.Enabled = false;
            listBoxInfo.Items.Clear();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (textBoxExpenses.Text == "" || comboBoxExpensesType.Text == "" || textBoxPrice.Text == "") {
                MessageBox.Show("Please fill out the empty field", "Alert");
            } else {
                // Fill variable with value
                date = dateTimePickerDate.Value;
                day = dateTimePickerDate.Value.Day;
                month = MonthToString(dateTimePickerDate.Value.Month);
                year = dateTimePickerDate.Value.Year;
                expenseName = textBoxExpenses.Text;
                expenseType = comboBoxExpensesType.Text;
                expensePrice = int.Parse(textBoxPrice.Text);
                debt = 0;
                specificBudget = 0;

                try {
                    // Find the latest value of remaining specific budget in database table (education or food or others)
                    SqlCommand querySelect = new SqlCommand("Select " + expenseType + " from " + username + "_" + month + "_" + year + "_table Where Id = (SELECT MAX(ID)  from " + username + "_" + month + "_" + year + "_table)", databaseConnection);
                    databaseConnection.Open();
                    SqlDataReader readData = querySelect.ExecuteReader();
                    if (readData.Read()) {
                        specificBudget = (int)readData.GetValue(0);
                    }
                    databaseConnection.Close();

                    // Check if the expense price is less than remaining specific budget
                    if (expensePrice <= specificBudget) {
                        listBoxInfo.Items.Clear();
                        listBoxInfo.Items.Add("Date\t   :    " + date.ToString("dddd, MMMM dd yyyy"));
                        listBoxInfo.Items.Add("Expenses\t   :    " + expenseName);
                        listBoxInfo.Items.Add("Type\t   :    " + expenseType);
                        listBoxInfo.Items.Add("Price\t   :    Rp " + expensePrice.ToString("N0"));
                        buttonConfirm.Enabled = true;
                        // If specific budget less than expense price
                    } else {
                        // Check if expense type isn't 'others' category 
                        if (expenseType != "Others") {
                            DialogResult choice = MessageBox.Show("Not Enough Budget!\nDo you want to cover up the lack of money with 'Others' Budget?", "Alert", MessageBoxButtons.YesNo);
                            if (choice == DialogResult.Yes) {
                                // Find the lack of cost
                                debt = expensePrice - specificBudget;

                                // Find the latest value of 'others' budget in database table to cover the lack of education or food cost
                                SqlCommand querySelectForDebt = new SqlCommand("Select Others from " + username + "_" + month + "_" + year + "_table Where Id = (SELECT MAX(ID)  from " + username + "_" + month + "_" + year + "_table)", databaseConnection);
                                databaseConnection.Open();
                                SqlDataReader readDataForDebt = querySelectForDebt.ExecuteReader();
                                if (readDataForDebt.Read()) {
                                    specificBudget = (int)readDataForDebt.GetValue(0);
                                }
                                databaseConnection.Close();

                                // Check if 'others' budget can cover the lack of education or food cost
                                if (debt <= specificBudget) {
                                    specificBudget -= debt;
                                    listBoxInfo.Items.Clear();
                                    listBoxInfo.Items.Add("Date\t   :    " + date.ToString("dddd, MMMM dd yyyy"));
                                    listBoxInfo.Items.Add("Expenses\t   :    " + expenseName);
                                    listBoxInfo.Items.Add("Type\t   :    " + expenseType);
                                    listBoxInfo.Items.Add("Price\t   :    Rp " + expensePrice.ToString("N0"));
                                    buttonConfirm.Enabled = true;
                                } else {
                                    MessageBox.Show("'Others' Budget don't enough. You must re-Budget!", "Alert");
                                    comboBoxExpensesType.SelectedIndex = -1;
                                    textBoxPrice.Clear();
                                    listBoxInfo.Items.Clear();
                                    buttonConfirm.Enabled = false;
                                }
                                // If user choose no
                            } else {
                                listBoxInfo.Items.Clear();
                                buttonConfirm.Enabled = false;
                            }
                            // If the expenses type is 'others' category and can't cover the lack
                        } else {
                            MessageBox.Show("Budget don't enough. You must re-Budget!", "Alert");
                            comboBoxExpensesType.SelectedIndex = -1;
                            textBoxPrice.Clear();
                            listBoxInfo.Items.Clear();
                            buttonConfirm.Enabled = false;
                        }
                    }
                } catch {
                    // Error message while program error cause by unexist budget for certain month and year
                    MessageBox.Show("Budget for " + month + " " + year.ToString() + " doesn't exist", "Alert");

                    // Close database while there is an error in 'try' block
                    databaseConnection.Close();

                    // Clear Output Display
                    ClearOutput();
                }
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // Declare variable id, beginning budget, remaining money and remaining specific budget (education, food, other)
            int id = 0, budget = 0, remainingMoney = 0, remainEducation = 0, remainFood = 0, remainOthers = 0;

            // Pick id
            SqlCommand querySelectId = new SqlCommand("Select Id from " + username + "_" + month + "_" + year + "_table Where Id = (SELECT MAX(ID)  from " + username + "_" + month + "_" + year + "_table)", databaseConnection);
            databaseConnection.Open();
            SqlDataReader idValue = querySelectId.ExecuteReader();
            if (idValue.Read()) {
                id = (int)idValue.GetValue(0);
            }
            databaseConnection.Close();

            // Pick beginning budget, remaining budget for education, remaining budget for food, remaining budget for others
            SqlCommand querySelectData = new SqlCommand("Select Budget, Education, Food, Others from " + username + "_" + month + "_" + year + "_table Where Id = " + id, databaseConnection);
            databaseConnection.Open();
            SqlDataReader dataValue = querySelectData.ExecuteReader();
            if (dataValue.Read()) {
                budget = (int)dataValue.GetValue(0);
                remainEducation = (int)dataValue.GetValue(1);
                remainFood = (int)dataValue.GetValue(2);
                remainOthers = (int)dataValue.GetValue(3);
            }
            databaseConnection.Close();

            // Query to insert data to database table
            string queryInsert = "INSERT INTO " + username + "_" + month + "_" + year + "_table(Id, Information, Date, Month, Year, Budget, Remaining_Money, Education, Food, Others, Expenses_Name, Expenses_Type, Expenses_Price" +
                    ") VALUES (@Id, @Information, @Date, @Month, @Year, @Budget, @Remaining_Money, @Education, @Food, @Others, @Expenses_Name, @Expenses_Type, @Expenses_Price)";
            SqlCommand insertCommand = new SqlCommand(queryInsert, databaseConnection);
            databaseConnection.Open();

            // Insert data to database table
            insertCommand.Parameters.AddWithValue("@Id", id + 1);
            insertCommand.Parameters.AddWithValue("@Date", day);
            insertCommand.Parameters.AddWithValue("@Month", month);
            insertCommand.Parameters.AddWithValue("@Year", year);
            insertCommand.Parameters.AddWithValue("@Budget", budget);
            insertCommand.Parameters.AddWithValue("@Expenses_Name", expenseName);
            insertCommand.Parameters.AddWithValue("@Expenses_Type", expenseType);
            insertCommand.Parameters.AddWithValue("@Expenses_Price", expensePrice);
            
            // Check if there is insufficient money represented by 'debt' variable
            if (debt == 0) {
                insertCommand.Parameters.AddWithValue("@Information", "Store Expense");

                // Find remaining money
                remainingMoney = remainEducation + remainFood + remainOthers - expensePrice;

                // Decrease specific budget with expensePrice than store it
                if (expenseType == "Education") {
                    insertCommand.Parameters.AddWithValue("@Education", remainEducation - expensePrice);
                    insertCommand.Parameters.AddWithValue("@Food", remainFood);
                    insertCommand.Parameters.AddWithValue("@Others", remainOthers);
                } else if (expenseType == "Food") {
                    insertCommand.Parameters.AddWithValue("@Education", remainEducation);
                    insertCommand.Parameters.AddWithValue("@Food", remainFood - expensePrice);
                    insertCommand.Parameters.AddWithValue("@Others", remainOthers);
                } else {
                    insertCommand.Parameters.AddWithValue("@Education", remainEducation);
                    insertCommand.Parameters.AddWithValue("@Food", remainFood);
                    insertCommand.Parameters.AddWithValue("@Others", remainOthers - expensePrice);
                }
            } else {
                // Because there is insufficient budget, and the insufficient is covered by 'others' budget,
                // so the remaining money (specific budget) will set to 0 and the 'other' will reduce by debt
                insertCommand.Parameters.AddWithValue("@Information", "Store Expense, Withdraw 'Others' Budget");
                remainOthers -= debt;
                if (expenseType == "Education") {
                    insertCommand.Parameters.AddWithValue("@Education", 0);
                    insertCommand.Parameters.AddWithValue("@Food", remainFood);
                    remainingMoney = remainFood + remainOthers;
                } else if (expenseType == "Food") {
                    insertCommand.Parameters.AddWithValue("@Education", remainEducation);
                    insertCommand.Parameters.AddWithValue("@Food", 0);
                    remainingMoney = remainEducation + remainOthers;
                }
                
                insertCommand.Parameters.AddWithValue("@Others", remainOthers);
            }

            insertCommand.Parameters.AddWithValue("@Remaining_Money", remainingMoney);
            insertCommand.ExecuteNonQuery();
            databaseConnection.Close();

            // Notice if expense successfully upload
            MessageBox.Show("Expense successfully upload\nRemaining Money : Rp. " + remainingMoney.ToString("N0"), "Notice");
            
            // Clear output display
            ClearOutput();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain.Show();
        }
    }
}
