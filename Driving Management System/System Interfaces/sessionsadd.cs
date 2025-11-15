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
    public partial class sessionsadd : UserControl
    {
        public sessionsadd()
        {
            InitializeComponent();
        }
        string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInstructorName.Text) || string.IsNullOrWhiteSpace(txtVehicle.Text))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO SessionData (SessionID,InstructorName, Vehicle, Date, StartingTime, EndingTime) VALUES (@SessionID, @InstructorName, @Vehicle, @Date, @StartingTime, @EndingTime)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SessionID", txtSessionID.Text);
                    cmd.Parameters.AddWithValue("@InstructorName", txtInstructorName.Text);
                    cmd.Parameters.AddWithValue("@Vehicle", txtVehicle.Text);
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@StartingTime", dtpStartTime.Value);
                    cmd.Parameters.AddWithValue("@EndingTime", dtpEndTime.Value);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Session added successfully!");
                    LoadData();
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
            if (string.IsNullOrWhiteSpace(txtInstructorName.Text) || string.IsNullOrWhiteSpace(txtVehicle.Text) || string.IsNullOrWhiteSpace(txtSessionID.Text))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE SessionData SET InstructorName = @InstructorName, Vehicle = @Vehicle, Date = @Date, StartingTime = @StartingTime, EndingTime = @EndingTime WHERE SessionID = @SessionID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SessionID", txtSessionID.Text);
                    cmd.Parameters.AddWithValue("@InstructorName", txtInstructorName.Text);
                    cmd.Parameters.AddWithValue("@Vehicle", txtVehicle.Text);
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@StartingTime", dtpStartTime.Value);
                    cmd.Parameters.AddWithValue("@EndingTime", dtpEndTime.Value);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Session updated successfully!");
                    LoadData();
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
            if (string.IsNullOrWhiteSpace(txtSessionID.Text))
            {
                MessageBox.Show("Session ID is required to delete a record!");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM SessionData WHERE SessionID = @SessionID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SessionID", txtSessionID.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Session deleted successfully!");
                    LoadData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSessionID.Text))
            {
                MessageBox.Show("Please enter a Session ID to search.");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM SessionData WHERE SessionID = @SessionID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SessionID", txtSessionID.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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

        private void button6_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    string query = "SELECT SessionID, InstructorName, Vehicle, Date, StartingTime, EndingTime FROM SessionData";
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

        private void ClearForm()
        {
            txtSessionID.Clear();
            txtInstructorName.Clear();
            txtVehicle.Clear();
            dtpDate.Value = DateTime.Now;
            dtpStartTime.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now;
        }
    }
}
