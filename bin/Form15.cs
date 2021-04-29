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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        Bitmap obj = Properties.Resources.obj15;
        Bitmap up = Properties.Resources.up15;
        Bitmap down = Properties.Resources.down15;
        Bitmap right = Properties.Resources.right15;
        Bitmap left = Properties.Resources.left15;

        List<int> buttonl = new List<int>();
        private void buttongen()
        {
            var random = new Random();
            buttonl.Add(1);
            for (var i = 2; i < 25; i++)
            {
                var swap = random.Next(i - 1);
                buttonl.Add(buttonl[swap]);
                buttonl[swap] = i;
            }
            buttonl.Remove(1);
            buttonl.Remove(5);
            buttonl.Remove(20);
            buttonl.Remove(24);
        }

        private void buttonmid_Click(object sender, EventArgs e)
        {
            buttongen();
            buttonmid.Enabled = false;
            buttonmid.Text = "";
            cleanerF();

            //1 круг------------------------------------------------------------------------------------------
            if (this.Controls["button" + buttonl[0]].Location.Y < buttonmid.Location.Y) // Yk < Ymid - Вверх
            {
                buttonmid.Image = up;
                Task.Delay(600).Wait();
                buttonmid.Image = null;
                //2 круг--------------------------------------------------------------------------------------
                if (this.Controls["button" + buttonl[0]].Location.Y < button8.Location.Y) // Yk < Y8 - Вверх
                {
                    buttonmid.Image = null;
                    Task.Delay(600).Wait();
                    buttonmid.Image = up;
                    Task.Delay(600).Wait();
                    buttonmid.Image = null;
                    //3 круг-----------------------------------------------------------------------------------
                    if (this.Controls["button" + buttonl[0]].Location.X < button8.Location.X) // Xk < X8 - Влево
                    {
                        buttonmid.Image = null;
                        Task.Delay(600).Wait();
                        buttonmid.Image = left;
                        Task.Delay(600).Wait();
                        buttonmid.Image = null;
                        //4 круг--------------------------------------------------------------------------------
                        if (this.Controls["button" + buttonl[0]].Location.X < button7.Location.X) // Xk < X7 - Влево
                        {
                            buttonmid.Image = null;
                            Task.Delay(600).Wait();
                            buttonmid.Image = left;
                            Task.Delay(600).Wait();
                            buttonmid.Image = null;
                        }
                    }
                    if (this.Controls["button" + buttonl[0]].Location.X > button8.Location.X) // Xk > X8 - Вправо
                    {
                        buttonmid.Image = null;
                        Task.Delay(600).Wait();
                        buttonmid.Image = right;
                        Task.Delay(600).Wait();
                        buttonmid.Image = null;
                        //4 круг--------------------------------------------------------------------------------
                        if (this.Controls["button" + buttonl[0]].Location.X > button9.Location.X) // Xk < X9 - Вправо
                        {
                            buttonmid.Image = null;
                            Task.Delay(600).Wait();
                            buttonmid.Image = right;
                            Task.Delay(600).Wait();
                            buttonmid.Image = null;
                        }
                    }
                }
                //2 круг--------------------------------------------------------------------------------------
                else
                {
                    if (this.Controls["button" + buttonl[0]].Location.X < button17.Location.X) // Xk < X17 - Влево
                    {
                        buttonmid.Image = null;
                        Task.Delay(600).Wait();
                        buttonmid.Image = left;
                        Task.Delay(600).Wait();
                        buttonmid.Image = null;
                        //4 круг--------------------------------------------------------------------------------
                        if (this.Controls["button" + buttonl[0]].Location.X < button7.Location.X) // Xk < X7 - Влево
                        {
                            buttonmid.Image = null;
                            Task.Delay(600).Wait();
                            buttonmid.Image = left;
                            Task.Delay(600).Wait();
                            buttonmid.Image = null;
                        }
                    }
                    if (this.Controls["button" + buttonl[0]].Location.X > button17.Location.X) // Xk > X17 - Вправо
                    {
                        buttonmid.Image = null;
                        Task.Delay(600).Wait();
                        buttonmid.Image = right;
                        Task.Delay(600).Wait();
                        buttonmid.Image = null;
                        //4 круг--------------------------------------------------------------------------------
                        if (this.Controls["button" + buttonl[0]].Location.X > button9.Location.X) // Xk < X9 - Вправо
                        {
                            buttonmid.Image = null;
                            Task.Delay(600).Wait();
                            buttonmid.Image = right;
                            Task.Delay(600).Wait();
                            buttonmid.Image = null;
                        }
                    }
                }

            }

            //1 круг------------------------------------------------------------------------------------------
            if (this.Controls["button" + buttonl[0]].Location.Y > buttonmid.Location.Y) // Yk > Ymid - Вниз 
            {
                buttonmid.Image = down;
                Task.Delay(600).Wait();
                buttonmid.Image = null;
                //2 круг--------------------------------------------------------------------------------------
                if (this.Controls["button" + buttonl[0]].Location.Y > button17.Location.Y) // Yk > Y17 - Вниз
                {
                    buttonmid.Image = null;
                    Task.Delay(600).Wait();
                    buttonmid.Image = down;
                    Task.Delay(600).Wait();
                    buttonmid.Image = null;
                    //3 круг-----------------------------------------------------------------------------------
                    if (this.Controls["button" + buttonl[0]].Location.X < button17.Location.X) // Xk < X17 - Влево
                    {
                        buttonmid.Image = null;
                        Task.Delay(600).Wait();
                        buttonmid.Image = left;
                        Task.Delay(600).Wait();
                        buttonmid.Image = null;
                        //4 круг--------------------------------------------------------------------------------
                        if (this.Controls["button" + buttonl[0]].Location.X < button7.Location.X) // Xk < X7 - Влево
                        {
                            buttonmid.Image = null;
                            Task.Delay(600).Wait();
                            buttonmid.Image = left;
                            Task.Delay(600).Wait();
                            buttonmid.Image = null;
                        }
                    }
                    if (this.Controls["button" + buttonl[0]].Location.X > button17.Location.X) // Xk > X17 - Вправо
                    {
                        buttonmid.Image = null;
                        Task.Delay(600).Wait();
                        buttonmid.Image = right;
                        Task.Delay(600).Wait();
                        buttonmid.Image = null;
                        //4 круг--------------------------------------------------------------------------------
                        if (this.Controls["button" + buttonl[0]].Location.X > button9.Location.X) // Xk < X9 - Вправо
                        {
                            buttonmid.Image = null;
                            Task.Delay(600).Wait();
                            buttonmid.Image = right;
                            Task.Delay(600).Wait();
                            buttonmid.Image = null;
                        }
                    }
                }
                //2 круг--------------------------------------------------------------------------------------
                else
                {
                    if (this.Controls["button" + buttonl[0]].Location.X < button17.Location.X) // Xk < X17 - Влево
                    {
                        buttonmid.Image = null;
                        Task.Delay(600).Wait();
                        buttonmid.Image = left;
                        Task.Delay(600).Wait();
                        buttonmid.Image = null;
                        //4 круг--------------------------------------------------------------------------------
                        if (this.Controls["button" + buttonl[0]].Location.X < button7.Location.X) // Xk < X7 - Влево
                        {
                            buttonmid.Image = null;
                            Task.Delay(600).Wait();
                            buttonmid.Image = left;
                            Task.Delay(600).Wait();
                            buttonmid.Image = null;
                        }
                    }
                    if (this.Controls["button" + buttonl[0]].Location.X > button17.Location.X) // Xk > X17 - Вправо
                    {
                        buttonmid.Image = null;
                        Task.Delay(600).Wait();
                        buttonmid.Image = right;
                        Task.Delay(600).Wait();
                        buttonmid.Image = null;
                        //4 круг--------------------------------------------------------------------------------
                        if (this.Controls["button" + buttonl[0]].Location.X > button9.Location.X) // Xk < X9 - Вправо
                        {
                            buttonmid.Image = null;
                            Task.Delay(600).Wait();
                            buttonmid.Image = right;
                            Task.Delay(600).Wait();
                            buttonmid.Image = null;
                        }
                    }
                }
            }

            //1 круг------------------------------------------------------------------------------------------
            if (this.Controls["button" + buttonl[0]].Location.Y == buttonmid.Location.Y) // Yk == Ymid - Ровно
            {
                buttonmid.Image = null;
                //2 круг--------------------------------------------------------------------------------------
                buttonmid.Image = null;
                //3 круг-----------------------------------------------------------------------------------
                if (this.Controls["button" + buttonl[0]].Location.X < buttonmid.Location.X) // Xk < XMid - Влево
                {
                    buttonmid.Image = null;
                    Task.Delay(600).Wait();
                    buttonmid.Image = left;
                    Task.Delay(600).Wait();
                    buttonmid.Image = null;
                    //4 круг--------------------------------------------------------------------------------
                    if (this.Controls["button" + buttonl[0]].Location.X < button7.Location.X) // Xk < X7 - Влево
                    {
                        buttonmid.Image = null;
                        Task.Delay(600).Wait();
                        buttonmid.Image = left;
                        Task.Delay(600).Wait();
                        buttonmid.Image = null;
                    }
                }
                if (this.Controls["button" + buttonl[0]].Location.X > buttonmid.Location.X)// Xk > XMid - Вправо
                {
                    buttonmid.Image = null;
                    Task.Delay(600).Wait();
                    buttonmid.Image = right;
                    Task.Delay(600).Wait();
                    buttonmid.Image = null;
                    //4 круг--------------------------------------------------------------------------------
                    if (this.Controls["button" + buttonl[0]].Location.X > button9.Location.X) // Xk < X9 - Вправо
                    {
                        buttonmid.Image = null;
                        Task.Delay(600).Wait();
                        buttonmid.Image = right;
                        Task.Delay(600).Wait();
                        buttonmid.Image = null;
                    }
                }
            }

            /* 1 круг------------------------------------------------------------------------------------------
            if (this.Controls["button" + buttonl[0]].Location.X == buttonmid.Location.X) // Xk == Xmid - Ровно
            {
                if (this.Controls["button" + buttonl[0]].Location.Y > buttonmid.Location.Y) // Yk > Ymid - Вниз 
                {
                    buttonmid.Image = down;
                    Task.Delay(600).Wait();
                    buttonmid.Image = null;
                    //2 круг--------------------------------------------------------------------------------------
                    if (this.Controls["button" + buttonl[0]].Location.Y > button17.Location.Y) // Yk > Y17 - Вниз
                    {
                        buttonmid.Image = null;
                        Task.Delay(600).Wait();
                        buttonmid.Image = down;
                        Task.Delay(600).Wait();
                        buttonmid.Image = null;
                    }
                }

                //1 круг------------------------------------------------------------------------------------------
                if (this.Controls["button" + buttonl[0]].Location.Y < buttonmid.Location.Y) // Yk < Ymid - Вверх
                {
                    buttonmid.Image = up;
                    Task.Delay(600).Wait();
                    buttonmid.Image = null;
                    //2 круг--------------------------------------------------------------------------------------
                    if (this.Controls["button" + buttonl[0]].Location.Y < button8.Location.Y) // Yk < Y8 - Вверх
                    {
                        buttonmid.Image = null;
                        Task.Delay(600).Wait();
                        buttonmid.Image = up;
                        Task.Delay(600).Wait();
                        buttonmid.Image = null;
                    }
                }
            }*/

            Task.Delay(200).Wait();
            cleanerT();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            button19.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = false;

            if (this.Controls["button" + buttonl[0]].Enabled == false)
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uright();
            }
            else
            {
                this.Controls["button" + buttonl[0]].BackgroundImage = obj;
                uwrong();
            }
        }

        private void buttonres_Click(object sender, EventArgs e)
        {
            rsty();
        }

        private void buttonf_Click(object sender, EventArgs e)
        {
            rsty();

            Form form1 = Application.OpenForms[1];
            this.Hide();
            form1.Show();
        }

        private void cleanerF()
        {
            this.Controls["button" + 2].Enabled = false;
            this.Controls["button" + 3].Enabled = false;
            this.Controls["button" + 4].Enabled = false;
            this.Controls["button" + 6].Enabled = false;
            this.Controls["button" + 7].Enabled = false;
            this.Controls["button" + 8].Enabled = false;
            this.Controls["button" + 9].Enabled = false;
            this.Controls["button" + 10].Enabled = false;
            this.Controls["button" + 11].Enabled = false;
            this.Controls["button" + 12].Enabled = false;
            this.Controls["button" + 13].Enabled = false;
            this.Controls["button" + 14].Enabled = false;
            this.Controls["button" + 15].Enabled = false;
            this.Controls["button" + 16].Enabled = false;
            this.Controls["button" + 17].Enabled = false;
            this.Controls["button" + 18].Enabled = false;
            this.Controls["button" + 19].Enabled = false;
            this.Controls["button" + 21].Enabled = false;
            this.Controls["button" + 22].Enabled = false;
            this.Controls["button" + 23].Enabled = false;
        }

        private void cleanerT()
        {
            this.Controls["button" + 2].Enabled = true;
            this.Controls["button" + 3].Enabled = true;
            this.Controls["button" + 4].Enabled = true;
            this.Controls["button" + 6].Enabled = true;
            this.Controls["button" + 7].Enabled = true;
            this.Controls["button" + 8].Enabled = true;
            this.Controls["button" + 9].Enabled = true;
            this.Controls["button" + 10].Enabled = true;
            this.Controls["button" + 11].Enabled = true;
            this.Controls["button" + 12].Enabled = true;
            this.Controls["button" + 13].Enabled = true;
            this.Controls["button" + 14].Enabled = true;
            this.Controls["button" + 15].Enabled = true;
            this.Controls["button" + 16].Enabled = true;
            this.Controls["button" + 17].Enabled = true;
            this.Controls["button" + 18].Enabled = true;
            this.Controls["button" + 19].Enabled = true;
            this.Controls["button" + 21].Enabled = true;
            this.Controls["button" + 22].Enabled = true;
            this.Controls["button" + 23].Enabled = true;
        }

        private void uright()
        {
            labelml.Visible = true;
            this.Controls["button" + "mid"].BackColor = Color.SpringGreen;

            this.Controls["button" + 2].Enabled = false;
            this.Controls["button" + 3].Enabled = false;
            this.Controls["button" + 4].Enabled = false;
            this.Controls["button" + 6].Enabled = false;
            this.Controls["button" + 7].Enabled = false;
            this.Controls["button" + 8].Enabled = false;
            this.Controls["button" + 9].Enabled = false;
            this.Controls["button" + 10].Enabled = false;
            this.Controls["button" + 11].Enabled = false;
            this.Controls["button" + 12].Enabled = false;
            this.Controls["button" + 13].Enabled = false;
            this.Controls["button" + 14].Enabled = false;
            this.Controls["button" + 15].Enabled = false;
            this.Controls["button" + 16].Enabled = false;
            this.Controls["button" + 17].Enabled = false;
            this.Controls["button" + 18].Enabled = false;
            this.Controls["button" + 19].Enabled = false;
            this.Controls["button" + 21].Enabled = false;
            this.Controls["button" + 22].Enabled = false;
            this.Controls["button" + 23].Enabled = false;

            /*this.Controls["button" + 2].BackColor = Color.SpringGreen;
            this.Controls["button" + 3].BackColor = Color.SpringGreen;
            this.Controls["button" + 4].BackColor = Color.SpringGreen;
            this.Controls["button" + 6].BackColor = Color.SpringGreen;
            this.Controls["button" + 7].BackColor = Color.SpringGreen;
            this.Controls["button" + 8].BackColor = Color.SpringGreen;
            this.Controls["button" + 9].BackColor = Color.SpringGreen;
            this.Controls["button" + 10].BackColor = Color.SpringGreen;
            this.Controls["button" + 11].BackColor = Color.SpringGreen;
            this.Controls["button" + 12].BackColor = Color.SpringGreen;
            this.Controls["button" + 13].BackColor = Color.SpringGreen;
            this.Controls["button" + 14].BackColor = Color.SpringGreen;
            this.Controls["button" + 15].BackColor = Color.SpringGreen;
            this.Controls["button" + 16].BackColor = Color.SpringGreen;
            this.Controls["button" + 17].BackColor = Color.SpringGreen;
            this.Controls["button" + 18].BackColor = Color.SpringGreen;
            this.Controls["button" + 19].BackColor = Color.SpringGreen;
            this.Controls["button" + 21].BackColor = Color.SpringGreen;
            this.Controls["button" + 22].BackColor = Color.SpringGreen;
            this.Controls["button" + 23].BackColor = Color.SpringGreen;*/
        }
        private void uwrong()
        {
            labelnp.Visible = true;
            this.Controls["button" + "mid"].BackColor = Color.Crimson;

            this.Controls["button" + 2].Enabled = false;
            this.Controls["button" + 3].Enabled = false;
            this.Controls["button" + 4].Enabled = false;
            this.Controls["button" + 6].Enabled = false;
            this.Controls["button" + 7].Enabled = false;
            this.Controls["button" + 8].Enabled = false;
            this.Controls["button" + 9].Enabled = false;
            this.Controls["button" + 10].Enabled = false;
            this.Controls["button" + 11].Enabled = false;
            this.Controls["button" + 12].Enabled = false;
            this.Controls["button" + 13].Enabled = false;
            this.Controls["button" + 14].Enabled = false;
            this.Controls["button" + 15].Enabled = false;
            this.Controls["button" + 16].Enabled = false;
            this.Controls["button" + 17].Enabled = false;
            this.Controls["button" + 18].Enabled = false;
            this.Controls["button" + 19].Enabled = false;
            this.Controls["button" + 21].Enabled = false;
            this.Controls["button" + 22].Enabled = false;
            this.Controls["button" + 23].Enabled = false;

            /*this.Controls["button" + 2].BackColor = Color.Crimson;
            this.Controls["button" + 3].BackColor = Color.Crimson;
            this.Controls["button" + 4].BackColor = Color.Crimson;
            this.Controls["button" + 6].BackColor = Color.Crimson;
            this.Controls["button" + 7].BackColor = Color.Crimson;
            this.Controls["button" + 8].BackColor = Color.Crimson;
            this.Controls["button" + 9].BackColor = Color.Crimson;
            this.Controls["button" + 10].BackColor = Color.Crimson;
            this.Controls["button" + 11].BackColor = Color.Crimson;
            this.Controls["button" + 12].BackColor = Color.Crimson;
            this.Controls["button" + 13].BackColor = Color.Crimson;
            this.Controls["button" + 14].BackColor = Color.Crimson;
            this.Controls["button" + 15].BackColor = Color.Crimson;
            this.Controls["button" + 16].BackColor = Color.Crimson;
            this.Controls["button" + 17].BackColor = Color.Crimson;
            this.Controls["button" + 18].BackColor = Color.Crimson;
            this.Controls["button" + 19].BackColor = Color.Crimson;
            this.Controls["button" + 21].BackColor = Color.Crimson;
            this.Controls["button" + 22].BackColor = Color.Crimson;
            this.Controls["button" + 23].BackColor = Color.Crimson;*/
        }

        private void rsty()
        {
            this.Controls["button" + "mid"].Text = "Начать";
            buttonmid.Enabled = true;
            buttonl.Clear();
            labelnp.Visible = false;
            labelml.Visible = false;

            this.Controls["button" + "mid"].BackColor = Color.Gainsboro;
            this.Controls["button" + 2].BackColor = Color.Gainsboro;
            this.Controls["button" + 3].BackColor = Color.Gainsboro;
            this.Controls["button" + 4].BackColor = Color.Gainsboro;
            this.Controls["button" + 6].BackColor = Color.Gainsboro;
            this.Controls["button" + 7].BackColor = Color.Gainsboro;
            this.Controls["button" + 8].BackColor = Color.Gainsboro;
            this.Controls["button" + 9].BackColor = Color.Gainsboro;
            this.Controls["button" + 10].BackColor = Color.Gainsboro;
            this.Controls["button" + 11].BackColor = Color.Gainsboro;
            this.Controls["button" + 12].BackColor = Color.Gainsboro;
            this.Controls["button" + 13].BackColor = Color.Gainsboro;
            this.Controls["button" + 14].BackColor = Color.Gainsboro;
            this.Controls["button" + 15].BackColor = Color.Gainsboro;
            this.Controls["button" + 16].BackColor = Color.Gainsboro;
            this.Controls["button" + 17].BackColor = Color.Gainsboro;
            this.Controls["button" + 18].BackColor = Color.Gainsboro;
            this.Controls["button" + 19].BackColor = Color.Gainsboro;
            this.Controls["button" + 21].BackColor = Color.Gainsboro;
            this.Controls["button" + 22].BackColor = Color.Gainsboro;
            this.Controls["button" + 23].BackColor = Color.Gainsboro;

            this.Controls["button" + 2].BackgroundImage = null;
            this.Controls["button" + 3].BackgroundImage = null;
            this.Controls["button" + 4].BackgroundImage = null;
            this.Controls["button" + 6].BackgroundImage = null;
            this.Controls["button" + 7].BackgroundImage = null;
            this.Controls["button" + 8].BackgroundImage = null;
            this.Controls["button" + 9].BackgroundImage = null;
            this.Controls["button" + 10].BackgroundImage = null;
            this.Controls["button" + 11].BackgroundImage = null;
            this.Controls["button" + 12].BackgroundImage = null;
            this.Controls["button" + 13].BackgroundImage = null;
            this.Controls["button" + 14].BackgroundImage = null;
            this.Controls["button" + 15].BackgroundImage = null;
            this.Controls["button" + 16].BackgroundImage = null;
            this.Controls["button" + 17].BackgroundImage = null;
            this.Controls["button" + 18].BackgroundImage = null;
            this.Controls["button" + 19].BackgroundImage = null;
            this.Controls["button" + 21].BackgroundImage = null;
            this.Controls["button" + 22].BackgroundImage = null;
            this.Controls["button" + 23].BackgroundImage = null;

            this.Controls["button" + 2].Enabled = false;
            this.Controls["button" + 3].Enabled = false;
            this.Controls["button" + 4].Enabled = false;
            this.Controls["button" + 6].Enabled = false;
            this.Controls["button" + 7].Enabled = false;
            this.Controls["button" + 8].Enabled = false;
            this.Controls["button" + 9].Enabled = false;
            this.Controls["button" + 10].Enabled = false;
            this.Controls["button" + 11].Enabled = false;
            this.Controls["button" + 12].Enabled = false;
            this.Controls["button" + 13].Enabled = false;
            this.Controls["button" + 14].Enabled = false;
            this.Controls["button" + 15].Enabled = false;
            this.Controls["button" + 16].Enabled = false;
            this.Controls["button" + 17].Enabled = false;
            this.Controls["button" + 18].Enabled = false;
            this.Controls["button" + 19].Enabled = false;
            this.Controls["button" + 21].Enabled = false;
            this.Controls["button" + 22].Enabled = false;
            this.Controls["button" + 23].Enabled = false;
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            cleanerF();
        }
    }
}
