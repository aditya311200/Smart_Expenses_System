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
    public partial class FormHistory : Form
    {
        // To make sure whose username was logged in
        string username;
        public FormHistory(string user)
        {
            InitializeComponent();
            username = user;
        }

        FormMain formMain = null;

        // Database connection
        SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Student Challenge\StudentChallenge_051_076\Database_SmartExpensesSystem.mdf;Integrated Security=True;Connect Timeout=30");

        // Declare global variable and list
        string month;
        int id, year, remainBudget, remainEducation, remainFood, remainOthers;
        List<string> listDate = new List<string>();
        List<string> listExpenseName = new List<string>();
        List<string> listExpenseType = new List<string>();
        List<int> listExpensePrice = new List<int>();

        private void FormHistory_Load(object sender, EventArgs e)
        {
            formMain = (FormMain)this.Owner;
            
            // Set back color for all label
            Color backGroundColor = Color.FromArgb(100, Color.Black);
            labelBackground.BackColor = labelRemainingMoney.BackColor = labelMonth.BackColor = labelYear.BackColor = labelInitial.BackColor = labelForEducation.BackColor = labelForFood.BackColor = labelForOthers.BackColor = labelColon1.BackColor =
                labelColon2.BackColor = labelColon3.BackColor = labelColon4.BackColor = labelColon5.BackColor = labelColon6.BackColor = labelInitialBudget.BackColor = labelRemainingEducation.BackColor = labelRemainingFood.BackColor = labelRemainingOthers.BackColor =
                labelRemainingMoney.BackColor  = backGroundColor;

            // Set comboBoxYear value
            for (int i = 2010; i <= 2030; i++) {
               comboBoxYear.Items.Add(i);
            }
        }

        private void buttonCheckRemaining_Click(object sender, EventArgs e)
        {
            // Check empty input
            if (comboBoxMonth.Text == "" || comboBoxYear.Text == "") {
                MessageBox.Show("Fill in the blank!", "Alert");
            } else {
                month = comboBoxMonth.Text;
                year = int.Parse(comboBoxYear.Text);

                // The program will execute the code in 'try' block and if the error was exist, 
                // the program will execute the 'catch' block and prevent program closure
                try
                {
                    // Pick id based on latest data input in database table
                    SqlCommand querySelectId = new SqlCommand("SELECT Id FROM " + username + "_" + month + "_" + year + "_table WHERE Id = (SELECT MAX(ID)  FROM " + username + "_" + month + "_" + year + "_table)", databaseConnection);
                    databaseConnection.Open();
                    SqlDataReader idValue = querySelectId.ExecuteReader();
                    if (idValue.Read()) {
                        id = (int)idValue.GetValue(0);
                    }
                    databaseConnection.Close();

                    // Pick initial budget, remaining budget For education, remaining budget for food and remaining budget for others
                    SqlCommand querySelectInitialAndRemaining = new SqlCommand("SELECT Budget, Education, Food, Others FROM " + username + "_" + month + "_" + year + "_table WHERE Id = " + id, databaseConnection);
                    databaseConnection.Open();
                    SqlDataReader dataValue = querySelectInitialAndRemaining.ExecuteReader();
                    if (dataValue.Read()) {
                        remainBudget = (int)dataValue["Budget"];
                        remainEducation = (int)dataValue["Education"];
                        remainFood = (int)dataValue["Food"];
                        remainOthers = (int)dataValue["Others"];
                    }
                    databaseConnection.Close();

                    // Clear list before add it with value
                    listDate.Clear();
                    listExpenseName.Clear();
                    listExpenseType.Clear();
                    listExpensePrice.Clear();

                    // Store date, expense name, expense type and expense price from database table to list
                    SqlCommand querySelectData = new SqlCommand("SELECT Date, Expenses_Name, Expenses_Type, Expenses_Price FROM " + username + "_" + month + "_" + year + "_table WHERE Information LIKE '%Store%' ORDER BY Date ASC", databaseConnection);
                    databaseConnection.Open();
                    SqlDataReader readData = querySelectData.ExecuteReader();
                    while (readData.Read()) {
                        listDate.Add(readData["Date"].ToString());
                        listExpenseName.Add(readData["Expenses_Name"].ToString());
                        listExpenseType.Add(readData["Expenses_Type"].ToString());
                        listExpensePrice.Add((int)readData.GetValue(3));
                    }
                    databaseConnection.Close();

                    // Create datatable and header of each column
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Date");
                    dataTable.Columns.Add("Expense Name");
                    dataTable.Columns.Add("Expense Type");
                    dataTable.Columns.Add("Expense Price");

                    // Create row in datatable and fill it with value in the list
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < listDate.Count(); i++) {
                        dataRow["Date"] = listDate[i].ToString() + " " + month + " " + year.ToString();
                        dataRow["Expense Name"] = listExpenseName[i].ToString();
                        dataRow["Expense Type"] = listExpenseType[i].ToString();
                        dataRow["Expense Price"] = "Rp " + listExpensePrice[i].ToString("N0");

                        // Add datarow with value from list to datatable
                        dataTable.Rows.Add(dataRow);

                        // Make a new row
                        dataRow = dataTable.NewRow();
                    }

                    // Output display
                    labelInitialBudget.Text = "Rp " + remainBudget.ToString("N0");
                    labelRemainingEducation.Text = "Rp " + remainEducation.ToString("N0");
                    labelRemainingFood.Text = "Rp " + remainFood.ToString("N0");
                    labelRemainingOthers.Text = "Rp " + remainOthers.ToString("N0");

                    // Clear all data in data grid view
                    dataGridViewAllExpenses.Rows.Clear();
                    dataGridViewAllExpenses.Refresh();

                    // Display the datatable rows value to data grid view
                    foreach (DataRow data in dataTable.Rows)
                    {
                        int row = dataGridViewAllExpenses.Rows.Add();
                        dataGridViewAllExpenses.Rows[row].Cells[0].Value = data["Date"].ToString();
                        dataGridViewAllExpenses.Rows[row].Cells[1].Value = data["Expense Name"].ToString();
                        dataGridViewAllExpenses.Rows[row].Cells[2].Value = data["Expense Type"].ToString();
                        dataGridViewAllExpenses.Rows[row].Cells[3].Value = data["Expense Price"].ToString();
                    }
                } catch {
                    // Error message while program error cause by unexist budget for certain month and year
                    MessageBox.Show("Budget for " + month + " " + year.ToString() + " doesn't exist", "Alert");

                    // Close database while there is an error in 'try' block
                    databaseConnection.Close();

                    // Reset output in the form
                    comboBoxMonth.SelectedIndex = -1;
                    comboBoxYear.SelectedIndex = -1;
                    labelInitialBudget.Text = "";
                    labelRemainingEducation.Text = "";
                    labelRemainingFood.Text = "";
                    labelRemainingOthers.Text = "";
                    dataGridViewAllExpenses.Rows.Clear();
                    dataGridViewAllExpenses.Refresh();
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain.Show();
        }
    }
}
