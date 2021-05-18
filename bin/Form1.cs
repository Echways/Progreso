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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            logic1 = new Form7();
            logic2 = new Form2();

            pamiat = new Form13();
            pamiat2 = new Form14();

            vnimanie = new Form4();
            vnimanie2 = new Form15();
        }

        readonly Form7 logic1;
        readonly Form2 logic2;

        readonly Form13 pamiat;
        readonly Form14 pamiat2;

        readonly Form15 vnimanie2;
        readonly Form4 vnimanie;

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form0 = Application.OpenForms[0];
            form0.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            logic1.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            vnimanie.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pamiat.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pamiat2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vnimanie2.Show();
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            logic2.Show();
            this.Hide();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                Application.Exit();
            }
        }
    }
}
