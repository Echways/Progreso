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
using System.Drawing.Text;

 
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
        List<string> font_family = new List<string>();
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
            ffgen();

            //

            SoundPlayer fon = new SoundPlayer(Properties.Resources.Back);
            fon.PlayLooping();

            //

            if (font_family.Contains("a_AssuanTitulStrDst") == false || font_family.Contains("a_MachinaOrtoSht") == false || font_family.Contains("a_AlbionicTtlRg&Bt") == false)
            {
                this.TopMost = false;
                Form5 fontdg = new Form5();
                fontdg.Show();
                this.Opacity = 0;

                // 1
                if (font_family.Contains("a_AssuanTitulStrDst") == true)
                {
                    //That's good
                }
                else
                {
                    System.Diagnostics.Process.Start(@"bin\Resources\Шрифты\a_AssuanTitulStrDs.ttf");
                }

                // 2

                if (font_family.Contains("a_MachinaOrtoSht") == true)
                {
                    //That's good
                }
                else
                {
                    System.Diagnostics.Process.Start(@"bin\Resources\Шрифты\a_MachinaOrtoSht.ttf");
                }

                // 3

                if (font_family.Contains("a_AlbionicTtlRg&Bt") == true)
                {
                    //That's good
                }
                else
                {
                    System.Diagnostics.Process.Start(@"bin\Resources\Шрифты\a_AlbionicTtlRgBt.ttf");
                }
            }
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

        private void Form0_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                Application.Exit();
            }
        }

        private void ffgen()
        {
            foreach (FontFamily item in FontFamily.Families)
            {
                font_family.Add(item.Name);
            }
        }
    }
}
