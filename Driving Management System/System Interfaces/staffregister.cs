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
    public partial class staffregister : UserControl
    {
        public staffregister()
        {
            InitializeComponent();
        }


        DataSet ds;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);

            con.Open();



            string sql = "INSERT INTO tblstaff (staffID, name, contact, nic, dob, hire_date, email, staff_role) VALUES (@staffID, @name, @contact, @nic, @dob, @hire_date, @email, @staff_role)";

            SqlCommand com = new SqlCommand(sql, con);



            com.Parameters.AddWithValue("@staffID", txtStaffID.Text);

            com.Parameters.AddWithValue("@name", txtName.Text);

            com.Parameters.AddWithValue("@contact", txtContact.Text);

            com.Parameters.AddWithValue("@nic", txtNIC.Text);

            com.Parameters.AddWithValue("@dob", dtpDOB.Value);

            com.Parameters.AddWithValue("@hire_date", dtpHireDate.Value);

            com.Parameters.AddWithValue("@email", txtEmail.Text);

            com.Parameters.AddWithValue("@staff_role", cmbRole.SelectedItem.ToString());
            int ret = com.ExecuteNonQuery();

            MessageBox.Show("No of records inserted: " + ret, "Information");

            con.Close();



        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);

            con.Open();



            string sql = "UPDATE tblstaff SET name=@name, contact=@contact, nic=@nic, dob=@dob, hire_date=@hire_date, email=@email, staff_role=@staff_role WHERE staffID=@staffID";

            SqlCommand com = new SqlCommand(sql, con);



            com.Parameters.AddWithValue("@staffID", txtStaffID.Text);

            com.Parameters.AddWithValue("@name", txtName.Text);

            com.Parameters.AddWithValue("@contact", txtContact.Text);

            com.Parameters.AddWithValue("@nic",txtNIC.Text);

            com.Parameters.AddWithValue("@dob", dtpDOB.Value);

            com.Parameters.AddWithValue("@hire_date", dtpHireDate.Value);

            com.Parameters.AddWithValue("@email", txtEmail.Text);
            com.Parameters.AddWithValue("@staff_role", cmbRole.SelectedItem.ToString());


            int ret = com.ExecuteNonQuery();

            MessageBox.Show("No of records updated: " + ret, "Information");

            con.Close();
           

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);

            con.Open();



            string sql = "DELETE FROM tblstaff WHERE staffID=@staffID";

            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@staffID", txtStaffID.Text);



            DialogResult msg = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)

            {

                int ret = com.ExecuteNonQuery();

                MessageBox.Show("No of records deleted: " + ret, "Information");
            }



            con.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);

            con.Open();



            string sql = "SELECT * FROM tblstaff";

            SqlCommand com = new SqlCommand(sql, con);

            SqlDataAdapter dap = new SqlDataAdapter(com);



            ds = new DataSet();

            dap.Fill(ds);



            dataGridView1.DataSource = ds.Tables[0];

            con.Close();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtStaffID.Clear();

            txtName.Clear();

            txtContact.Clear();

            txtNIC.Clear();

            dtpDOB.Value = DateTime.Now;

            dtpHireDate.Value = DateTime.Now;

            txtEmail.Clear();

            cmbRole.Enabled = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txtStaffID.Text = dataGridView1[0, row].Value.ToString();

            txtName.Text = dataGridView1[1, row].Value.ToString();

            txtContact.Text = dataGridView1[2, row].Value.ToString();

            txtNIC.Text = dataGridView1[3, row].Value.ToString();

            dtpDOB.Value = Convert.ToDateTime(dataGridView1[4, row].Value);

            dtpHireDate.Value = Convert.ToDateTime(dataGridView1[5, row].Value);

            txtEmail.Text = dataGridView1[6, row].Value.ToString();

            cmbRole.Text = dataGridView1[7, row].Value.ToString();


        }
    }
}
