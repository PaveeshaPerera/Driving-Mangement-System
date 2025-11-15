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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            viewcourse viewcourse = new viewcourse();
            viewcourse.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(viewcourse);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            addstaffsal viewcourse = new addstaffsal();
            viewcourse.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(viewcourse);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            viewinvoice viewinvoice = new viewinvoice();
            viewinvoice.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(viewinvoice);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            viewfeedback viewfeedback = new viewfeedback();
            viewfeedback.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(viewfeedback);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            viewleaves viewleaves = new viewleaves();
            viewleaves.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(viewleaves);
        }
    }
}
