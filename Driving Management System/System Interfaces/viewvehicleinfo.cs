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
    public partial class viewvehicleinfo : UserControl
    {
        public viewvehicleinfo()
        {
            InitializeComponent();
        }
        private DataSet ds;


        private void button5_Click(object sender, EventArgs e)
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
    }
}
