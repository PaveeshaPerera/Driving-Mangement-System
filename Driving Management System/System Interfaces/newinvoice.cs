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
    public partial class newinvoice : UserControl
    {
        public newinvoice()
        {
            InitializeComponent();
        }
        DataSet ds;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            // Insert invoice details into the database
            string sql = "INSERT INTO tblinvoice ( student_id, name, issue_date, due_date, course_name, course_fee, discount) " +
                         "VALUES ( @student_id, @student_name, @issue_date, @due_date, @course_name, @course_fee, @discount)";
            SqlCommand com = new SqlCommand(sql, con);

            // Add values from text boxes
            com.Parameters.AddWithValue("@student_id", txtStudentID.Text);
            com.Parameters.AddWithValue("@student_name", txtStudentName.Text);
            com.Parameters.AddWithValue("@issue_date", txtIssueDate.Value);
            com.Parameters.AddWithValue("@due_date", txtDueDate.Value);
            com.Parameters.AddWithValue("@course_name", txtCourseName.Text);
            com.Parameters.AddWithValue("@course_fee", txtCourseFee.Text);
            com.Parameters.AddWithValue("@discount", txtDiscount.Text);

            int ret = com.ExecuteNonQuery();
            MessageBox.Show($"Invoice Generated Successfully! Rows Inserted: {ret}", "Information");
            con.Close();

            // Reload DataGridView with the updated data
            LoadInvoices();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            // Update the selected invoice
            string sql = "UPDATE tblinvoice SET  name=@student_name, issue_date=@issue_date, due_date=@due_date, " +
                         "course_name=@course_name, course_fee=@course_fee, discount=@discount WHERE student_id=@student_id";
            SqlCommand com = new SqlCommand(sql, con);

            // Add values from text boxes
            com.Parameters.AddWithValue("@student_id", txtStudentID.Text);
            com.Parameters.AddWithValue("@student_name", txtStudentName.Text);
            com.Parameters.AddWithValue("@issue_date", txtIssueDate.Value);
            com.Parameters.AddWithValue("@due_date", txtDueDate.Value);
            com.Parameters.AddWithValue("@course_name", txtCourseName.Text);
            com.Parameters.AddWithValue("@course_fee", txtCourseFee.Text);
            com.Parameters.AddWithValue("@discount", txtDiscount.Text);

            int ret = com.ExecuteNonQuery();
            MessageBox.Show($"Invoice Updated Successfully! Rows Updated: {ret}", "Information");
            con.Close();

            // Reload DataGridView with the updated data
            LoadInvoices();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoadInvoices();


        }
        private void LoadInvoices()
        {
            string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM tblinvoice";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataAdapter da = new SqlDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells["student_id"].Value.ToString();
                txtStudentName.Text = row.Cells["student_name"].Value.ToString();
                txtIssueDate.Text = row.Cells["issue_date"].Value.ToString();
                txtDueDate.Text = row.Cells["due_date"].Value.ToString();
                txtCourseName.Text = row.Cells["course_name"].Value.ToString();
                txtCourseFee.Text = row.Cells["course_fee"].Value.ToString();
                txtDiscount.Text = row.Cells["discount"].Value.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCourseFee.Clear();
            txtDiscount.Clear();    
            txtCourseName.Clear();
            txtDueDate= null;
            txtIssueDate = null;
            txtStudentID.Clear();
            txtStudentName.Clear();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA ; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //define a command with SQL statement 
            string sql = "SELECT * FROM tblinvoice WHERE student_id=@sid"; //sk is a variable
            SqlCommand com = new SqlCommand(sql, con); //pass both the sql and the connection parameters
            com.Parameters.AddWithValue("@sid", this.txtStudentID.Text);

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)

            {
                //bind data with controls
                this.txtStudentID.Text = dr.GetValue(0).ToString();
                this.txtStudentName.Text = dr.GetValue(1).ToString();
                this.txtIssueDate.Text = dr.GetValue(2).ToString();
                this.txtDueDate.Text = dr.GetValue(3).ToString(); //0,1,2,3 are the array numbers
                this.txtCourseName.Text = dr.GetValue(4).ToString();
                this.txtCourseFee.Text = dr.GetValue(5).ToString();
                this.txtDiscount.Text = dr.GetValue(6).ToString();


            }

            else
            {
                MessageBox.Show("No Records Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
