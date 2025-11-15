using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_Managment_System
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
           addfeedback addfeedback = new addfeedback();
            addfeedback.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(addfeedback);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            viewguide staffregister = new viewguide();
            staffregister.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(staffregister);
        }
    }
}
