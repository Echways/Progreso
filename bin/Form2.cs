using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                Application.Exit();
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Hide();
            knp();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            knp();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Hide();
            knp();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Hide();
            knp();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            knp();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            knp();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            /*pictureBox7.Hide();
            knp();*/
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Hide();
            knp();
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Hide();
            knp();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Hide();
            knp();
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Hide();
            knp();
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Hide();
            knp();
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Hide();
            knp();
        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Hide();
            knp();
        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Hide();
            knp();
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Hide();
            knp();
        }

        private void PictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Hide();
            knp();
        }

        private void PictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.Hide();
            knp();
        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Hide();
            knp();
        }

        private void PictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox26.Visible = true;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            button4.Visible = true;
        }

        private void PictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox27.Visible = true;
            pictureBox23.Visible = false;
            pictureBox22.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            button4.Visible = true;
        }

        private void PictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox29.Visible = true;
            pictureBox25.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            button4.Visible = true;
        }

        private void PictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox28.Visible = true;
            pictureBox24.Visible = false;
            pictureBox23.Visible = false;
            pictureBox22.Visible = false;
            pictureBox25.Visible = false;
            button4.Visible = true;
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            if (pictureBox16.Visible==false && pictureBox26.Visible == true || pictureBox29.Visible == true && pictureBox4.Visible == false)
            {
                button4.Visible = false;
                label4.Visible = true;
                //button1.Visible = true;
                label1.Visible = false;
                button2.Visible = true;
                button1.Visible = true;
            }
            else 
            {
                button4.Visible = false;
                label5.Visible = true;
                label1.Visible = false;
                button2.Visible = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form16 spc2 = new Form16();
            spc2.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label1.Visible = true;

            button1.Visible = false;
            button2.Visible = false;

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            pictureBox17.Enabled = true;
            pictureBox18.Enabled = true;
            pictureBox19.Enabled = true;
            pictureBox20.Enabled = true;
            pictureBox21.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;
            pictureBox21.Visible = true;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = Application.OpenForms[1];
            form1.Show();

            label4.Visible = false;
            label5.Visible = false;
            label1.Visible = true;

            button1.Visible = false;
            button2.Visible = false;

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            pictureBox17.Enabled = true;
            pictureBox18.Enabled = true;
            pictureBox19.Enabled = true;
            pictureBox20.Enabled = true;
            pictureBox21.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;
            pictureBox21.Visible = true;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void knp()
        {
            label1.Visible = false;

            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
            pictureBox13.Enabled = false;
            pictureBox14.Enabled = false;
            pictureBox15.Enabled = false;
            pictureBox16.Enabled = false;
            pictureBox17.Enabled = false;
            pictureBox18.Enabled = false;
            pictureBox19.Enabled = false;
            pictureBox20.Enabled = false;
            pictureBox21.Enabled = false;
            pictureBox22.Visible = true;
            pictureBox23.Visible = true;
            pictureBox24.Visible = true;
            pictureBox25.Visible = true;
        }
    }
}
