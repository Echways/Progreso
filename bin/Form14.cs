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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        List<int> fruit = new List<int>();
        private void fruitn()
        {
            var random = new Random();
            fruit.Add(0);
            for (var i = 1; i < 7; i++)
            {
                var swap = random.Next(i - 1);
                fruit.Add(fruit[swap]);
                fruit[swap] = i;
            }
        }
        List<Bitmap> fruitl = new List<Bitmap>();
        private void fruitlgen()
        {
            fruitl.Add(Properties.Resources.Banana14);
            fruitl.Add(Properties.Resources.Apple14);
            fruitl.Add(Properties.Resources.Cherry14);
            fruitl.Add(Properties.Resources.Grapes14);
            fruitl.Add(Properties.Resources.Raspberry14);
            fruitl.Add(Properties.Resources.Carrot14);
            fruitl.Add(Properties.Resources.Watermelon14);
        }

        List<string> fruitname = new List<string>();
        private void fruitnamegen()
        {
            fruitname.Add("Banana14");
            fruitname.Add("Apple14");
            fruitname.Add("Cherry14");
            fruitname.Add("Grapes14");
            fruitname.Add("Raspberry14");
            fruitname.Add("Carrot14");
            fruitname.Add("Watermelon14");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = fruitl[2];
            button1.BackColor = Color.DarkGray;
            button1.Enabled = false;
            labelprv.Text += 1;
            labelstr.Text += fruitname[2];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackgroundImage = fruitl[1];
            button2.BackColor = Color.DarkGray;
            button2.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[1];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackgroundImage = fruitl[0];
            button3.BackColor = Color.DarkGray;
            button3.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[0];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackgroundImage = fruitl[4];
            button4.BackColor = Color.DarkGray;
            button4.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[4];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackgroundImage = fruitl[3];
            button5.BackColor = Color.DarkGray;
            button5.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[3];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackgroundImage = fruitl[fruit[2]];
            button6.BackColor = Color.DarkGray;
            button6.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[fruit[2]];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackgroundImage = fruitl[fruit[4]];
            button7.BackColor = Color.DarkGray;
            button7.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[fruit[4]];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackgroundImage = fruitl[fruit[1]];
            button8.BackColor = Color.DarkGray;
            button8.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[fruit[1]];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackgroundImage = fruitl[fruit[0]];
            button9.BackColor = Color.DarkGray;
            button9.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[fruit[0]];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackgroundImage = fruitl[fruit[3]];
            button10.BackColor = Color.DarkGray;
            button10.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[fruit[3]];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void buttonst_Click(object sender, EventArgs e)
        {
            fruitlgen();
            fruitn();
            fruitnamegen();

            buttonst.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;

            wr = 8;
            label9.Text = "Кол-во попыток - ";
            label9.Text += wr;

            labelprv.Text = "";

            button1.BackgroundImage = fruitl[2];
            button2.BackgroundImage = fruitl[1];
            button3.BackgroundImage = fruitl[0];
            button4.BackgroundImage = fruitl[4];
            button5.BackgroundImage = fruitl[3];
            button6.BackgroundImage = fruitl[fruit[2]];
            button7.BackgroundImage = fruitl[fruit[4]];
            button8.BackgroundImage = fruitl[fruit[1]];
            button9.BackgroundImage = fruitl[fruit[0]];
            button10.BackgroundImage = fruitl[fruit[3]];
            button12.BackgroundImage = fruitl[5];
            button14.BackgroundImage = fruitl[6];
            button13.BackgroundImage = fruitl[fruit[6]];
            button15.BackgroundImage = fruitl[fruit[5]];

            button1.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;
            button10.BackColor = Color.Gainsboro;
            button12.BackColor = Color.Gainsboro;
            button13.BackColor = Color.Gainsboro;
            button14.BackColor = Color.Gainsboro;
            button15.BackColor = Color.Gainsboro;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;

            Task.Delay(3000).Wait();

            button1.BackgroundImage = Properties.Resources.Qestionmark14;
            button2.BackgroundImage = Properties.Resources.Qestionmark14;
            button3.BackgroundImage = Properties.Resources.Qestionmark14;
            button4.BackgroundImage = Properties.Resources.Qestionmark14;
            button5.BackgroundImage = Properties.Resources.Qestionmark14;
            button6.BackgroundImage = Properties.Resources.Qestionmark14;
            button7.BackgroundImage = Properties.Resources.Qestionmark14;
            button8.BackgroundImage = Properties.Resources.Qestionmark14;
            button9.BackgroundImage = Properties.Resources.Qestionmark14;
            button10.BackgroundImage = Properties.Resources.Qestionmark14;
            button12.BackgroundImage = Properties.Resources.Qestionmark14;
            button13.BackgroundImage = Properties.Resources.Qestionmark14;
            button14.BackgroundImage = Properties.Resources.Qestionmark14;
            button15.BackgroundImage = Properties.Resources.Qestionmark14;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;

            label1.Text = fruitname[0] + fruitname[0];
            label2.Text = fruitname[1] + fruitname[1];
            label3.Text = fruitname[2] + fruitname[2];
            label4.Text = fruitname[3] + fruitname[3];
            label5.Text = fruitname[4] + fruitname[4];
            label6.Text = fruitname[5] + fruitname[5];
            label7.Text = fruitname[6] + fruitname[6];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fruitlgen();
            fruitn();
            fruitnamegen();

            labelprv.Text = "";
            labelppt.Text = "";
            wr = 8;
            label9.Text = "Кол-во попыток - ";
            label9.Text += wr;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;

            buttonst.Visible = true;
            labelml.Visible = false;
            labelnp.Visible = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;

            fruit.Clear();
            fruitl.Clear();
        }

        private void buttonf_Click(object sender, EventArgs e)
        {
            fruitlgen();
            fruitn();
            fruitnamegen();

            labelprv.Text = "";
            labelppt.Text = "";
            wr = 8;
            label9.Text = "Кол-во попыток - ";
            label9.Text += wr;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;

            buttonst.Visible = true;
            labelml.Visible = false;
            labelnp.Visible = false;

            button1.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;
            button10.BackColor = Color.Gainsboro;
            button12.BackColor = Color.Gainsboro;
            button13.BackColor = Color.Gainsboro;
            button14.BackColor = Color.Gainsboro;
            button15.BackColor = Color.Gainsboro;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;

            fruit.Clear();
            fruitl.Clear();

            Form form1 = Application.OpenForms[1];
            this.Hide();
            form1.Show();
        }
        public int wr = 8;
        private void Form14_Load(object sender, EventArgs e)
        {
            label9.Text += wr;
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;
            button10.Image = null;
            button12.Image = null;
            button13.Image = null;
            button14.Image = null;
            button15.Image = null;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackgroundImage = fruitl[5];
            button12.BackColor = Color.DarkGray;
            button12.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[5];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackgroundImage = fruitl[fruit[6]];
            button13.BackColor = Color.DarkGray;
            button13.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[fruit[6]];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackgroundImage = fruitl[6];
            button14.BackColor = Color.DarkGray;
            button14.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[6];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackgroundImage = fruitl[fruit[5]];
            button15.BackColor = Color.DarkGray;
            button15.Enabled = false;

            labelprv.Text += 1;
            labelstr.Text += fruitname[fruit[5]];

            if (labelprv.Text == "11")
            {
                if (labelstr.Text == label1.Text || labelstr.Text == label2.Text || labelstr.Text == label3.Text || labelstr.Text == label4.Text || labelstr.Text == label5.Text || labelstr.Text == label6.Text || labelstr.Text == label7.Text)
                {
                    uif();
                }
                else
                {
                    uelse();
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen & button5.BackColor == Color.MediumSeaGreen & button6.BackColor == Color.MediumSeaGreen & button7.BackColor == Color.MediumSeaGreen & button8.BackColor == Color.MediumSeaGreen & button9.BackColor == Color.MediumSeaGreen & button10.BackColor == Color.MediumSeaGreen & button12.BackColor == Color.MediumSeaGreen & button13.BackColor == Color.MediumSeaGreen & button14.BackColor == Color.MediumSeaGreen & button15.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                }

                if (labelppt.Text.Length == 10)
                {
                    wrong();
                }
            }
        }

        private void wrong()
        {
            labelnp.Visible = true;

            button1.BackgroundImage = fruitl[2];
            button2.BackgroundImage = fruitl[1];
            button3.BackgroundImage = fruitl[0];
            button4.BackgroundImage = fruitl[4];
            button5.BackgroundImage = fruitl[3];
            button6.BackgroundImage = fruitl[fruit[2]];
            button7.BackgroundImage = fruitl[fruit[4]];
            button8.BackgroundImage = fruitl[fruit[1]];
            button9.BackgroundImage = fruitl[fruit[0]];
            button10.BackgroundImage = fruitl[fruit[3]];
            button12.BackgroundImage = fruitl[5];
            button14.BackgroundImage = fruitl[6];
            button13.BackgroundImage = fruitl[fruit[6]];
            button15.BackgroundImage = fruitl[fruit[5]];

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
        }

        private void uelse()
        {
            labelprv.Text = "";
            labelstr.Text = "";
            labelppt.Text = labelppt.Text + 1;
            wr -= 1;
            label9.Text = "Кол-во попыток - ";
            label9.Text += wr;

            if (button1.BackColor == Color.DarkGray)
            {
                button1.BackColor = Color.Gainsboro;
                button1.BackgroundImage = Properties.Resources.Qestionmark14;
                button1.Enabled = true;
            }

            if (button2.BackColor == Color.DarkGray)
            {
                button2.BackColor = Color.Gainsboro;
                button2.BackgroundImage = Properties.Resources.Qestionmark14;
                button2.Enabled = true;
            }

            if (button3.BackColor == Color.DarkGray)
            {
                button3.BackColor = Color.Gainsboro;
                button3.BackgroundImage = Properties.Resources.Qestionmark14;
                button3.Enabled = true;
            }

            if (button4.BackColor == Color.DarkGray)
            {
                button4.BackColor = Color.Gainsboro;
                button4.BackgroundImage = Properties.Resources.Qestionmark14;
                button4.Enabled = true;
            }

            if (button5.BackColor == Color.DarkGray)
            {
                button5.BackColor = Color.Gainsboro;
                button5.BackgroundImage = Properties.Resources.Qestionmark14;
                button5.Enabled = true;
            }

            if (button6.BackColor == Color.DarkGray)
            {
                button6.BackColor = Color.Gainsboro;
                button6.BackgroundImage = Properties.Resources.Qestionmark14;
                button6.Enabled = true;
            }

            if (button7.BackColor == Color.DarkGray)
            {
                button7.BackColor = Color.Gainsboro;
                button7.BackgroundImage = Properties.Resources.Qestionmark14;
                button7.Enabled = true;
            }

            if (button8.BackColor == Color.DarkGray)
            {
                button8.BackColor = Color.Gainsboro;
                button8.BackgroundImage = Properties.Resources.Qestionmark14;
                button8.Enabled = true;
            }

            if (button9.BackColor == Color.DarkGray)
            {
                button9.BackColor = Color.Gainsboro;
                button9.BackgroundImage = Properties.Resources.Qestionmark14;
                button9.Enabled = true;
            }

            if (button10.BackColor == Color.DarkGray)
            {
                button10.BackColor = Color.Gainsboro;
                button10.BackgroundImage = Properties.Resources.Qestionmark14;
                button10.Enabled = true;
            }

            if (button12.BackColor == Color.DarkGray)
            {
                button12.BackColor = Color.Gainsboro;
                button12.BackgroundImage = Properties.Resources.Qestionmark14;
                button12.Enabled = true;
            }

            if (button13.BackColor == Color.DarkGray)
            {
                button13.BackColor = Color.Gainsboro;
                button13.BackgroundImage = Properties.Resources.Qestionmark14;
                button13.Enabled = true;
            }

            if (button14.BackColor == Color.DarkGray)
            {
                button14.BackColor = Color.Gainsboro;
                button14.BackgroundImage = Properties.Resources.Qestionmark14;
                button14.Enabled = true;
            }

            if (button15.BackColor == Color.DarkGray)
            {
                button15.BackColor = Color.Gainsboro;
                button15.BackgroundImage = Properties.Resources.Qestionmark14;
                button15.Enabled = true;
            }
        }

        private void uif()
        {
            labelprv.Text = "";
            labelstr.Text = "";

            if (button1.BackColor == Color.DarkGray)
            {
                button1.BackColor = Color.MediumSeaGreen;
            }

            if (button2.BackColor == Color.DarkGray)
            {
                button2.BackColor = Color.MediumSeaGreen;
            }

            if (button3.BackColor == Color.DarkGray)
            {
                button3.BackColor = Color.MediumSeaGreen;
            }

            if (button4.BackColor == Color.DarkGray)
            {
                button4.BackColor = Color.MediumSeaGreen;
            }

            if (button5.BackColor == Color.DarkGray)
            {
                button5.BackColor = Color.MediumSeaGreen;
            }

            if (button6.BackColor == Color.DarkGray)
            {
                button6.BackColor = Color.MediumSeaGreen;
            }

            if (button7.BackColor == Color.DarkGray)
            {
                button7.BackColor = Color.MediumSeaGreen;
            }

            if (button8.BackColor == Color.DarkGray)
            {
                button8.BackColor = Color.MediumSeaGreen;
            }

            if (button9.BackColor == Color.DarkGray)
            {
                button9.BackColor = Color.MediumSeaGreen;
            }

            if (button10.BackColor == Color.DarkGray)
            {
                button10.BackColor = Color.MediumSeaGreen;
            }

            if (button12.BackColor == Color.DarkGray)
            {
                button12.BackColor = Color.MediumSeaGreen;
            }

            if (button13.BackColor == Color.DarkGray)
            {
                button13.BackColor = Color.MediumSeaGreen;
            }

            if (button14.BackColor == Color.DarkGray)
            {
                button14.BackColor = Color.MediumSeaGreen;
            }

            if (button15.BackColor == Color.DarkGray)
            {
                button15.BackColor = Color.MediumSeaGreen;
            }
        }
    }
}
