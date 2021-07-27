
namespace CarsSystem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.prevbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectedid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillterbtn = new System.Windows.Forms.Button();
            this.carmodelup = new System.Windows.Forms.TextBox();
            this.speedup = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetbtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.choosecolorup = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.priceup = new System.Windows.Forms.TextBox();
            this.powerup = new System.Windows.Forms.TextBox();
            this.ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureCol = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choosecolorup)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(452, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deletebtn.Location = new System.Drawing.Point(190, 119);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(83, 23);
            this.deletebtn.TabIndex = 13;
            this.deletebtn.Text = "Delete Selected";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // prevbtn
            // 
            this.prevbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prevbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prevbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevbtn.ForeColor = System.Drawing.Color.Black;
            this.prevbtn.Location = new System.Drawing.Point(27, 535);
            this.prevbtn.Name = "prevbtn";
            this.prevbtn.Size = new System.Drawing.Size(94, 31);
            this.prevbtn.TabIndex = 14;
            this.prevbtn.Text = "Previous";
            this.prevbtn.UseVisualStyleBackColor = true;
            this.prevbtn.Click += new System.EventHandler(this.prevbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ids,
            this.model,
            this.speed,
            this.power,
            this.price,
            this.colorcol,
            this.pictureCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 140;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 147);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // selectedid
            // 
            this.selectedid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectedid.Location = new System.Drawing.Point(49, 14);
            this.selectedid.Name = "selectedid";
            this.selectedid.Size = new System.Drawing.Size(100, 20);
            this.selectedid.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = " ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1141, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.previousToolStripMenuItem.Text = "&Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // fillterbtn
            // 
            this.fillterbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillterbtn.Location = new System.Drawing.Point(190, 28);
            this.fillterbtn.Name = "fillterbtn";
            this.fillterbtn.Size = new System.Drawing.Size(83, 23);
            this.fillterbtn.TabIndex = 20;
            this.fillterbtn.Text = "Fillter";
            this.fillterbtn.UseVisualStyleBackColor = true;
            this.fillterbtn.Click += new System.EventHandler(this.fillterbtn_Click_1);
            // 
            // carmodelup
            // 
            this.carmodelup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carmodelup.Location = new System.Drawing.Point(49, 46);
            this.carmodelup.Name = "carmodelup";
            this.carmodelup.Size = new System.Drawing.Size(100, 20);
            this.carmodelup.TabIndex = 22;
            // 
            // speedup
            // 
            this.speedup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedup.Location = new System.Drawing.Point(48, 80);
            this.speedup.Name = "speedup";
            this.speedup.Size = new System.Drawing.Size(100, 20);
            this.speedup.TabIndex = 23;
            // 
            // updatebtn
            // 
            this.updatebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatebtn.Location = new System.Drawing.Point(190, 74);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(83, 23);
            this.updatebtn.TabIndex = 29;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.resetbtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.selectedid);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.fillterbtn);
            this.panel2.Controls.Add(this.updatebtn);
            this.panel2.Controls.Add(this.choosecolorup);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.deletebtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.priceup);
            this.panel2.Controls.Add(this.powerup);
            this.panel2.Controls.Add(this.speedup);
            this.panel2.Controls.Add(this.carmodelup);
            this.panel2.Location = new System.Drawing.Point(717, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 242);
            this.panel2.TabIndex = 24;
            // 
            // resetbtn
            // 
            this.resetbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetbtn.Location = new System.Drawing.Point(315, 206);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 23);
            this.resetbtn.TabIndex = 35;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox1.Location = new System.Drawing.Point(140, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Confirm Changing color";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // choosecolorup
            // 
            this.choosecolorup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.choosecolorup.BackColor = System.Drawing.SystemColors.MenuText;
            this.choosecolorup.Location = new System.Drawing.Point(49, 193);
            this.choosecolorup.Name = "choosecolorup";
            this.choosecolorup.Size = new System.Drawing.Size(73, 33);
            this.choosecolorup.TabIndex = 33;
            this.choosecolorup.TabStop = false;
            this.choosecolorup.Click += new System.EventHandler(this.choosecolorup_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Color";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Price";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Power";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Speed";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Model";
            // 
            // priceup
            // 
            this.priceup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceup.Location = new System.Drawing.Point(48, 155);
            this.priceup.Name = "priceup";
            this.priceup.Size = new System.Drawing.Size(100, 20);
            this.priceup.TabIndex = 26;
            // 
            // powerup
            // 
            this.powerup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powerup.Location = new System.Drawing.Point(48, 117);
            this.powerup.Name = "powerup";
            this.powerup.Size = new System.Drawing.Size(100, 20);
            this.powerup.TabIndex = 25;
            // 
            // ids
            // 
            this.ids.DataPropertyName = "id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ids.DefaultCellStyle = dataGridViewCellStyle1;
            this.ids.FillWeight = 98.90183F;
            this.ids.HeaderText = "ID";
            this.ids.MinimumWidth = 6;
            this.ids.Name = "ids";
            this.ids.ReadOnly = true;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.model.DefaultCellStyle = dataGridViewCellStyle2;
            this.model.FillWeight = 103.0595F;
            this.model.HeaderText = "Car Model";
            this.model.MinimumWidth = 6;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // speed
            // 
            this.speed.DataPropertyName = "maxspeed";
            this.speed.FillWeight = 102.929F;
            this.speed.HeaderText = "Max Speed";
            this.speed.MinimumWidth = 6;
            this.speed.Name = "speed";
            this.speed.ReadOnly = true;
            // 
            // power
            // 
            this.power.DataPropertyName = "horsepower";
            this.power.FillWeight = 96.9763F;
            this.power.HeaderText = "Horse Power";
            this.power.MinimumWidth = 6;
            this.power.Name = "power";
            this.power.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.FillWeight = 97.30605F;
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colorcol
            // 
            this.colorcol.DataPropertyName = "color";
            this.colorcol.FillWeight = 100.8274F;
            this.colorcol.HeaderText = "Color";
            this.colorcol.MinimumWidth = 6;
            this.colorcol.Name = "colorcol";
            this.colorcol.ReadOnly = true;
            this.colorcol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colorcol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pictureCol
            // 
            this.pictureCol.DataPropertyName = "pict";
            this.pictureCol.HeaderText = "Picture";
            this.pictureCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.pictureCol.MinimumWidth = 6;
            this.pictureCol.Name = "pictureCol";
            this.pictureCol.ReadOnly = true;
            this.pictureCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1141, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prevbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Available Cars";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choosecolorup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button prevbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox selectedid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.Button fillterbtn;
        private System.Windows.Forms.TextBox speedup;
        private System.Windows.Forms.TextBox carmodelup;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox powerup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceup;
        private System.Windows.Forms.PictureBox choosecolorup;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ids;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn power;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorcol;
        private System.Windows.Forms.DataGridViewImageColumn pictureCol;
    }
}