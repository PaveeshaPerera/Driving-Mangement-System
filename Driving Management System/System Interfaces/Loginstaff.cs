using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_Managment_System
{
    public partial class Loginstaff : Form
    {
        public Loginstaff()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA ; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                con.Open();
                // Query to retrieve role based on username and password
                string sql = "SELECT role FROM loginstaff WHERE username = @user AND password = @pw";
                SqlCommand com = new SqlCommand(sql, con);

                // Bind parameters
                com.Parameters.AddWithValue("@user", textBox2.Text); // Username textbox
                com.Parameters.AddWithValue("@pw", txtpass.Text);   // Password textbox

                SqlDataReader reader = com.ExecuteReader();

                if (reader.Read()) // If user exists
                {
                    string role = reader["role"].ToString(); // Retrieve the user's role

                    // Redirect based on the role
                    if (role == "Receptionist")
                    {
                        Receptionist receptionistForm = new Receptionist();
                        receptionistForm.Show();
                        this.Hide();
                    }
                    else if (role == "Director")
                    {
                        Director directorForm = new Director();
                        directorForm.Show();
                        this.Hide();
                    }
                    else if (role == "Instructor")
                    {
                        Instructor instructorForm = new Instructor();
                        instructorForm.Show();
                        this.Hide();
                    }

                    else if (role == "Manager")
                    {
                        Manager managerForm = new Manager();
                        managerForm.Show();
                        this.Hide();
                    }
                    else if (role == "Lecturer")
                    {
                        Lecturer lecturerForm = new Lecturer();
                        lecturerForm.Show();
                        this.Hide();
                    }
                    else if (role == "Student Cordinator")
                    {
                        stcordinator coordinatorForm = new stcordinator();
                        coordinatorForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Role not recognized. Please contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close();
                com.Dispose();
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

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Open Form1
                Form1 f1 = new Form1();
                f1.Show();

                // Close the current form
                this.Close();
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = showpass.Checked ? '\0' : '*';

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            staffsignup staffsignup = new staffsignup();
            staffsignup.Show();
            this.Hide();
        }
    }
}
