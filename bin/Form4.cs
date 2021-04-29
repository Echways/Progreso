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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TClist.Clear();
            TCl.Clear();
            TCgen();
            TClistgen();
            label2.Visible = true;
            label4.Hide();
            label5.Hide();
            label3.Hide();
            button4.Hide();
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;

            var rnd = new Random();
            var l2t = TCl[TClist[1]].Text.ToString();
            var l2c = TCl[TClist[3]].Color;
            label2.Text = l2t;
            label2.ForeColor = l2c;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";

            for (int i = 1; i < 25; i++)
            {
                button2.BackColor = TCl[TClist[rnd.Next(4)]].Color;
                button1.BackColor = TCl[TClist[rnd.Next(4)]].Color;
                button3.BackColor = TCl[TClist[rnd.Next(4)]].Color;
                if (button2.BackColor != button1.BackColor & button2.BackColor != button3.BackColor & button1.BackColor != button3.BackColor & (button1.BackColor == l2c ^ button2.BackColor == l2c ^ button3.BackColor == l2c))
                {
                    if (button1.BackColor == TCl[TClist[1]].Color ^ button2.BackColor == TCl[TClist[1]].Color ^ button3.BackColor == TCl[TClist[1]].Color)
                    {
                        break;
                    }
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = Application.OpenForms[1];
            form1.Show();

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            label3.Visible = true;
            label2.Visible = false;
            label4.Hide();
            label5.Hide();
            TClist.Clear();
            TCl.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button4.Show();
            if (button1.BackColor == label2.ForeColor)
            {
                label4.Show();
            }
            else
            {
                label5.Show();
            }
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label2.Visible = false;
            TClist.Clear();
            TCl.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button4.Show();
            if (button2.BackColor == label2.ForeColor)
            {
                label4.Show();
            }
            else
            {
                label5.Show();
            }
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label2.Visible = false;
            TClist.Clear();
            TCl.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button4.Show();
            if (button3.BackColor == label2.ForeColor)
            {
                label4.Show();
            }
            else
            {
                label5.Show();
            }
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label2.Visible = false;
            TClist.Clear();
            TCl.Clear();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        public class TC : IEquatable <TC>
        {
            public string Text { get; set; }

            public Color Color { get; set; }

            public override string ToString()
            {
                return Text + Color;
            }
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                TC objAsPart = obj as TC;
                if (objAsPart == null) return false;
                else return Equals(objAsPart);
            }

            /*public override Color GetHashCode()
            {
                return Color;
            }*/

            public bool Equals(TC other)
            {
                if (other == null) return false;
                return (this.Color.Equals(other.Color));
            }
        }
        List<TC> TCl = new List<TC>();
        private void TCgen()
        {
            TCl.Add(new TC() { Text = "Красный", Color = Color.Red }); // 1
            TCl.Add(new TC() { Text = "Синий", Color = Color.Blue }); // 2
            TCl.Add(new TC() { Text = "Зелёный", Color = Color.Green }); // 3
            TCl.Add(new TC() { Text = "Жёлтый", Color = Color.Yellow }); // 4
            TCl.Add(new TC() { Text = "Оранжевый", Color = Color.Orange }); // 5
            TCl.Add(new TC() { Text = "Розовый", Color = Color.Pink }); // 6
            TCl.Add(new TC() { Text = "Фиолетовый", Color = Color.Purple }); // 7
            TCl.Add(new TC() { Text = "Голубой", Color = Color.Cyan }); // 8
        }

        List<int> TClist = new List<int>();
        private void TClistgen()
        {
            var random = new Random();
            TClist.Add(0);
            for (var i = 2; i <= TCl.Count-1; i++)
            {
                var swap = random.Next(i - 1);
                TClist.Add(TClist[swap]);
                TClist[swap] = i;
            }
        }
    }
}