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

namespace Driving_Managment_System
{
    public partial class changepassword : UserControl
    {
        public changepassword()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            oldpassword.PasswordChar ='\0' ;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            newpassword.PasswordChar ='\0' ;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            conpassword.PasswordChar ='\0' ;    
        }

        private void button1_Click(object sender, EventArgs e)

        {

            string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";
            

            string oldPassword = oldpassword.Text;
            string newPassword = newpassword.Text;
            string confirmPassword = conpassword.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword.Length < 6 || newPassword.Contains(" "))
            {
                MessageBox.Show("Password must be at least six characters long and cannot contain spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                string query = "SELECT password FROM signuptbl WHERE username = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", "your_logged_in_username_here");

                string currentPassword = (string)command.ExecuteScalar();

                if (currentPassword != oldPassword)
                {
                    MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                query = "UPDATE Users SET password = @newPassword WHERE username = @username";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@newPassword", newPassword);
                command.Parameters.AddWithValue("@username", "your_logged_in_username_here");

                command.ExecuteNonQuery();

                MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";
          

            string oldUsername = oldusername.Text;
            string newUsername = newusername.Text;
            string confirmUsername = conusername.Text;

            if (newUsername != confirmUsername)
            {
                MessageBox.Show("New username and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newUsername.Length < 5 || newUsername.Contains(" "))
            {
                MessageBox.Show("Username must be at least 5 characters long and cannot contain spaces or special characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                string query = "SELECT username FROM signuptbl WHERE username = @oldUsername";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@oldUsername", oldUsername);

                object result = command.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Old username does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                query = "UPDATE signuptbl SET username = @newUsername WHERE username = @oldUsername";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@newUsername", newUsername);
                command.Parameters.AddWithValue("@oldUsername", oldUsername);

                command.ExecuteNonQuery();

                MessageBox.Show("Username updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void label10_Click_1(object sender, EventArgs e)
        {

              // Toggle the password visibility
                if (oldpassword.UseSystemPasswordChar)
                {
                    // Show password
                    oldpassword.UseSystemPasswordChar = false;
                    lbl.Text = "🙈"; // Change emoji to "hide" icon
                }
                else
                {
                    // Hide password
                    oldpassword.UseSystemPasswordChar = true;
                    lbl.Text = "👁️"; // Change emoji back to "show" icon
                }


        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            // Toggle the password visibility
            if (newpassword.UseSystemPasswordChar)
            {
                // Show password
                newpassword.UseSystemPasswordChar = false;
                lblshow.Text = "🙈"; // Change emoji to "hide" icon
            }
            else
            {
                // Hide password
                newpassword.UseSystemPasswordChar = true;
                lblshow.Text = "👁️"; // Change emoji back to "show" icon
            }
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            // Toggle the password visibility
            if (conpassword.UseSystemPasswordChar)
            {
                // Show password
                conpassword.UseSystemPasswordChar = false;
                lblsh.Text = "🙈"; // Change emoji to "hide" icon
            }
            else
            {
                // Hide password
                conpassword.UseSystemPasswordChar = true;
                lblsh.Text = "👁️"; // Change emoji back to "show" icon
            }
        }

        private void newpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
