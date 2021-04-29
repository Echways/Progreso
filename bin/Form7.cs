using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            logic1x9 = new Form6();
            logic1x99 = new Form9();
            logicalphru = new Form11();
            logicalphen = new Form10();
            logicvr = new Form12();
        }
        readonly Form6 logic1x9;
        readonly Form9 logic1x99;
        readonly Form11 logicalphru;
        readonly Form10 logicalphen;
        readonly Form12 logicvr;

        private void button1_Click(object sender, EventArgs e)
        {
            logic1x9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logic1x99.Show();
            this.Hide();
        }

        private void buttonf_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[1];
            this.Hide();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logicalphru.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logicalphen.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            logicvr.Show();
            this.Hide();
        }
    }
}
