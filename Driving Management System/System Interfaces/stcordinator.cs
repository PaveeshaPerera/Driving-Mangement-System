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
    public partial class stcordinator : Form
    {
        public stcordinator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
           addguidelines staffregister = new addguidelines();
            staffregister.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(staffregister);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            viewcourse viewcourse = new viewcourse();
            viewcourse.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(viewcourse);
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
