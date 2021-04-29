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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        List<int> listz = new List<int>();
        private void chislaz()
        {
            var random = new Random();
            listz.Add(0);
            for (var i = 1; i < 4; i++)
            {
                var swap = random.Next(i - 1);
                listz.Add(listz[swap]);
                listz[swap] = i;
            }
        }

        int count = 51;
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
        public class person : IEquatable<person>
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public override string ToString()
            {
                return Name + Age;
            }
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                person objAsPart = obj as person;
                if (objAsPart == null) return false;
                else return Equals(objAsPart);
            }
            public override int GetHashCode()
            {
                return Age;
            }
            public bool Equals(person other)
            {
                if (other == null) return false;
                return (this.Age.Equals(other.Age));
            }
            // Should also override == and != operators.
        }
        List<person> nameage = new List<person>();
        private void nmag()
        {
            nameage.Add(new person() {Name = "Никита", Age = 15}); // 1
            nameage.Add(new person() {Name = "Альфред", Age = 65}); // 2
            nameage.Add(new person() {Name = "Андрей Р.", Age = 49}); // 3
            nameage.Add(new person() {Name = "Илья", Age = 60}); // 4
            nameage.Add(new person() {Name = "Дима", Age = 30}); // 5
            nameage.Add(new person() {Name = "Антон", Age = 37}); // 6
            nameage.Add(new person() {Name = "Роберт", Age = 99}); // 7
            nameage.Add(new person() {Name = "Эдуард", Age = 45}); // 8
            nameage.Add(new person() {Name = "Николай С.", Age = 27}); // 9
            nameage.Add(new person() {Name = "Марио", Age = 29}); // 10
            nameage.Add(new person() {Name = "Джордж Ф.", Age = 46}); // 11
            nameage.Add(new person() {Name = "Иосиф С.", Age = 75}); // 12
            nameage.Add(new person() {Name = "Максим", Age = 68}); // 13
            nameage.Add(new person() {Name = "Саша", Age = 11}); // 14
            nameage.Add(new person() {Name = "Донателло", Age = 40}); // 15
            nameage.Add(new person() {Name = "Виталик", Age = 36}); // 16
            nameage.Add(new person() {Name = "Владимир П.", Age = 68}); // 17
            nameage.Add(new person() {Name = "Джо Б.", Age = 78}); // 18
            nameage.Add(new person() {Name = "Егор", Age = 17}); // 19
            nameage.Add(new person() {Name = "Станислав", Age = 37}); // 20
            nameage.Add(new person() {Name = "Сергей", Age = 49}); // 21
            nameage.Add(new person() {Name = "Валентин", Age = 25}); // 22
            nameage.Add(new person() {Name = "Макар", Age = 28}); // 23
            nameage.Add(new person() {Name = "Владислав", Age = 39}); // 24
            nameage.Add(new person() {Name = "Наталья", Age = 29}); // 25
            nameage.Add(new person() {Name = "Елизавета", Age = 36}); // 26
            nameage.Add(new person() {Name = "Матвей", Age = 13}); // 27
            nameage.Add(new person() {Name = "Ахмед", Age = 56}); // 28
            nameage.Add(new person() {Name = "Даниил", Age = 26}); // 29
            nameage.Add(new person() {Name = "Василий", Age = 36}); // 30
            nameage.Add(new person() {Name = "Денис", Age = 39}); // 31
            nameage.Add(new person() {Name = "Алиса", Age = 14}); // 32
            nameage.Add(new person() {Name = "Святослав", Age = 30}); // 33
            nameage.Add(new person() {Name = "Филипп К.", Age = 57}); // 34
            nameage.Add(new person() {Name = "Григорий Л.", Age = 58}); // 35
            nameage.Add(new person() {Name = "Алла П.", Age = 77}); // 36
            nameage.Add(new person() {Name = "Никита Д.", Age = 59}); // 37
            nameage.Add(new person() {Name = "Роман", Age = 37}); // 38
            nameage.Add(new person() {Name = "Вера", Age = 26}); // 39
            nameage.Add(new person() {Name = "Элина", Age = 26}); // 41
            nameage.Add(new person() {Name = "Эмиль", Age = 28}); // 42
            nameage.Add(new person() {Name = "Дарья", Age = 29}); // 43
            nameage.Add(new person() {Name = "Давид", Age = 26}); // 44
            nameage.Add(new person() {Name = "Ибрагим", Age = 48}); // 45
            nameage.Add(new person() {Name = "Павел Д.", Age = 36}); // 46
            nameage.Add(new person() {Name = "Марк Ц.", Age = 36}); // 47
            nameage.Add(new person() {Name = "Илон М.", Age = 49}); // 48
            nameage.Add(new person() {Name = "Джефф Б.", Age = 57}); // 49
            nameage.Add(new person() {Name = "Билл Г.", Age = 65}); // 50
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            labela.Text = labela.Text + button1.Text;
            button1.BackColor = Color.DarkGray;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labela.Text = labela.Text + button2.Text;
            button2.BackColor = Color.DarkGray;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labela.Text = labela.Text + button3.Text;
            button3.BackColor = Color.DarkGray;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labela.Text = labela.Text + button4.Text;
            button4.BackColor = Color.DarkGray;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labela.Text = labela.Text + nameage[listd[listz[0]]].Age;
            button5.BackColor = Color.DarkGray;

            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

            if (labela.Text == label1.Text ^ labela.Text == label2.Text ^ labela.Text == label3.Text ^ labela.Text == label4.Text)
            {
                labela.Text = "";
                button5.BackColor = Color.MediumSeaGreen;

                if (button1.BackColor == Color.DarkGray)
                {
                    button1.BackColor = Color.MediumSeaGreen;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }

                if (button2.BackColor == Color.DarkGray)
                {
                    button2.BackColor = Color.MediumSeaGreen;
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }

                if (button3.BackColor == Color.DarkGray)
                {
                    button3.BackColor = Color.MediumSeaGreen;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button4.Enabled = true;
                }

                if (button4.BackColor == Color.DarkGray)
                {
                    button4.BackColor = Color.MediumSeaGreen;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
            }

            else
            {
                button5.Enabled = true;
                button5.BackColor = Color.Gainsboro;
                labela.Text = "";
                labelppt.Text = labelppt.Text + 1;
                wr -= 1;
                label9.Text = "Кол-во попыток - ";
                label9.Text += wr;

                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;

                if (button1.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button1.BackColor = Color.Gainsboro;
                }

                if (button2.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button2.BackColor = Color.Gainsboro;
                }

                if (button3.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button3.BackColor = Color.Gainsboro;
                }

                if (button4.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button4.BackColor = Color.Gainsboro;
                }

                if (labelppt.Text == labelnumb.Text)
                {
                    labelnp.Visible = true;
                    labelnp.ForeColor = Color.Crimson;

                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }    
            }

            if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen) 
            {
                labelml.Visible = true;
                labelml.ForeColor = Color.SpringGreen;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labela.Text = labela.Text + nameage[listd[listz[3]]].Age;
            button6.BackColor = Color.DarkGray;

            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

            if (labela.Text == label1.Text ^ labela.Text == label2.Text ^ labela.Text == label3.Text ^ labela.Text == label4.Text)
            {
                labela.Text = "";
                button6.BackColor = Color.MediumSeaGreen;

                if (button1.BackColor == Color.DarkGray)
                {
                    button1.BackColor = Color.MediumSeaGreen;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }

                if (button2.BackColor == Color.DarkGray)
                {
                    button2.BackColor = Color.MediumSeaGreen;
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }

                if (button3.BackColor == Color.DarkGray)
                {
                    button3.BackColor = Color.MediumSeaGreen;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button4.Enabled = true;
                }

                if (button4.BackColor == Color.DarkGray)
                {
                    button4.BackColor = Color.MediumSeaGreen;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
            }

            else
            {
                button6.Enabled = true;
                button6.BackColor = Color.Gainsboro;
                labela.Text = "";
                labelppt.Text = labelppt.Text + 1;
                wr -= 1;
                label9.Text = "Кол-во попыток - ";
                label9.Text += wr;

                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;

                if (button1.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button1.BackColor = Color.Gainsboro;
                }

                if (button2.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button2.BackColor = Color.Gainsboro;
                }

                if (button3.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button3.BackColor = Color.Gainsboro;
                }

                if (button4.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button4.BackColor = Color.Gainsboro;
                }

                if (labelppt.Text == labelnumb.Text)
                {
                    labelnp.Visible = true;
                    labelnp.ForeColor = Color.Crimson;

                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }
            }

            if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen)
            {
                labelml.Visible = true;
                labelml.ForeColor = Color.SpringGreen;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labela.Text = labela.Text + nameage[listd[listz[1]]].Age;
            button7.BackColor = Color.DarkGray;

            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

            if (labela.Text == label1.Text ^ labela.Text == label2.Text ^ labela.Text == label3.Text ^ labela.Text == label4.Text)
            {
                labela.Text = "";
                button7.BackColor = Color.MediumSeaGreen;

                if (button1.BackColor == Color.DarkGray)
                {
                    button1.BackColor = Color.MediumSeaGreen;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }

                if (button2.BackColor == Color.DarkGray)
                {
                    button2.BackColor = Color.MediumSeaGreen;
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }

                if (button3.BackColor == Color.DarkGray)
                {
                    button3.BackColor = Color.MediumSeaGreen;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button4.Enabled = true;
                }

                if (button4.BackColor == Color.DarkGray)
                {
                    button4.BackColor = Color.MediumSeaGreen;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen)
                {
                    labelml.Visible = true;
                    labelml.ForeColor = Color.SpringGreen;

                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }
            }

            else
            {
                button7.Enabled = true;
                button7.BackColor = Color.Gainsboro;
                labela.Text = "";
                labelppt.Text = labelppt.Text + 1;
                wr -= 1;
                label9.Text = "Кол-во попыток - ";
                label9.Text += wr;

                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;

                if (button1.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button1.BackColor = Color.Gainsboro;
                }

                if (button2.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button2.BackColor = Color.Gainsboro;
                }

                if (button3.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button3.BackColor = Color.Gainsboro;
                }

                if (button4.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button4.BackColor = Color.Gainsboro;
                }

                if (labelppt.Text == labelnumb.Text)
                {
                    labelnp.Visible = true;
                    labelnp.ForeColor = Color.Crimson;

                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labela.Text = labela.Text + nameage[listd[listz[2]]].Age;
            button8.BackColor = Color.DarkGray;

            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

            if (labela.Text == label1.Text ^ labela.Text == label2.Text ^ labela.Text == label3.Text ^ labela.Text == label4.Text)
            {
                labela.Text = "";
                button8.BackColor = Color.MediumSeaGreen;

                if (button1.BackColor == Color.DarkGray)
                {
                    button1.BackColor = Color.MediumSeaGreen;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }

                if (button2.BackColor == Color.DarkGray)
                {
                    button2.BackColor = Color.MediumSeaGreen;
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }

                if (button3.BackColor == Color.DarkGray)
                {
                    button3.BackColor = Color.MediumSeaGreen;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button4.Enabled = true;
                }

                if (button4.BackColor == Color.DarkGray)
                {
                    button4.BackColor = Color.MediumSeaGreen;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                }

                if (button1.BackColor == Color.MediumSeaGreen & button2.BackColor == Color.MediumSeaGreen & button3.BackColor == Color.MediumSeaGreen & button4.BackColor == Color.MediumSeaGreen) 
                {
                    labelml.Visible = true;
                    labelml.ForeColor = Color.SpringGreen;

                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }
            }

            else
            {
                button8.Enabled = true;
                button8.BackColor = Color.Gainsboro;
                labela.Text = "";
                labelppt.Text = labelppt.Text + 1;
                wr -= 1;
                label9.Text = "Кол-во попыток - ";
                label9.Text += wr;

                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;

                if (button1.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button1.BackColor = Color.Gainsboro;
                }

                if (button2.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button2.BackColor = Color.Gainsboro;
                }

                if (button3.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button3.BackColor = Color.Gainsboro;
                }

                if (button4.BackColor == Color.DarkGray)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button4.BackColor = Color.Gainsboro;
                }

                if (labelppt.Text == labelnumb.Text)
                {
                    labelnp.Visible = true;
                    labelnp.ForeColor = Color.Crimson;

                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }
            }
        }
        public int wr = 5;
        private void Form13_Load(object sender, EventArgs e)
        {
            listd.Clear();
            labelnumb.Text = 11111.ToString();
            label9.Text += wr;
        }

        private void buttonst_Click(object sender, EventArgs e)
        {
            //listd.Clear();

            nmag();
            chislaz();
            chisla();

            wr = 5;
            label9.Text = "Кол-во попыток - ";
            label9.Text += wr;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label5.Text = nameage[listd[0]].Name.ToString() + " - " + nameage[listd[0]].Age.ToString() + " лет";
            label6.Text = nameage[listd[1]].Name.ToString() + " - " + nameage[listd[1]].Age.ToString() + " лет";
            label7.Text = nameage[listd[2]].Name.ToString() + " - " + nameage[listd[2]].Age.ToString() + " лет";
            label8.Text = nameage[listd[3]].Name.ToString() + " - " + nameage[listd[3]].Age.ToString() + " лет";
            buttonst.Visible = false;

            Task.Delay(3000).Wait();

            label1.Text = nameage[listd[listz[0]]].ToString();
            label2.Text = nameage[listd[listz[3]]].ToString();
            label3.Text = nameage[listd[listz[1]]].ToString();
            label4.Text = nameage[listd[listz[2]]].ToString();
            labelml.Visible = false;
            labelnp.Visible = false;
            labela.Text = "";
            labelppt.Text = "";

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            button1.Text = nameage[listd[0]].Name.ToString();
            button2.Text = nameage[listd[1]].Name.ToString();
            button3.Text = nameage[listd[2]].Name.ToString();
            button4.Text = nameage[listd[3]].Name.ToString();

            button5.Text = nameage[listd[listz[0]]].Age.ToString() + " лет";
            button6.Text = nameage[listd[listz[3]]].Age.ToString() + " лет";
            button7.Text = nameage[listd[listz[1]]].Age.ToString() + " лет";
            button8.Text = nameage[listd[listz[2]]].Age.ToString() + " лет";

            button1.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            buttonst.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            chisla();
            nmag();
            chislaz();

            listd.Clear();
            listz.Clear();
            labela.Text = "";
            labelppt.Text = "";
            wr = 5;
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

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void buttonf_Click(object sender, EventArgs e)
        {
            chisla();
            nmag();
            chislaz();

            listd.Clear();
            listz.Clear();
            labela.Text = "";
            labelppt.Text = "";
            wr = 5;
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

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

            Form form1 = Application.OpenForms[1];
            this.Hide();
            form1.Show();
        }
    }
}
