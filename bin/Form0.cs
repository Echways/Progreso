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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
            zapusk = new Form8();
            rr = new Form3();
        }
        readonly Form8 zapusk;
        readonly Form3 rr;
        public string playername;
        private void Button40_сlick(object sender, EventArgs e)
        {
            zapusk.Show();
            this.Close();
        }

        private void Button20_сlick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer fon = new SoundPlayer(Properties.Resources.Back);
            fon.PlayLooping();
            button1.Hide();
            button2.Show();
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            SoundPlayer fon = new SoundPlayer(Properties.Resources.Back);
            fon.PlayLooping();
        }

        private void Form0_Activated(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SoundPlayer fon = new SoundPlayer(Properties.Resources.Back);
            fon.Stop();
            button2.Hide();
            button1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 rr = new Form3();
            rr.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
