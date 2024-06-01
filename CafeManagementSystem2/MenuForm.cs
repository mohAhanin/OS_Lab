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
    public partial class MenuForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-F324UIT\\SQLEXPRESS;Initial Catalog=CAFEDB;Integrated Security=True";

        public MenuForm()
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
                    ((Button)c).Size = new Size(150, 50); // Set the size of the button
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

        private void insertMenuItemBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(menuItemNameTxtBox.Text) || string.IsNullOrEmpty(menuItemDescriptionTxtBox.Text) || string.IsNullOrEmpty(menuItemPriceTxtBox.Text))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            string query = "INSERT INTO Menu (MenuItemName, MenuItemDescription, Price) VALUES (@MenuItemName, @MenuItemDescription, @Price); SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MenuItemName", menuItemNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@MenuItemDescription", menuItemDescriptionTxtBox.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(menuItemPriceTxtBox.Text));

                    try
                    {
                        connection.Open();
                        int newMenuItemID = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show($"Menu item added successfully with ID {newMenuItemID}.");
                        // Clear the textboxes after successful insertion
                        menuItemNameTxtBox.Clear();
                        menuItemDescriptionTxtBox.Clear();
                        menuItemPriceTxtBox.Clear();
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

        private void updateMenuItemBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(menuItemIdTxtBox.Text) || string.IsNullOrEmpty(menuItemNameTxtBox.Text) || string.IsNullOrEmpty(menuItemDescriptionTxtBox.Text) || string.IsNullOrEmpty(menuItemPriceTxtBox.Text))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            string query = "UPDATE Menu SET MenuItemName = @MenuItemName, MenuItemDescription = @MenuItemDescription, Price = @Price WHERE MenuItemID = @MenuItemID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MenuItemID", menuItemIdTxtBox.Text);
                    cmd.Parameters.AddWithValue("@MenuItemName", menuItemNameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@MenuItemDescription", menuItemDescriptionTxtBox.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(menuItemPriceTxtBox.Text));

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Menu item updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No menu item found with the provided ID.");
                        }
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

        private void deleteMenuItemBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(menuItemIdTxtBox.Text))
            {
                MessageBox.Show("Please enter the ID of the menu item you want to delete.");
                return;
            }

            string query = "DELETE FROM Menu WHERE MenuItemID = @MenuItemID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MenuItemID", menuItemIdTxtBox.Text);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Menu item deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No menu item found with the provided ID.");
                        }
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

        private void menuItemIdTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Add any validation or formatting logic for the Menu Item ID textbox here
        }

        private void menuItemNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Add any validation or formatting logic for the Menu Item Name textbox here
        }

        private void menuItemDescriptionTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Add any validation or formatting logic for the Menu Item Description textbox here
        }

        private void menuItemPriceTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Add any validation or formatting logic for the Menu Item Price textbox here
        }
    }
}
