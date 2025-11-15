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
    public partial class newfeedback : UserControl
    {
        public newfeedback()
        {
            InitializeComponent();
        }
        private string cs= "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";


        private void button4_Click(object sender, EventArgs e)
        {
              using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "SELECT FeedbackID, FeedbackMessage, Rating, AdminResponse FROM Feedback";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvFeedback.DataSource = dt;
                    }
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (dgvFeedback.SelectedRows.Count > 0)
                {
                    int feedbackId = Convert.ToInt32(dgvFeedback.SelectedRows[0].Cells["FeedbackID"].Value);
                    string adminResponse = txtResponse.Text;

                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        string query = "UPDATE Feedback SET AdminResponse = @AdminResponse WHERE FeedbackID = @FeedbackID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@AdminResponse", adminResponse);
                            cmd.Parameters.AddWithValue("@FeedbackID", feedbackId);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Response updated successfully.");
                            LoadFeedback(); // Refresh the DataGridView
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a feedback to respond to.");
                }
            
        }

        private void LoadFeedback()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT FeedbackID, FeedbackMessage, Rating, AdminResponse FROM Feedback";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvFeedback.DataSource = dt;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFeedbackID.Clear();
                txtResponse.Clear();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
                if (string.IsNullOrWhiteSpace(txtFeedbackID.Text))
                {
                    MessageBox.Show("Please enter a Feedback ID to search!");
                    return;
                }

                using (SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        string query = "SELECT * FROM Feedback WHERE FeedbackID = @FeedbackID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@FeedbackID", txtFeedbackID.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtResponse.Text = reader["Response"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Feedback not found!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrWhiteSpace(txtFeedbackID.Text) || string.IsNullOrWhiteSpace(txtResponse.Text))
                {
                    MessageBox.Show("All fields are required!");
                    return;
                }

                using (SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        string query = "INSERT INTO Feedback (FeedbackID, Response) VALUES (@FeedbackID, @Response)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@FeedbackID", txtFeedbackID.Text);
                        cmd.Parameters.AddWithValue("@Response", txtResponse.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Feedback added successfully!");
                    button4.PerformClick(); // Refresh data grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            
        }
    }
}
