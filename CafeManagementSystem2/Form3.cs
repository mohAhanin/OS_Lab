using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CafeManagementSystem2
{
    public partial class Form3 : Form
    {
        private string connectionString = "Data Source=DESKTOP-F324UIT\\SQLEXPRESS;Initial Catalog=CAFEDB;Integrated Security=True";
        private SqlConnection conn;
        private SqlDataAdapter da;
        private DataTable dt;

        public Form3()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            addStaffbtn.Click += AddStaff_Click;

            // Set the background color of the form
            this.BackColor = Color.LightBlue;

            // Set the font, color, and size of all the buttons and labels
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Font = new Font("Arial", 12, FontStyle.Bold);
                    ((Button)c).ForeColor = Color.White;
                    ((Button)c).BackColor = Color.DarkBlue;
                    ((Button)c).Size = new Size(100, 50); // Set the size of the button
                }
                else if (c is Label)
                {
                    ((Label)c).Font = new Font("Arial", 12, FontStyle.Bold);
                    ((Label)c).ForeColor = Color.DarkBlue;
                    ((Label)c).AutoSize = false; // This allows you to set the size of the label
                    ((Label)c).Size = new Size(100, 20); // Set the size of the label
                }
                else if (c is TextBox)
                {
                    ((TextBox)c).Font = new Font("Arial", 10);
                    ((TextBox)c).ForeColor = Color.DarkBlue;
                    ((TextBox)c).Size = new Size(100, 30); // Set the size of the textbox
                }
            }

            // Set the font and color of the DataGridView
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.ForeColor = Color.DarkBlue;
            dataGridView1.BackgroundColor = Color.White;
        }

        private void ShowStaff_Click(object sender, EventArgs e)
        {
            ShowData("SELECT * FROM Staff", "Staff", dataGridView1);
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StaffIDtext.Text) || string.IsNullOrEmpty(StaffFirstNametext.Text) || string.IsNullOrEmpty(StaffLastNametext.Text))
            {
                MessageBox.Show("Please fill all the text boxes.");
                return;
            }

            string query = "INSERT INTO Staff (StaffID, StaffName, StaffLastName) VALUES (@StaffID, @StaffName, @StaffLastName)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StaffID", StaffIDtext.Text);
                    cmd.Parameters.AddWithValue("@StaffName", StaffFirstNametext.Text);
                    cmd.Parameters.AddWithValue("@StaffLastName", StaffLastNametext.Text);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Staff added successfully.");
                        ShowStaff_Click(null, EventArgs.Empty); // Refresh the dataGridView1 after adding a new staff
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred. " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
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

        private void Staffbtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT StaffID, StaffName, StaffLastName FROM Staff";
            ShowData(query, "Staff", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Your code here
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Your code here
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your code here
        }

        private void StaffFirstNamelabel_Click(object sender, EventArgs e)
        {
            // Your code here
        }

        private void StaffLastNamelabel_Click(object sender, EventArgs e)
        {
            // Your code here
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StaffIDUpdateText.Text) || string.IsNullOrEmpty(StaffFirstNameUpdateText.Text) || string.IsNullOrEmpty(StaffLastNameUpdateText.Text))
            {
                MessageBox.Show("Please fill all the text boxes.");
                return;
            }

            string query = "UPDATE Staff SET StaffName = @StaffName, StaffLastName = @StaffLastName WHERE StaffID = @StaffID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StaffID", StaffIDUpdateText.Text);
                    cmd.Parameters.AddWithValue("@StaffName", StaffFirstNameUpdateText.Text);
                    cmd.Parameters.AddWithValue("@StaffLastName", StaffLastNameUpdateText.Text);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Staff updated successfully.");
                        ShowStaff_Click(null, EventArgs.Empty); // Refresh the dataGridView1 after updating staff
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred. " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void deleteStaffbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StaffIDDeleteText.Text))
            {
                MessageBox.Show("Please enter the ID of the staff member you want to delete.");
                return;
            }

            string query = "DELETE FROM Staff WHERE StaffID = @StaffID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StaffID", StaffIDDeleteText.Text);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No staff member found with the provided ID.");
                        }
                        ShowStaff_Click(null, EventArgs.Empty); // Refresh the dataGridView1 after deleting staff
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred. " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        
    }
}

