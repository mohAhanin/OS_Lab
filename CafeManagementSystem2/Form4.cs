using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace CafeManagementSystem2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

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
                    ((Button)c).Size = new Size(200, 50); // Set the size of the button
                }
                else if (c is Label)
                {
                    ((Label)c).Font = new Font("Arial", 12, FontStyle.Bold);
                    ((Label)c).ForeColor = Color.DarkBlue;
                    ((Label)c).AutoSize = false; // This allows you to set the size of the label
                    ((Label)c).Size = new Size(200, 30); // Set the size of the label
                }
                else if (c is TextBox)
                {
                    ((TextBox)c).Font = new Font("Arial", 10);
                    ((TextBox)c).ForeColor = Color.DarkBlue;
                    ((TextBox)c).Size = new Size(200, 30); // Set the size of the textbox
                }
            }
        }


        private string connectionString = "Data Source=DESKTOP-F324UIT\\SQLEXPRESS;" +
            "Initial Catalog=CAFEDB;" +
            "Integrated Security=True";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Check if the entered username and password match the fixed credentials
            if (username == "1" && password == "1")
            {
                // Login successful, open Form1
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}

