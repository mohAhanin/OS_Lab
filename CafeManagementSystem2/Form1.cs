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

namespace CafeManagementSystem2
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DESKTOP-F324UIT\\SQLEXPRESS;" +
            "Initial Catalog=CAFEDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

            // Set the background color of the form
            this.BackColor = Color.LightBlue;

            // Set the font, color, and size of all the buttons, labels, and textboxes
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Font = new Font("Arial", 12, FontStyle.Bold);
                    ((Button)c).ForeColor = Color.White;
                    ((Button)c).BackColor = Color.DarkBlue;
                    ((Button)c).Size = new Size(200, 40); // Set the size of the button
                }
                else if (c is Label)
                {
                    ((Label)c).Font = new Font("Arial", 12, FontStyle.Bold);
                    ((Label)c).ForeColor = Color.DarkBlue;
                    ((Label)c).AutoSize = false; // This allows you to set the size of the label
                    ((Label)c).Size = new Size(140, 25); // Set the size of the label
                }
                else if (c is TextBox)
                {
                    ((TextBox)c).Font = new Font("Arial", 10);
                    ((TextBox)c).ForeColor = Color.DarkBlue;
                    ((TextBox)c).Size = new Size(150, 25); // Set the size of the textbox
                }
            }

            // Set the font and color of the DataGridView
            dataGridView.Font = new Font("Arial", 10);
            dataGridView.ForeColor = Color.DarkBlue;
            dataGridView.BackgroundColor = Color.White;
        }
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void CustomizeButtons()
        {
            // Customize Customer Button
            Customerbtn.BackColor = Color.LightSeaGreen;
            Customerbtn.ForeColor = Color.White;
            Customerbtn.Font = new Font("Arial", 12, FontStyle.Bold); // Increase font size
            Customerbtn.FlatStyle = FlatStyle.Flat;
            Customerbtn.FlatAppearance.BorderSize = 0;
            Customerbtn.Size = new Size(200, 40); // Increase button size
            Customerbtn.Padding = new Padding(5);

            // Customize Staff Button
            Staffbtn.BackColor = Color.SteelBlue;
            Staffbtn.ForeColor = Color.White;
            Staffbtn.Font = new Font("Arial", 12, FontStyle.Bold); // Increase font size
            Staffbtn.FlatStyle = FlatStyle.Flat;
            Staffbtn.FlatAppearance.BorderSize = 0;
            Staffbtn.Size = new Size(200, 40); // Increase button size
            Staffbtn.Padding = new Padding(5);

            // Customize Insert Customer Button
            InsertCustomerBtn.BackColor = Color.MediumSeaGreen;
            InsertCustomerBtn.ForeColor = Color.White;
            InsertCustomerBtn.Font = new Font("Arial", 12, FontStyle.Bold); // Increase font size
            InsertCustomerBtn.FlatStyle = FlatStyle.Flat;
            InsertCustomerBtn.FlatAppearance.BorderSize = 0;
            InsertCustomerBtn.Size = new Size(200, 40); // Increase button size
            InsertCustomerBtn.Padding = new Padding(5);

            // Customize Delete Customer Button
            DeleteCustomerBtn.BackColor = Color.Crimson;
            DeleteCustomerBtn.ForeColor = Color.White;
            DeleteCustomerBtn.Font = new Font("Arial", 12, FontStyle.Bold); // Increase font size
            DeleteCustomerBtn.FlatStyle = FlatStyle.Flat;
            DeleteCustomerBtn.FlatAppearance.BorderSize = 0;
            DeleteCustomerBtn.Size = new Size(200, 40); // Increase button size
            DeleteCustomerBtn.Padding = new Padding(5); // Add padding

            // Customize Update Customer Button
            UpdateCustomerBtn.BackColor = Color.Orange; // Change the color to orange
            UpdateCustomerBtn.ForeColor = Color.White;
            UpdateCustomerBtn.Font = new Font("Arial", 12, FontStyle.Bold); // Increase font size
            UpdateCustomerBtn.FlatStyle = FlatStyle.Flat;
            UpdateCustomerBtn.FlatAppearance.BorderSize = 0;
            UpdateCustomerBtn.Size = new Size(200, 40); // Increase button size
            UpdateCustomerBtn.Padding = new Padding(5);

            // Customize Insert Order Button
            InsertOrderBtn.BackColor = Color.MediumPurple;
            InsertOrderBtn.ForeColor = Color.White;
            InsertOrderBtn.Font = new Font("Arial", 12, FontStyle.Bold); // Increase font size
            InsertOrderBtn.FlatStyle = FlatStyle.Flat;
            InsertOrderBtn.FlatAppearance.BorderSize = 0;
            InsertOrderBtn.Size = new Size(170, 40); // Increase button size
            InsertOrderBtn.Padding = new Padding(5);

            // Customize Show Orders Button
            ShowOrdersBtn.BackColor = Color.DarkOrange;
            ShowOrdersBtn.ForeColor = Color.White;
            ShowOrdersBtn.Font = new Font("Arial", 12, FontStyle.Bold); // Increase font size
            ShowOrdersBtn.FlatStyle = FlatStyle.Flat;
            ShowOrdersBtn.FlatAppearance.BorderSize = 0;
            ShowOrdersBtn.Size = new Size(170, 40); // Increase button size
            ShowOrdersBtn.Padding = new Padding(5);
        }

        private void ConnectToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // You can execute commands against your database here.
            }
        }

        private void ShowData(string query, string tableName, DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable(tableName);
                            dataTable.Load(reader);
                            dataGridView.DataSource = null;
                            dataGridView.Rows.Clear();
                            dataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Customerbtn_Click(object sender, EventArgs e)
        {
            ShowData("SELECT * FROM Customer", "Customer", dataGridView);
        }

        private void Staffbtn_Click(object sender, EventArgs e)
        {
            //ShowData("SELECT * FROM Staff", "Staff", dataGridView1);
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertCustomerBtn_Click(object sender, EventArgs e)
        {
            // Check if the textboxes are empty
            if (string.IsNullOrWhiteSpace(CustomerIDTxt.Text) || string.IsNullOrWhiteSpace(FirstNameTxt.Text) || string.IsNullOrWhiteSpace(LastNameTxt.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            try
            {
                int customerID = int.Parse(CustomerIDTxt.Text);
                string firstName = FirstNameTxt.Text;
                string lastName = LastNameTxt.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Customer (CustomerID, FirstName, LastName) VALUES (@CustomerID, @FirstName, @LastName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);

                        command.ExecuteNonQuery();
                    }
                }

                // Refresh the data grid view to show the new customer
                ShowData("SELECT * FROM Customer", "Customer", dataGridView);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid data. CustomerID should be an integer.");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    // Violation of primary key. Handle Exception
                    MessageBox.Show("Customer ID already exists. Please enter a unique Customer ID.");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCustomerBtn_Click(object sender, EventArgs e)
        {
            int customerID;

            // Check if the user has entered a value for the customer ID
            if (string.IsNullOrWhiteSpace(DeleteCustomerIDTxt.Text))
            {
                MessageBox.Show("Please enter a customer ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                customerID = int.Parse(DeleteCustomerIDTxt.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer value for the customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.ExecuteNonQuery();
                }
            }

            // Refresh the data grid view to show the remaining customers
            ShowData("SELECT * FROM Customer", "Customer", dataGridView);
        }

        private void DeleteCustomerIDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTimeTimer.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void InsertOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = int.Parse(OrderIDTxt.Text);
                int customerID = int.Parse(orderCustomerIDTxt.Text);
                int tableNumber = int.Parse(TableNumberTxt.Text);
                if (tableNumber < 1 || tableNumber > 10)
                {
                    MessageBox.Show("Table number must be between 1 and 10.");
                    return;
                }
                DateTime date = DateTime.Parse(DateTxt.Text);
                TimeSpan time = TimeSpan.Parse(TimeTxt.Text);
                decimal totalPrice = decimal.Parse(TotalPriceTxt.Text);
                string orders = OrdersTxt.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Orders (OrderID, CustomerID, tableNumber, Date, Time, TotalPrice, Orders) VALUES (@OrderID, @CustomerID, @tableNumber, @Date, @Time, @TotalPrice, @Orders)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", orderID);
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@tableNumber", tableNumber);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Time", time);
                        command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        command.Parameters.AddWithValue("@Orders", orders);

                        command.ExecuteNonQuery();
                    }
                }

                // Refresh the new data grid view to show the new order
                ShowData("SELECT * FROM Orders", "Orders", ordersDataGridView);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid data. OrderID, CustomerID, and tableNumber should be integers. Date should be in the format 'yyyy-mm-dd'. Time should be in the format 'hh:mm:ss'. TotalPrice should be a decimal number.");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    // Violation of primary key. Handle Exception
                    MessageBox.Show("Order ID already exists. Please enter a unique Order ID.");
                }
                else if (ex.Number == 547)
                {
                    // Violation of foreign key. Handle Exception
                    MessageBox.Show("Customer ID does not exist. Please enter a valid Customer ID.");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            DateTimeLabel.Text = DateTime.Now.ToString();

            // Change the color and font of DateTimeLabel
            DateTimeLabel.ForeColor = Color.DarkBlue; // Change text color
            DateTimeLabel.BackColor = Color.LightGray; // Change background color
            DateTimeLabel.Font = new Font("Arial", 12, FontStyle.Bold); // Change font style
        }


        private void ShowOrdersBtn_Click(object sender, EventArgs e)
        {
            ShowData("SELECT * FROM Orders", "Orders", ordersDataGridView);
        }

        private void DateTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCustomerBtn_Click(object sender, EventArgs e)
        {
            // Check if the textboxes are empty
            if (string.IsNullOrWhiteSpace(UpdateCustomerIDTxt.Text) || string.IsNullOrWhiteSpace(UpdateFirstNameTxt.Text) || string.IsNullOrWhiteSpace(UpdateLastNameTxt.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            try
            {
                int customerID = int.Parse(UpdateCustomerIDTxt.Text);
                string firstName = UpdateFirstNameTxt.Text;
                string lastName = UpdateLastNameTxt.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Customer SET FirstName = @FirstName, LastName = @LastName WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);

                        command.ExecuteNonQuery();
                    }
                }

                // Refresh the data grid view to show the updated customer
                ShowData("SELECT * FROM Customer", "Customer", dataGridView);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid data. CustomerID should be an integer.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

    }
}
