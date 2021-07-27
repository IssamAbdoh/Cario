using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using Microsoft.VisualBasic;
using System.Collections;
using System.Diagnostics;


namespace CarsSystem
{
    public partial class Form2 : Form
    {
        Form opener;
        SQLiteConnection con;

        public Form2(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void Previousbtn_Click(object sender, EventArgs e)//get back to form1
        {

            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source=cardb.sqlite ; version = 3 ;");
            con.Open();
            refresh();
            this.CenterToScreen();
        }

        private void deletebtn_Click(object sender, EventArgs e)//delete the selected cars
        {
            string s = "delete from cartable where ";//"delete from cartable where speed = 1000 and horsepower = 500"
            string h = "";
            if (selectedid.Text != "")
            {
                s += "id = " + int.Parse(selectedid.Text);
                goto hoon;
            }
            if (carmodelup.Text != "")
            {
                if (h != "")
                {
                    h += " and ";
                }
                h += " model = '" + carmodelup.Text + "'";
            }
            if (speedup.Text != "")
            {
                if (h != "")
                {
                    h += " and ";
                }
                h += "maxspeed = '" + int.Parse(speedup.Text) + "'";
            }
            if (powerup.Text != "")
            {
                if (h != "")
                {
                    h += " and ";
                }
                h += "horsepower = '" + int.Parse(powerup.Text) + "'";
            }
            if (priceup.Text != "")
            {
                if (h != "")
                {
                    h += " and ";
                }
                h += "price = '" + double.Parse(priceup.Text) + "'";
            }

        hoon:
            s += h;
            s += ";";
            SQLiteCommand command = new SQLiteCommand(s, con);
            int affectedRecord = command.ExecuteNonQuery();
            refresh();
        }

        private void refresh()
        {
            SQLiteCommand command = new SQLiteCommand("select * from cartable", con);
            SQLiteDataAdapter sd = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            dt.Columns.Add("pict", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in dt.Rows)
            {
                try
                {
                    drow["pict"] = File.ReadAllBytes(drow["pic"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().ToString(), "Invalid address of a picture !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            dataGridView1.DataSource = dt;

            dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
        }

        // Changes how cells are displayed depending on their columns and values.
        private void dataGridView1_CellFormatting(object sender,System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("colorcol"))
            {
                Int32 intValue;
                try
                {
                    if (Int32.TryParse((String)e.Value, out intValue))
                    {
                        Color color = System.Drawing.Color.FromArgb(
                                 (byte)(intValue >> 24),
                                 (byte)(intValue >> 16),
                                 (byte)(intValue >> 8),
                                 (byte)(intValue));

                        e.CellStyle.BackColor = color;
                        e.CellStyle.ForeColor = color;
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void updatebtn_Click_1(object sender, EventArgs e)//update the database value for whatever the user wants
        {
            try
            {
                int id = int.Parse(selectedid.Text.ToString());//select the car that you want to edit

                //Make changes on the car 
                if (carmodelup.Text != "")
                {
                    string txtQuery = "update cartable set model='" + carmodelup.Text + "' WHERE id = " + id + ";";
                    SQLiteCommand command = new SQLiteCommand(txtQuery, con);
                    int affectedRecords = command.ExecuteNonQuery();
                }
                if (speedup.Text != "")
                {
                    string txtQuery = "update cartable set maxspeed='" + int.Parse(speedup.Text) + "' WHERE id = " + id + ";";
                    SQLiteCommand command = new SQLiteCommand(txtQuery, con);
                    int affectedRecords = command.ExecuteNonQuery();
                }
                if (powerup.Text != "")
                {
                    string txtQuery = "update cartable set horsepower='" + int.Parse(powerup.Text) + "' WHERE id = " + id + ";";
                    SQLiteCommand command = new SQLiteCommand(txtQuery, con);
                    int affectedRecords = command.ExecuteNonQuery();
                }
                if (priceup.Text != "")
                {
                    string txtQuery = "update cartable set price='" + double.Parse(priceup.Text) + "' WHERE id = " + id + ";";
                    SQLiteCommand command = new SQLiteCommand(txtQuery, con);
                    int affectedRecords = command.ExecuteNonQuery();
                }

                if (checkBox1.Checked)
                {
                    Color col = choosecolorup.BackColor;
                    int icol = (col.A << 24) | (col.R << 16) | (col.G << 8) | col.B;
                    string txtQuery = "update cartable set color='" + icol + "' WHERE id = " + id + ";";
                    SQLiteCommand command = new SQLiteCommand(txtQuery, con);
                    int affectedRecords = command.ExecuteNonQuery();
                }
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(), "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void choosecolorup_Click(object sender, EventArgs e)//select a color for update or search for a car
        {
            ColorDialog col = new ColorDialog();
            if (col.ShowDialog() == DialogResult.OK)
            {
                choosecolorup.BackColor = col.Color;
            }
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void fillterbtn_Click_1(object sender, EventArgs e)//filltering the data in the data grid viewer
        {
            string s = "select * from cartable WHERE ";
            string h = "";
            if (selectedid.Text != "")
            {
                s += "id = " + int.Parse(selectedid.Text);
                goto hoon;
            }
            if (carmodelup.Text != "")
            {
                h += " model = '" + carmodelup.Text + "'";
            }
            if (speedup.Text != "")
            {
                if (h != "")
                {
                    h += " and ";
                }
                h += "maxspeed = '" + int.Parse(speedup.Text) + "'";
            }
            if (powerup.Text != "")
            {
                if (h != "")
                {
                    h += " and ";
                }
                h += "horsepower = '" + int.Parse(powerup.Text) + "'";
            }
            if (priceup.Text != "")
            {
                if (h != "")
                {
                    h += " and ";
                }
                h += "price = '" + double.Parse(priceup.Text) + "'";
            }

        hoon:
            s += h;
            s += ";";

            SQLiteCommand command = new SQLiteCommand(s, con);
            SQLiteDataAdapter sd = new SQLiteDataAdapter(command);
            

            DataTable dt = new DataTable();
            sd.Fill(dt);
            

            dt.Columns.Add("pict", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in dt.Rows)
            {
                try
                {
                    drow["pict"] = File.ReadAllBytes(drow["pic"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().ToString(), "Invalid address of a picture !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            dataGridView1.DataSource = dt;
            dataGridView1.CellFormatting +=
            new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
        }


        private void resetbtn_Click_1(object sender, EventArgs e)//reset
        {
            selectedid.Text = "";
            carmodelup.Text = "";
            speedup.Text = "";
            powerup.Text = "";
            priceup.Text = "";
            refresh();
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            opener.Show();
            this.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
