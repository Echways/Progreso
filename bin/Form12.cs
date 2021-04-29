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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        int count = 100;
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

            if (button14.Enabled == false)
            {
                srt.Add(listd[0] - listd[1]);
                srt.Add(listd[2] - listd[3]);
                srt.Add(listd[4] - listd[5]);
                srt.Add(listd[6] - listd[7]);
                srt.Add(listd[8] - listd[9]);
                srt.Add(listd[10] - listd[11]);
                srt.Add(listd[12] - listd[13]);
                srt.Add(listd[14] - listd[15]);
                srt.Add(listd[16] - listd[17]);
            }
            else
            {
                srt.Add(listd[0] + listd[1]);
                srt.Add(listd[2] + listd[3]);
                srt.Add(listd[4] + listd[5]);
                srt.Add(listd[6] + listd[7]);
                srt.Add(listd[8] + listd[9]);
                srt.Add(listd[10] + listd[11]);
                srt.Add(listd[12] + listd[13]);
                srt.Add(listd[14] + listd[15]);
                srt.Add(listd[16] + listd[17]);
            }

            srt.Sort();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
        private void button10_Click(object sender, EventArgs e)
        {
            chisla();
            srtchisla();
            if (button12.Enabled == false)
            {
                label1.Text = srt[0].ToString() + srt[1].ToString() + srt[2].ToString() + srt[3].ToString() + srt[4].ToString() + srt[5].ToString() + srt[6].ToString() + srt[7].ToString() + srt[8].ToString();
            }
            else
            {
                label1.Text = srt[8].ToString() + srt[7].ToString() + srt[6].ToString() + srt[5].ToString() + srt[4].ToString() + srt[3].ToString() + srt[2].ToString() + srt[1].ToString() + srt[0].ToString();
            }
            button10.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;

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

            if (button14.Enabled == false)
            {
                label5.Text = "-";
            }
            else
            {
                label5.Text = "+";
            }
            button1.Text = String.Join(label5.Text, listd[0].ToString(), listd[1].ToString());
            button2.Text = String.Join(label5.Text, listd[2].ToString(), listd[3].ToString());
            button3.Text = String.Join(label5.Text, listd[4].ToString(), listd[5].ToString());
            button4.Text = String.Join(label5.Text, listd[6].ToString(), listd[7].ToString());
            button5.Text = String.Join(label5.Text, listd[8].ToString(), listd[9].ToString());
            button6.Text = String.Join(label5.Text, listd[10].ToString(), listd[11].ToString());
            button7.Text = String.Join(label5.Text, listd[12].ToString(), listd[13].ToString());
            button8.Text = String.Join(label5.Text, listd[14].ToString(), listd[15].ToString());
            button9.Text = String.Join(label5.Text, listd[16].ToString(), listd[17].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGray;
            if (button14.Enabled == false)
            {
                label2.Text = label2.Text + (listd[0] - listd[1]);
            }
            else
            {
                label2.Text = label2.Text + (listd[0] + listd[1]);
            }
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
            if (button14.Enabled == false)
            {
                label2.Text = label2.Text + (listd[2] - listd[3]);
            }
            else
            {
                label2.Text = label2.Text + (listd[2] + listd[3]);
            }
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
            if (button14.Enabled == false)
            {
                label2.Text = label2.Text + (listd[4] - listd[5]);
            }
            else
            {
                label2.Text = label2.Text + (listd[4] + listd[5]);
            }
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
            if (button14.Enabled == false)
            {
                label2.Text = label2.Text + (listd[6] - listd[7]);
            }
            else
            {
                label2.Text = label2.Text + (listd[6] + listd[7]);
            }
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
            if (button14.Enabled == false)
            {
                label2.Text = label2.Text + (listd[8] - listd[9]);
            }
            else
            {
                label2.Text = label2.Text + (listd[8] + listd[9]);
            }
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
            if (button14.Enabled == false)
            {
                label2.Text = label2.Text + (listd[10] - listd[11]);
            }
            else
            {
                label2.Text = label2.Text + (listd[10] + listd[11]);
            }
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
            if (button14.Enabled == false)
            {
                label2.Text = label2.Text + (listd[12] - listd[13]);
            }
            else
            {
                label2.Text = label2.Text + (listd[12] + listd[13]);
            }
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
            if (button14.Enabled == false)
            {
                label2.Text = label2.Text + (listd[14] - listd[15]);
            }
            else
            {
                label2.Text = label2.Text + (listd[14] + listd[15]);
            }
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
            if (button14.Enabled == false)
            {
                label2.Text = label2.Text + (listd[16] - listd[17]);
            }
            else
            {
                label2.Text = label2.Text + (listd[16] + listd[17]);
            }
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

        private void button11_Click(object sender, EventArgs e)
        {
            srtchisla();

            label1.Text = "";
            label2.Text = "";

            button12.Visible = true;
            button13.Visible = true;
            button10.Visible = false;
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
            button14.Enabled = true;
            button15.Enabled = true;

            listd.Clear();
            srt.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button12.Enabled = false;
            button14.Visible = true;
            button15.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button13.Enabled = false;
            button14.Visible = true;
            button15.Visible = true;
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
            button10.Visible = false;
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
            button14.Enabled = true;
            button15.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            button15.Enabled = false;
            button15.Visible = false;
            button14.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            button14.Enabled = false;
            button15.Visible = false;
            button14.Visible = false;
        }
    }
}
