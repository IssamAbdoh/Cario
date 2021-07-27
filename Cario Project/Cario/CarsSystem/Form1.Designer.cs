
namespace CarsSystem
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.carmodel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.choosecolor = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TextBox();
            this.horsepower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.showcars = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.addimage = new System.Windows.Forms.Button();
            this.imageaddress = new System.Windows.Forms.TextBox();
            this.displayimage = new System.Windows.Forms.PictureBox();
            this.warningspeed = new System.Windows.Forms.Label();
            this.warningpower = new System.Windows.Forms.Label();
            this.warningprice = new System.Windows.Forms.Label();
            this.colordisplay = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.ShowCras = new System.Windows.Forms.Button();
            this.addfilebtn = new System.Windows.Forms.Button();
            this.getfilebtn = new System.Windows.Forms.Button();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosecolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayimage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(254, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // carmodel
            // 
            this.carmodel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carmodel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.carmodel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.carmodel.FormattingEnabled = true;
            this.carmodel.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Dodge",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Infinity",
            "Jaguar",
            "Jeep",
            "KIA",
            "Lexus",
            "Mazda",
            "Mercedes",
            "Mitsubishi",
            "Nissan",
            "Toyota",
            "Volkswagen",
            "Zenvo"});
            this.carmodel.Location = new System.Drawing.Point(40, 211);
            this.carmodel.Name = "carmodel";
            this.carmodel.Size = new System.Drawing.Size(341, 27);
            this.carmodel.Sorted = true;
            this.carmodel.TabIndex = 1;
            this.carmodel.SelectedIndexChanged += new System.EventHandler(this.carmodel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Model";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color:";
            // 
            // choosecolor
            // 
            this.choosecolor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.choosecolor.BackColor = System.Drawing.Color.DarkRed;
            this.choosecolor.Location = new System.Drawing.Point(107, 348);
            this.choosecolor.Name = "choosecolor";
            this.choosecolor.Size = new System.Drawing.Size(73, 33);
            this.choosecolor.TabIndex = 5;
            this.choosecolor.TabStop = false;
            this.choosecolor.Click += new System.EventHandler(this.choosecolorbox_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(442, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max Speed";
            // 
            // speed
            // 
            this.speed.AccessibleDescription = "";
            this.speed.AccessibleName = "";
            this.speed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speed.Font = new System.Drawing.Font("Tahoma", 12F);
            this.speed.Location = new System.Drawing.Point(446, 211);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(355, 27);
            this.speed.TabIndex = 7;
            this.speed.TextChanged += new System.EventHandler(this.speed_TextChanged);
            // 
            // horsepower
            // 
            this.horsepower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.horsepower.Font = new System.Drawing.Font("Tahoma", 12F);
            this.horsepower.Location = new System.Drawing.Point(40, 282);
            this.horsepower.Name = "horsepower";
            this.horsepower.Size = new System.Drawing.Size(341, 27);
            this.horsepower.TabIndex = 9;
            this.horsepower.TextChanged += new System.EventHandler(this.horsepower_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Horsepower";
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price.Font = new System.Drawing.Font("Tahoma", 12F);
            this.price.Location = new System.Drawing.Point(446, 282);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(355, 27);
            this.price.TabIndex = 11;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(442, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add.BackColor = System.Drawing.Color.White;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Location = new System.Drawing.Point(361, 474);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(111, 31);
            this.add.TabIndex = 12;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // showcars
            // 
            this.showcars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showcars.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showcars.Location = new System.Drawing.Point(704, 640);
            this.showcars.Name = "showcars";
            this.showcars.Size = new System.Drawing.Size(111, 31);
            this.showcars.TabIndex = 13;
            this.showcars.Text = "Show All Cars";
            this.showcars.UseVisualStyleBackColor = true;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Exitbutton.Location = new System.Drawing.Point(21, 640);
            this.Exitbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(111, 31);
            this.Exitbutton.TabIndex = 15;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            // 
            // addimage
            // 
            this.addimage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addimage.AutoSize = true;
            this.addimage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addimage.BackColor = System.Drawing.Color.White;
            this.addimage.ForeColor = System.Drawing.Color.Black;
            this.addimage.Location = new System.Drawing.Point(446, 349);
            this.addimage.Name = "addimage";
            this.addimage.Size = new System.Drawing.Size(83, 23);
            this.addimage.TabIndex = 16;
            this.addimage.Text = "Upload Image";
            this.addimage.UseVisualStyleBackColor = false;
            this.addimage.Click += new System.EventHandler(this.addimage_Click);
            // 
            // imageaddress
            // 
            this.imageaddress.Location = new System.Drawing.Point(543, 448);
            this.imageaddress.Name = "imageaddress";
            this.imageaddress.Size = new System.Drawing.Size(161, 20);
            this.imageaddress.TabIndex = 17;
            this.imageaddress.Visible = false;
            // 
            // displayimage
            // 
            this.displayimage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayimage.Location = new System.Drawing.Point(542, 328);
            this.displayimage.Name = "displayimage";
            this.displayimage.Size = new System.Drawing.Size(162, 116);
            this.displayimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displayimage.TabIndex = 19;
            this.displayimage.TabStop = false;
            // 
            // warningspeed
            // 
            this.warningspeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.warningspeed.AutoSize = true;
            this.warningspeed.ForeColor = System.Drawing.Color.DarkRed;
            this.warningspeed.Location = new System.Drawing.Point(540, 240);
            this.warningspeed.Name = "warningspeed";
            this.warningspeed.Size = new System.Drawing.Size(183, 13);
            this.warningspeed.TabIndex = 21;
            this.warningspeed.Text = "Max speed must be more than zero !";
            this.warningspeed.Visible = false;
            // 
            // warningpower
            // 
            this.warningpower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.warningpower.AutoSize = true;
            this.warningpower.ForeColor = System.Drawing.Color.DarkRed;
            this.warningpower.Location = new System.Drawing.Point(136, 311);
            this.warningpower.Name = "warningpower";
            this.warningpower.Size = new System.Drawing.Size(192, 13);
            this.warningpower.TabIndex = 22;
            this.warningpower.Text = "Horse power must be more than zero !";
            this.warningpower.Visible = false;
            // 
            // warningprice
            // 
            this.warningprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.warningprice.AutoSize = true;
            this.warningprice.ForeColor = System.Drawing.Color.DarkRed;
            this.warningprice.Location = new System.Drawing.Point(540, 311);
            this.warningprice.Name = "warningprice";
            this.warningprice.Size = new System.Drawing.Size(154, 13);
            this.warningprice.TabIndex = 23;
            this.warningprice.Text = "Price must be more than zero !";
            this.warningprice.Visible = false;
            // 
            // colordisplay
            // 
            this.colordisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colordisplay.Location = new System.Drawing.Point(186, 348);
            this.colordisplay.Name = "colordisplay";
            this.colordisplay.Size = new System.Drawing.Size(73, 33);
            this.colordisplay.TabIndex = 25;
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(26, 557);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(88, 28);
            this.Exit.TabIndex = 28;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ShowCras
            // 
            this.ShowCras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowCras.BackColor = System.Drawing.Color.White;
            this.ShowCras.ForeColor = System.Drawing.Color.Black;
            this.ShowCras.Location = new System.Drawing.Point(712, 557);
            this.ShowCras.Margin = new System.Windows.Forms.Padding(2);
            this.ShowCras.Name = "ShowCras";
            this.ShowCras.Size = new System.Drawing.Size(88, 28);
            this.ShowCras.TabIndex = 29;
            this.ShowCras.Text = "Show All Cars";
            this.ShowCras.UseVisualStyleBackColor = false;
            this.ShowCras.Click += new System.EventHandler(this.ShowCras_Click);
            // 
            // addfilebtn
            // 
            this.addfilebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addfilebtn.BackColor = System.Drawing.Color.White;
            this.addfilebtn.ForeColor = System.Drawing.Color.Black;
            this.addfilebtn.Location = new System.Drawing.Point(238, 557);
            this.addfilebtn.Name = "addfilebtn";
            this.addfilebtn.Size = new System.Drawing.Size(143, 23);
            this.addfilebtn.TabIndex = 30;
            this.addfilebtn.Text = "Write Information to file";
            this.addfilebtn.UseVisualStyleBackColor = false;
            this.addfilebtn.Click += new System.EventHandler(this.addfilebtn_Click);
            // 
            // getfilebtn
            // 
            this.getfilebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getfilebtn.BackColor = System.Drawing.Color.White;
            this.getfilebtn.ForeColor = System.Drawing.Color.Black;
            this.getfilebtn.Location = new System.Drawing.Point(446, 557);
            this.getfilebtn.Name = "getfilebtn";
            this.getfilebtn.Size = new System.Drawing.Size(166, 23);
            this.getfilebtn.TabIndex = 31;
            this.getfilebtn.Text = "Read Information from file";
            this.getfilebtn.UseVisualStyleBackColor = false;
            this.getfilebtn.Click += new System.EventHandler(this.getfilebtn_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // showAllCarsToolStripMenuItem
            // 
            this.showAllCarsToolStripMenuItem.Name = "showAllCarsToolStripMenuItem";
            this.showAllCarsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.showAllCarsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.showAllCarsToolStripMenuItem.Text = "&Show All Cars";
            this.showAllCarsToolStripMenuItem.Click += new System.EventHandler(this.showAllCarsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.showAllCarsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AcceptButton = this.add;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(827, 609);
            this.Controls.Add(this.getfilebtn);
            this.Controls.Add(this.addfilebtn);
            this.Controls.Add(this.ShowCras);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.colordisplay);
            this.Controls.Add(this.warningprice);
            this.Controls.Add(this.warningpower);
            this.Controls.Add(this.warningspeed);
            this.Controls.Add(this.displayimage);
            this.Controls.Add(this.imageaddress);
            this.Controls.Add(this.addimage);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.showcars);
            this.Controls.Add(this.add);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.horsepower);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.choosecolor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carmodel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosecolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayimage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox carmodel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox choosecolor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.TextBox horsepower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button showcars;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button addimage;
        private System.Windows.Forms.TextBox imageaddress;
        private System.Windows.Forms.PictureBox displayimage;
        private System.Windows.Forms.Label warningspeed;
        private System.Windows.Forms.Label warningpower;
        private System.Windows.Forms.Label warningprice;
        private System.Windows.Forms.Panel colordisplay;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ShowCras;
        private System.Windows.Forms.Button addfilebtn;
        private System.Windows.Forms.Button getfilebtn;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

