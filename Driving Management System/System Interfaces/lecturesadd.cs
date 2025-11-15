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
    public partial class lecturesadd : UserControl
    {
        public lecturesadd()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";

        DataSet ds;
        int i = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string sql = "SELECT * FROM tblLecture";
                    SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                    ds = new DataSet();
                    dap.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string sql = "INSERT INTO tblLecture (LectureID, LecturerName, Date, StartTime, EndTime) VALUES (@lecID, @lecname, @date, @start, @end)";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@lecid", txtLectureID.Text);
                    cmd.Parameters.AddWithValue("@lecname", txtLecturerName.Text);
                    cmd.Parameters.AddWithValue("@date", date.Value);
                    cmd.Parameters.AddWithValue("@start", txtStartTime.Text);
                    cmd.Parameters.AddWithValue("@end", txtEndTime.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows + " record(s) added.");
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
             // Updates an existing lecture record in the database.
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                con.Open(); // Opens the database connection.
                string sql = "UPDATE tblLecture SET LecturerName= @lecname, Date = @date, StartTime= @start, EndTime = @end WHERE LectureID = @lecID"; // SQL query for updating data.
                SqlCommand cmd = new SqlCommand(sql, con); // Prepares the SQL command.

                // Adds parameter values to prevent SQL injection.
                cmd.Parameters.AddWithValue("@lecID", txtLectureID.Text); // lecID from input.
                cmd.Parameters.AddWithValue("@lecname", txtLecturerName.Text); // lecname from input.
                cmd.Parameters.AddWithValue("@date", date.Value); // date from date picker.
                cmd.Parameters.AddWithValue("@start", txtStartTime.Text); // start from input.
                cmd.Parameters.AddWithValue("@end", txtEndTime.Text); // end from input.

                int rows = cmd.ExecuteNonQuery(); // Executes the query and returns the number of rows affected.
                MessageBox.Show(rows + " record(s) updated."); // Displays success message.

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                // Deletes a lecture record from the database.
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open(); // Opens the database connection.
                    string sql = "DELETE FROM tblLecture WHERE LectureID = @lecID"; // SQL query for deleting data.
                    SqlCommand cmd = new SqlCommand(sql, con); // Prepares the SQL command.
                    cmd.Parameters.AddWithValue("@lecID", txtLectureID.Text); // lecID from input.

                    // Asks for confirmation before deleting the record.
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        int rows = cmd.ExecuteNonQuery(); // Executes the query and returns the number of rows affected.
                        MessageBox.Show(rows + " record(s) deleted."); // Displays success message.
                    }
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Searches for a specific lecture record in the database by lecID.
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open(); // Opens the database connection.
                string sql = "SELECT * FROM tblLecture WHERE LectureID = @lecID"; // SQL query for searching data.
                SqlCommand cmd = new SqlCommand(sql, con); // Prepares the SQL command.
                cmd.Parameters.AddWithValue("@lecID", txtLectureID.Text); // lecID from input.

                SqlDataReader dr = cmd.ExecuteReader(); // Executes the query and reads the result.
                if (dr.Read()) // Checks if a record is found.
                {
                    // Populates the form fields with the retrieved data.
                    txtLecturerName.Text = dr["LecturerName"].ToString();
                    date.Value = Convert.ToDateTime(dr["Date"]);
                    txtStartTime.Value = DateTime.Today.Add((TimeSpan)dr["StartTime"]);
                    txtEndTime.Value = DateTime.Today.Add((TimeSpan)dr["EndTime"]);
                }
                else
                {
                    MessageBox.Show("No record found."); // Displays a message if no record is found.
                }
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                // Clears all input fields in the form.
                txtLectureID.Clear();
                txtLecturerName.Clear();
            txtStartTime.Value = DateTime.Now; 
            txtEndTime.Value = DateTime.Now;
            date.Value = DateTime.Now; // Resets the date picker to the current date.
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                // Populates form fields with data from the selected row in the DataGridView.
                if (e.RowIndex >= 0) // Ensures a valid row is selected.
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // Gets the selected row.
                    txtLectureID.Text = row.Cells["lecID"].Value.ToString();
                    txtLecturerName.Text = row.Cells["lecname"].Value.ToString();
                    date.Value = Convert.ToDateTime(row.Cells["date"].Value);
                    txtStartTime.Text = row.Cells["start"].Value.ToString();
                    txtEndTime.Text = row.Cells["end"].Value.ToString();
                }
            
        }
    }
}
