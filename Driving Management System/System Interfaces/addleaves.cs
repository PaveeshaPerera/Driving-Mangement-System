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
    public partial class addleaves : UserControl
    {
        public addleaves()
        {
            InitializeComponent();
        }
        string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (cmbStaffID.Text == "" || cmbLeaveType.Text == "" || txtLeaveReason.Text == "" || dtpLeaveDate.Text == "")
                {
                    MessageBox.Show("All fields are required!");
                    return;
                }

                using (SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        string query = "INSERT INTO LeaveDetails (StaffID, LeaveDate, LeaveType, LeaveReason) VALUES (@StaffID, @LeaveDate, @LeaveType, @LeaveReason)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@StaffID", cmbStaffID.Text);
                        cmd.Parameters.AddWithValue("@LeaveDate", dtpLeaveDate.Value);
                        cmd.Parameters.AddWithValue("@LeaveType", cmbLeaveType.Text);
                        cmd.Parameters.AddWithValue("@LeaveReason", txtLeaveReason.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Leave details added successfully!");
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

                using (SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        string query = "UPDATE LeaveDetails SET LeaveDate = @LeaveDate, LeaveType = @LeaveType, LeaveReason = @LeaveReason WHERE StaffID = @StaffID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@StaffID", cmbStaffID.Text);
                        cmd.Parameters.AddWithValue("@LeaveDate", dtpLeaveDate.Value);
                        cmd.Parameters.AddWithValue("@LeaveType", cmbLeaveType.Text);
                        cmd.Parameters.AddWithValue("@LeaveReason", txtLeaveReason.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Leave details updated successfully!");
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
              using (SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        string query = "SELECT * FROM LeaveDetails";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                ClearForm();
                dataGridView1.DataSource = null;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                ClearForm();

        }

        private void ClearForm()
        {
            cmbStaffID.Clear();
            dtpLeaveDate.Value = DateTime.Now;
            cmbLeaveType.SelectedIndex = -1;
            txtLeaveReason.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
