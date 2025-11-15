using System;       
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_Managment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //if (rbtnadmin.Checked)
            //{
            //    // Open the Admin Login interface
            //    Login_Page loginpage = new Login_Page();
            //    loginpage.Show();
            //    this.Hide();
            //}
            //else if (rbtnstudent.Checked)
            //{
            //    // Open the Student Login interface
            //    Login_Page loginpage = new Login_Page();
            //    loginpage.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Please select an option!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loginstaff loginstaff = new Loginstaff();   
            loginstaff.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login_Page loginstudent=new Login_Page();
            loginstudent.Show();
            this.Hide();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
