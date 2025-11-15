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
    
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }
        

        private void Cources_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
             
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            course staffregister = new course();
            staffregister.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(staffregister);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            newinvoice invoice = new newinvoice();
            invoice.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(invoice);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            mainpanel.Controls.Clear();
            newreceipt newreceipt= new  newreceipt();
           newreceipt.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(newreceipt);
        }

        private void label26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            staffregister newregister = new staffregister();
            newregister.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(newregister);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            newschedule newschedule = new newschedule();
            newschedule.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(newschedule);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            viewvehicleinfo newvehicle = new viewvehicleinfo();
            newvehicle.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(newvehicle);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            newfeedback newfeedback = new newfeedback();
            newfeedback.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(newfeedback);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            changepassword changepassword = new changepassword();
            changepassword.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(changepassword);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            addleaves addleaves = new addleaves();
            addleaves.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(addleaves);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Close the current form and redirect to the login form
                this.Hide();
               Login_Page loginForm = new Login_Page();
                loginForm.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            newschedule newschedule= new newschedule();
            newschedule.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(newschedule);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            newfeedback newfeedback = new newfeedback();
            newfeedback.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(newfeedback);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            addleaves addleaves = new addleaves();
            addleaves.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(addleaves);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
