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
    public partial class Lecturer : Form
    {
        public Lecturer()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            addleaves addleaves = new addleaves();
            addleaves.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(addleaves);
        }
    }
}
