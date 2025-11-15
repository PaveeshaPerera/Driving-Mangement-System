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
    public partial class course : UserControl
    {
        public course()
        {
            InitializeComponent();
        }
        DataSet ds;

        private void btnadd_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA ; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand com = new SqlCommand(cs);
            con.Open();

            //define a command
            string sql = "INSERT INTO tblcourse (cid,name,fee, duration,descrip,discount) VALUES (@cid, @name, @fee, @duration, @descrip,@discount)"; // add @ to indicate variable
            com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@cid", this.txtcourseid.Text);  //AddWithValue-Combines parameter creation and value assignment in one step
            com.Parameters.AddWithValue("@name", this.txtname.Text);
            com.Parameters.AddWithValue("@fee", this.txtfee.Text);
            com.Parameters.AddWithValue("@duration", this.txtduration.Text);
            com.Parameters.AddWithValue("@descrip", this.txtdescrip.Text);
            com.Parameters.AddWithValue("@discount", this.txtdiscount.Text);


            //excecute the program
            int ret = com.ExecuteNonQuery();
            MessageBox.Show("No of records inserted:" + ret, "Information");

            //disconnect from SQL server
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // create a connection
            string cs = "Data Source=NPN_PERERA ; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //define a command
            String sql = "DELETE FROM tblcourse WHERE cid=@cid";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@cid", this.txtcourseid.Text);

            //excute the command
            DialogResult msg = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                //excecute the command
                int ret = com.ExecuteNonQuery(); //ret means creating a variable to get the number of rows affected
                MessageBox.Show("No of records deleted: " + ret, "Information");
            }

            //discount from SQL server
            con.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA ; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //define a command with SQL statement 
            string sql = "SELECT * FROM tblcourse WHERE cid=@cid"; //sk is a variable
            SqlCommand com = new SqlCommand(sql, con); //pass both the sql and the connection parameters
            com.Parameters.AddWithValue("@cid", this.txtcourseid.Text);

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)

            {
                //bind data with controls
                this.txtcourseid.Text = dr.GetValue(0).ToString();
                this.txtname.Text = dr.GetValue(1).ToString();
                this.txtfee.Text = dr.GetValue(2).ToString();
                this.txtduration.Text = dr.GetValue(3).ToString(); //0,1,2,3 are the array numbers
                this.txtdescrip.Text = dr.GetValue(4).ToString();
                this.txtdiscount.Text = dr.GetValue(5).ToString();

            }

            else
            {
                MessageBox.Show("No Records Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA ; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //define a command
            String sql = "UPDATE tblcourse SET name=@name, fee=@fee, duration=@duration, descrip= @descrip, discount=@discount WHERE cid=@cid";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@cid", this.txtcourseid.Text);
            com.Parameters.AddWithValue("@name", this.txtname.Text);
            com.Parameters.AddWithValue("@fee", this.txtfee.Text);
            com.Parameters.AddWithValue("@duration", this.txtduration.Text);
            com.Parameters.AddWithValue("@descrip", this.txtdescrip.Text);
            com.Parameters.AddWithValue("@discount", this.txtdiscount.Text);




            //excecute the command
            int ret = com.ExecuteNonQuery(); //ret is the variable name(return) this is to get the number of rows effected
            MessageBox.Show("No of records edited:" + ret, "INFORMATION"); //INFORMATION is the message box title
            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcourseid.Clear();
            txtname.Clear();
            txtfee.Clear();
            txtduration.Clear();
            txtdescrip.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            this.txtcourseid.Text = Convert.ToString(dataGridView1[0, row].Value);
            this.txtname.Text = Convert.ToString(dataGridView1[1, row].Value);
            this.txtfee.Text = Convert.ToString(dataGridView1[2, row].Value);
            this.txtduration.Text = Convert.ToString(dataGridView1[3, row].Value);
            this.txtdescrip.Text = Convert.ToString(dataGridView1[4, row].Value);
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=NPN_PERERA ; Initial Catalog=finalprojectdb; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open(); //makes the connection live

            //define a command with SQL statement 
            string sql = "SELECT * FROM tblcourse";
            SqlCommand com = new SqlCommand(sql, con); //pass both the sql and the connection parameters

            //access data using data ADAPTOR method
            SqlDataAdapter dap = new SqlDataAdapter(com);
            ds = new DataSet();
            dap.Fill(ds);

            //bind data with controls
            this.txtcourseid.Text = ds.Tables[0].Rows[0][0].ToString();  //table number 0  //the row number starts from 0
            this.txtname.Text = ds.Tables[0].Rows[0][1].ToString(); //1st is the row index and 2nd is the coumn index
            this.txtfee.Text = ds.Tables[0].Rows[0][2].ToString();
            this.txtduration.Text = ds.Tables[0].Rows[0][3].ToString();
            this.txtdescrip.Text = ds.Tables[0].Rows[0][4].ToString();
            this.txtdiscount.Text = ds.Tables[0].Rows[0][4].ToString();

            //load the gried view of the table
            this.dataGridView1.DataSource = ds.Tables[0];

            //disconnect from the sql server
            con.Close();   //and release the memory
        }
    }
}
