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
    public partial class newreceipt : UserControl
    {
        public newreceipt()
        {
            InitializeComponent();
        }
        string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // LOAD BUTTON FUNCTIONALITY
            
                using (SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        string query = "SELECT * FROM ReceiptData";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewReceipt.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            // SEARCH BUTTON FUNCTIONALITY
              if (string.IsNullOrWhiteSpace(txtReceiptID.Text))
                {
                    MessageBox.Show("Please enter a Receipt ID!");
                    return;
                }

                using (SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        con.Open();
                        string query = "SELECT * FROM ReceiptData WHERE ReceiptID = @ReceiptID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ReceiptID", txtReceiptID.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridViewReceipt.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No record found for the provided Receipt ID!");
                            dataGridViewReceipt.DataSource = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            // ADD BUTTON FUNCTIONALITY
              if (ValidateInputs())
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        try
                        {
                            con.Open();
                            string query = "INSERT INTO ReceiptData (ReceiptID,SID, InvoiceID, Course, CourseFee, ThisPayment, Total, RemainingBalance, PaymentMethod) VALUES (@ReceiptID, @SID, @InvoiceID, @Course, @CourseFee, @ThisPayment, @Total, @RemainingBalance, @PaymentMethod)";
                            SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@ReceiptID", txtReceiptID.Text);
                        cmd.Parameters.AddWithValue("@SID", txtSID.Text);
                            cmd.Parameters.AddWithValue("@InvoiceID", txtInvoiceID.Text);
                            cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                            cmd.Parameters.AddWithValue("@CourseFee", decimal.Parse(txtCourseFee.Text));
                            cmd.Parameters.AddWithValue("@ThisPayment", decimal.Parse(txtThisPayment.Text));
                            cmd.Parameters.AddWithValue("@Total", decimal.Parse(txtTotal.Text));
                            cmd.Parameters.AddWithValue("@RemainingBalance", decimal.Parse(txtRemainingBalance.Text));
                            cmd.Parameters.AddWithValue("@PaymentMethod", GetPaymentMethod());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record added successfully!");
                            button1.PerformClick();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                }
            
        }

        private string GetPaymentMethod()
        {
            if (radioButton1.Checked)
                return "Cash";
            else if (radioButton2.Checked)
                return "Credit Card";
            else if (radioButton3.Checked)
                return "Debit Card";
            else
                return string.Empty; // Return empty string if no option is selected
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtSID.Text) || string.IsNullOrWhiteSpace(txtInvoiceID.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text) || string.IsNullOrWhiteSpace(txtCourseFee.Text) ||
                string.IsNullOrWhiteSpace(txtThisPayment.Text) || string.IsNullOrWhiteSpace(txtTotal.Text) ||
                string.IsNullOrWhiteSpace(txtRemainingBalance.Text))
            {
                MessageBox.Show("All fields must be filled out!");
                return false;
            }
            return true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            // EDIT BUTTON FUNCTIONALITY
            
                if (ValidateInputs())
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        try
                        {
                            con.Open();
                            string query = "UPDATE ReceiptData SET SID=@SID, InvoiceID=@InvoiceID, Course=@Course, CourseFee=@CourseFee, ThisPayment=@ThisPayment, Total=@Total, RemainingBalance=@RemainingBalance, PaymentMethod=@PaymentMethod WHERE ReceiptID=@ReceiptID";
                            SqlCommand cmd = new SqlCommand(query, con);

                            cmd.Parameters.AddWithValue("@ReceiptID", txtReceiptID.Text);
                            cmd.Parameters.AddWithValue("@SID", txtSID.Text);
                            cmd.Parameters.AddWithValue("@InvoiceID", txtInvoiceID.Text);
                            cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                            cmd.Parameters.AddWithValue("@CourseFee", decimal.Parse(txtCourseFee.Text));
                            cmd.Parameters.AddWithValue("@ThisPayment", decimal.Parse(txtThisPayment.Text));
                            cmd.Parameters.AddWithValue("@Total", decimal.Parse(txtTotal.Text));
                            cmd.Parameters.AddWithValue("@RemainingBalance", decimal.Parse(txtRemainingBalance.Text));
                            cmd.Parameters.AddWithValue("@PaymentMethod", GetPaymentMethod());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record updated successfully!");
                            button1.PerformClick();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                }
            
        }
    }
}
