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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
            string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        int count = 33;
        List<int> listd = new List<int>();
        private void chisla()
        {
            var random = new Random();
            listd.Add(1);
            for (var i = 2; i < count; i++)
            {
                var swap = random.Next(i - 1);
                listd.Add(listd[swap]);
                listd[swap] = i;
            }
        }

        List<int> srt = new List<int>();
        private void srtchisla()
        {
            chisla();

            srt.Add(listd[0]);
            srt.Add(listd[1]);
            srt.Add(listd[2]);
            srt.Add(listd[3]);
            srt.Add(listd[4]);
            srt.Add(listd[5]);
            srt.Add(listd[6]);
            srt.Add(listd[7]);
            srt.Add(listd[8]);

            srt.Sort();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            srtchisla();

            buttons.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            label2.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;

            button1.Text = Alphabet[listd[0]].ToString();
            button2.Text = Alphabet[listd[1]].ToString();
            button3.Text = Alphabet[listd[2]].ToString();
            button4.Text = Alphabet[listd[3]].ToString();
            button5.Text = Alphabet[listd[4]].ToString();
            button6.Text = Alphabet[listd[5]].ToString();
            button7.Text = Alphabet[listd[6]].ToString();
            button8.Text = Alphabet[listd[7]].ToString();
            button9.Text = Alphabet[listd[8]].ToString();

            if (button12.Enabled == false)
            {
                label1.Text = Alphabet[srt[0]].ToString() + Alphabet[srt[1]].ToString() + Alphabet[srt[2]].ToString() + Alphabet[srt[3]].ToString() + Alphabet[srt[4]].ToString() + Alphabet[srt[5]].ToString() + Alphabet[srt[6]].ToString() + Alphabet[srt[7]].ToString() + Alphabet[srt[8]].ToString();
            }
            else
            {
                label1.Text = Alphabet[srt[8]].ToString() + Alphabet[srt[7]].ToString() + Alphabet[srt[6]].ToString() + Alphabet[srt[5]].ToString() + Alphabet[srt[4]].ToString() + Alphabet[srt[3]].ToString() + Alphabet[srt[2]].ToString() + Alphabet[srt[1]].ToString() + Alphabet[srt[0]].ToString();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button1.Text;
            button1.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button2.Text;
            button2.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button3.Text;
            button3.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button4.Text;
            button4.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button5.Text;
            button5.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button6.Text;
            button6.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button7.Text;
            button7.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button8.Text;
            button8.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.DarkGray;
            label2.Text = label2.Text + button9.Text;
            button9.Enabled = false;
            if (button1.Enabled == false & button2.Enabled == false & button3.Enabled == false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
            {
                if (label1.Text == label2.Text)
                {
                    label3.Visible = true;
                    label3.ForeColor = Color.SpringGreen;
                }
                else
                {
                    label4.ForeColor = Color.Crimson;
                    label4.Visible = true;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttons.Visible = true;
            button12.Visible = false;
            button13.Visible = false;
            button13.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttons.Visible = true;
            button12.Visible = false;
            button13.Visible = false;
            button12.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            srtchisla();

            button12.Visible = true;
            button13.Visible = true;
            buttons.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button12.Enabled = true;
            button13.Enabled = true;

            listd.Clear();
            srt.Clear();
        }

        private void buttonf_Click(object sender, EventArgs e)
        {
            srtchisla();

            Form form7 = Application.OpenForms[2];
            this.Hide();
            form7.Show();

            listd.Clear();
            srt.Clear();

            button12.Visible = true;
            button13.Visible = true;
            buttons.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button12.Enabled = true;
            button13.Enabled = true;
        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
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
