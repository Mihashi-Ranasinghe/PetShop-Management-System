
using System.Data;
using System.Data.SqlClient;

namespace Pet_Shop_Management_System
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            InitializeComponent(label6);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Label label6)
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label15 = new Label();
            panel6 = new Panel();
            CatsLbl = new Label();
            label14 = new Label();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            panel5 = new Panel();
            BirdsLbl = new Label();
            label13 = new Label();
            pictureBox11 = new PictureBox();
            panel4 = new Panel();
            DogsLbl = new Label();
            label12 = new Label();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            label11 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            pictureBox8 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            guna2CircleProgressBar1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 5;
            guna2Elipse1.TargetControl = panel1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(guna2CircleProgressBar1);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(201, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 414);
            panel1.TabIndex = 0;
            // 
            // guna2CircleProgressBar1
            // 
            guna2CircleProgressBar1.Controls.Add(label15);
            guna2CircleProgressBar1.FillColor = Color.FromArgb(200, 213, 218, 223);
            guna2CircleProgressBar1.Font = new Font("Segoe UI", 12F);
            guna2CircleProgressBar1.ForeColor = Color.White;
            guna2CircleProgressBar1.Location = new Point(466, 284);
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ProgressColor = Color.DeepSkyBlue;
            guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleProgressBar1.Size = new Size(130, 130);
            guna2CircleProgressBar1.TabIndex = 11;
            guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.GrayText;
            label15.Location = new Point(44, 54);
            label15.Name = "label15";
            label15.Size = new Size(40, 18);
            label15.TabIndex = 10;
            label15.Text = "Cats";
            // 
            // panel6
            // 
            panel6.BackColor = Color.DeepSkyBlue;
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(CatsLbl);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(pictureBox13);
            panel6.Controls.Add(pictureBox14);
            panel6.ForeColor = SystemColors.ControlLightLight;
            panel6.Location = new Point(51, 301);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 87);
            panel6.TabIndex = 10;
            // 
            // CatsLbl
            // 
            CatsLbl.AutoSize = true;
            CatsLbl.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CatsLbl.ForeColor = Color.Yellow;
            CatsLbl.Location = new Point(96, 35);
            CatsLbl.Name = "CatsLbl";
            CatsLbl.Size = new Size(34, 18);
            CatsLbl.TabIndex = 11;
            CatsLbl.Text = "Cat";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.HighlightText;
            label14.Location = new Point(50, 1);
            label14.Name = "label14";
            label14.Size = new Size(40, 18);
            label14.TabIndex = 9;
            label14.Text = "Cats";
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImageLayout = ImageLayout.Center;
            pictureBox13.BorderStyle = BorderStyle.FixedSingle;
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(19, 22);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(45, 39);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 8;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BackgroundImageLayout = ImageLayout.Center;
            pictureBox14.BorderStyle = BorderStyle.FixedSingle;
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(463, 34);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(80, 71);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 5;
            pictureBox14.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DeepSkyBlue;
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(BirdsLbl);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(pictureBox11);
            panel5.ForeColor = SystemColors.ControlLightLight;
            panel5.Location = new Point(390, 191);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 87);
            panel5.TabIndex = 9;
            // 
            // BirdsLbl
            // 
            BirdsLbl.AutoSize = true;
            BirdsLbl.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BirdsLbl.ForeColor = Color.Yellow;
            BirdsLbl.Location = new Point(108, 28);
            BirdsLbl.Name = "BirdsLbl";
            BirdsLbl.Size = new Size(34, 18);
            BirdsLbl.TabIndex = 11;
            BirdsLbl.Text = "Cat";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.HighlightText;
            label13.Location = new Point(53, 2);
            label13.Name = "label13";
            label13.Size = new Size(42, 18);
            label13.TabIndex = 9;
            label13.Text = "Birds";
            // 
            // pictureBox11
            // 
            pictureBox11.BackgroundImageLayout = ImageLayout.Center;
            pictureBox11.BorderStyle = BorderStyle.FixedSingle;
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(21, 23);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(42, 37);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 8;
            pictureBox11.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DeepSkyBlue;
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(DogsLbl);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(pictureBox10);
            panel4.Controls.Add(pictureBox9);
            panel4.ForeColor = SystemColors.ControlLightLight;
            panel4.Location = new Point(51, 191);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 87);
            panel4.TabIndex = 8;
            // 
            // DogsLbl
            // 
            DogsLbl.AutoSize = true;
            DogsLbl.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DogsLbl.ForeColor = Color.Yellow;
            DogsLbl.Location = new Point(96, 28);
            DogsLbl.Name = "DogsLbl";
            DogsLbl.Size = new Size(34, 18);
            DogsLbl.TabIndex = 10;
            DogsLbl.Text = "Cat";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HighlightText;
            label12.Location = new Point(50, 2);
            label12.Name = "label12";
            label12.Size = new Size(39, 18);
            label12.TabIndex = 9;
            label12.Text = "Dog";
            label12.Click += label12_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImageLayout = ImageLayout.Center;
            pictureBox10.BorderStyle = BorderStyle.FixedSingle;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(19, 23);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(45, 38);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 8;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImageLayout = ImageLayout.Center;
            pictureBox9.BorderStyle = BorderStyle.FixedSingle;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(463, 34);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(80, 71);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 5;
            pictureBox9.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label11.ForeColor = SystemColors.InfoText;
            label11.Location = new Point(51, 172);
            label11.Name = "label11";
            label11.Size = new Size(122, 16);
            label11.TabIndex = 7;
            label11.Text = "My Pookie Pet Shop";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(pictureBox8);
            panel3.ForeColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(51, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(609, 139);
            panel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label10.ForeColor = SystemColors.InfoText;
            label10.Location = new Point(29, 93);
            label10.Name = "label10";
            label10.Size = new Size(394, 16);
            label10.TabIndex = 8;
            label10.Text = "We serve you with high quality and nice care to your pet with foods";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label9.ForeColor = SystemColors.InfoText;
            label9.Location = new Point(29, 58);
            label9.Name = "label9";
            label9.Size = new Size(333, 16);
            label9.TabIndex = 7;
            label9.Text = "We serve you with high quality and nice care to your pet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label8.ForeColor = SystemColors.InfoText;
            label8.Location = new Point(29, 21);
            label8.Name = "label8";
            label8.Size = new Size(122, 16);
            label8.TabIndex = 6;
            label8.Text = "My Pookie Pet Shop";
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImageLayout = ImageLayout.Center;
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(463, 34);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(80, 71);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 5;
            pictureBox8.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(26, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 36);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, -9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(46, 7);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Home";
            label2.Click += label2_Click;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 2;
            guna2Elipse3.TargetControl = panel2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(69, 153);
            label1.Name = "label1";
            label1.Size = new Size(64, 18);
            label1.TabIndex = 6;
            label1.Text = "Product";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 197);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(69, 211);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 8;
            label3.Text = "Employee";
            label3.Click += label3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(28, 252);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(69, 266);
            label4.Name = "label4";
            label4.Size = new Size(84, 18);
            label4.TabIndex = 10;
            label4.Text = "Customers";
            label4.Click += label4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Center;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(28, 305);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(69, 319);
            label5.Name = "label5";
            label5.Size = new Size(52, 18);
            label5.TabIndex = 12;
            label5.Text = "Billing";
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.Center;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(28, 362);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(69, 376);
            label6.Name = "label6";
            label6.Size = new Size(58, 18);
            label6.TabIndex = 14;
            label6.Text = "Logout";
            label6.Click += label6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImageLayout = ImageLayout.Center;
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(13, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(45, 44);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HighlightText;
            label7.Location = new Point(59, 38);
            label7.Name = "label7";
            label7.Size = new Size(94, 18);
            label7.TabIndex = 17;
            label7.Text = "Emp-Name";
            label7.Click += label7_Click;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 5;
            guna2Elipse4.TargetControl = panel4;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(919, 429);
            Controls.Add(label7);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(label6);
            Controls.Add(pictureBox5);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            guna2CircleProgressBar1.ResumeLayout(false);
            guna2CircleProgressBar1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox5;
        private Label label5;
        private PictureBox pictureBox6;
        private Label label6;
        private PictureBox pictureBox7;
        private Label label7;
        private Panel panel3;
        private PictureBox pictureBox8;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel4;
        private PictureBox pictureBox9;
        private Label label11;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Label label12;
        private PictureBox pictureBox10;
        private Panel panel5;
        private Label label13;
        private PictureBox pictureBox11;
        private Panel panel6;
        private Label label14;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Label label15;
        private Label DogsLbl;
        private Label CatsLbl;
        private Label BirdsLbl;
    }
}