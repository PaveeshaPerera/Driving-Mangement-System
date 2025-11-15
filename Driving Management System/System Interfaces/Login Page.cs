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
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string cs = "Data Source=NPN_PERERA ; Initial Catalog=finalprojectdb; Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);

                try
                {
                    con.Open();
                    string sql = "SELECT * FROM signuptbl WHERE username= @user AND password = @pw";
                    SqlCommand com = new SqlCommand(sql, con);

                    com.Parameters.AddWithValue("@user",textBox2.Text);
                    com.Parameters.AddWithValue("@pw",txtpass.Text);

                    SqlDataReader reader = com.ExecuteReader();

                    if (reader.Read())
                    {
                        Receptionist cources = new Receptionist();
                        cources.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }

                    reader.Close();
                    com.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
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

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                // Open Form1
                Form1 f1 = new Form1();
                f1.Show();

                // Close the current form
                this.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = showpass.Checked ? '\0' : '*';

        }
    }
}
