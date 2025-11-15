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
    public partial class newschedule : UserControl
    {
        public newschedule()
        {
            InitializeComponent();
        }

        private void schedulepanal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            schedulepanal.Controls.Clear();
            lecturesadd lecturesadd= new lecturesadd();
            lecturesadd.Dock = DockStyle.Fill;
            schedulepanal.Controls.Add(lecturesadd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            schedulepanal.Controls.Clear();
            sessionsadd sessionsadd= new sessionsadd();
            sessionsadd.Dock = DockStyle.Fill;
            schedulepanal.Controls.Add(sessionsadd);
        }
    }
}
