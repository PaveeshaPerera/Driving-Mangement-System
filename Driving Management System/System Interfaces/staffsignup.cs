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
    public partial class staffsignup : Form
    {
        public staffsignup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = showpass.Checked ? '\0' : '*';

        }

        private void staffsignup_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                // Validate if any textbox or combo box is empty
                if (string.IsNullOrEmpty(txtFullname.Text) ||
                    string.IsNullOrEmpty(comboRole.Text) || // Role combo box
                    string.IsNullOrEmpty(txtUsername.Text) ||
                    string.IsNullOrEmpty(txtPassword.Text) ||
                    string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    MessageBox.Show("All fields are required. Please fill in all the details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if passwords match
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match. Please try again.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Open connection
                con.Open();

                // Check if username already exists
                string checkSql = "SELECT COUNT(*) FROM loginstaff WHERE username = @username";
                SqlCommand checkCmd = new SqlCommand(checkSql, con);
                checkCmd.Parameters.AddWithValue("@username", txtUsername.Text);

                int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (userExists > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert new user into the database
                string sql = "INSERT INTO loginstaff (fullname, role, username, password, confirmpassword) " +
                             "VALUES (@fullname, @role, @username, @password, @confirmpassword)";

                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@fullname", txtFullname.Text);
                com.Parameters.AddWithValue("@role", comboRole.Text); // Combo box for role
                com.Parameters.AddWithValue("@username", txtUsername.Text);
                com.Parameters.AddWithValue("@password", txtPassword.Text);
                com.Parameters.AddWithValue("@confirmpassword", txtConfirmPassword.Text);

                int rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sign-up successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   Loginstaff loginPage = new Loginstaff(); 
                    loginPage.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Sign-up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
            }

        }
    }
}
