
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form0
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            this.button20 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.Font = new System.Drawing.Font("a_AssuanTitulStrDst", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(362, 325);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(120, 50);
            this.button20.TabIndex = 1;
            this.button20.TabStop = false;
            this.button20.Text = "Выход";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Button20_click);
            // 
            // button30
            // 
            this.button30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button30.Cursor = System.Windows.Forms.Cursors.No;
            this.button30.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("a_AssuanTitulStrDst", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button30.Location = new System.Drawing.Point(1227, 627);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(25, 25);
            this.button30.TabIndex = 0;
            this.button30.TabStop = false;
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.Button30_click);
            // 
            // button40
            // 
            this.button40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button40.AutoSize = true;
            this.button40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button40.Font = new System.Drawing.Font("a_AssuanTitulStrDst", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button40.ForeColor = System.Drawing.Color.Black;
            this.button40.Location = new System.Drawing.Point(488, 285);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(288, 90);
            this.button40.TabIndex = 3;
            this.button40.TabStop = false;
            this.button40.Text = "Играть";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.Button40_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("a_AssuanTitulStrDst", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(782, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Включить музыку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("a_AssuanTitulStrDst", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(782, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 50);
            this.button2.TabIndex = 5;
            this.button2.TabStop = false;
            this.button2.Text = "Выключить музыку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 641);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 11);
            this.label1.TabIndex = 6;
            this.label1.Text = "© HackStars, 2021 ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Caesar Dressing Cyrillic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Progreso";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(514, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Activated += new System.EventHandler(this.Form0_Activated);
            this.Load += new System.EventHandler(this.Form0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button30_click(object sender, EventArgs e)
        {
            //Form16 ts = new Form16();
            //ts.Show();
            //this.Hide();
        }

        private void Button20_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button40_click(object sender, EventArgs e)
        {
            zapusk.Show();
            this.Hide();
        }

        #endregion
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button40;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}

