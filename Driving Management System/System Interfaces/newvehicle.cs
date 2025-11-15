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
    public partial class newvehicle : UserControl
    {
        public newvehicle()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";

        private DataSet ds;

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO tblvehicles (vehicle_id, v_licenseplate, transmission, model, availability) VALUES (@vid, @v_licenseplate, @transmission, @model, @availability)";
                    SqlCommand com = new SqlCommand(query, con);

                    com.Parameters.AddWithValue("@vid", txtVID.Text);
                    com.Parameters.AddWithValue("@v_licenseplate", txtLicPlate.Text);
                    com.Parameters.AddWithValue("@transmission", cmbTransmission.Text);
                    com.Parameters.AddWithValue("@model", txtModel.Text);
                    com.Parameters.AddWithValue("@availability", cmbAvailability.Text);

                    com.ExecuteNonQuery();
                    MessageBox.Show("Vehicle data added successfully.");
                    LoadVehicleData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Unable to add vehicle data.\n" + ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE tblvehicles SET v_licenseplate = @v_licenseplate, transmission = @transmission, model = @model, availability = @availability WHERE vehicle_id = @vid";
                    SqlCommand com = new SqlCommand(query, con);

                    com.Parameters.AddWithValue("@vid", txtVID.Text);
                    com.Parameters.AddWithValue("@v_licenseplate", txtLicPlate.Text);
                    com.Parameters.AddWithValue("@transmission", cmbTransmission.Text);
                    com.Parameters.AddWithValue("@model", txtModel.Text);
                    com.Parameters.AddWithValue("@availability", cmbAvailability.Text);

                    com.ExecuteNonQuery();
                    MessageBox.Show("Vehicle data updated successfully.");
                    LoadVehicleData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Unable to edit vehicle data.\n" + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM tblvehicles WHERE vehicle_id = @vid";
                    SqlCommand com = new SqlCommand(query, con);

                    com.Parameters.AddWithValue("@vid", txtVID.Text);

                    com.ExecuteNonQuery();
                    MessageBox.Show("Vehicle data deleted successfully.");
                    LoadVehicleData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Unable to delete vehicle data.\n" + ex.Message);
            }
        }

        private void LoadVehicleData()
        {
            string cs = "Data Source=NPN_PERERA; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM tblvehicles ";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataAdapter da = new SqlDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadVehicleData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA ; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //define a command with SQL statement 
            string sql = "SELECT * FROM tblvehicles WHERE vehicle_id = @vid"; //sk is a variable
            SqlCommand com = new SqlCommand(sql, con); //pass both the sql and the connection parameters
            com.Parameters.AddWithValue("@sid", this.txtVID.Text);

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)

            {
                //bind data with controls
                this.txtVID.Text = dr.GetValue(0).ToString();
                this.txtLicPlate.Text = dr.GetValue(1).ToString();
                this.cmbTransmission.Text = dr.GetValue(2).ToString();
                this.txtModel.Text = dr.GetValue(3).ToString(); //0,1,2,3 are the array numbers
                this.cmbAvailability.Text = dr.GetValue(4).ToString();
                

            }

            else
            {
                MessageBox.Show("No Records Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

