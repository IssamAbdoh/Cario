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
using System.Text.RegularExpressions;


namespace CarsSystem
{
    public partial class Form1 : Form
    {
        SQLiteConnection cardb;//create connection to the database
        car c = new car();//our beloved object
        readonly string textFile = @"carsfile.txt";//our file path
        
        public Form1()
        {
            InitializeComponent();

            cardb = new SQLiteConnection("Data Source=cardb.sqlite ; version = 3 ;");
            cardb.Open();

            if (!File.Exists(textFile))
            {
                File.WriteAllText("carsfile.txt","");  // Create a file and write the content of writeText to it
            }
        }

        private void choosecolorbox_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            if (col.ShowDialog() == DialogResult.OK)
            {
                choosecolor.BackColor = col.Color;//r255 b255 g255 a255
                int icol = (col.Color.A << 24) | (col.Color.R << 16) | (col.Color.G << 8) | col.Color.B;
                c.COLOR = icol.ToString();
            }
        }


        private void add_Click(object sender, EventArgs e)
        {
            addition();
        }

        public void addition()//add a new car to the database
        {
            if (validation())//validate the input before insertion
            {
                if (imageaddress.Text == "")
                {
                    MessageBox.Show("Insert an image !");
                    return;
                }
                File.Copy(imageaddress.Text, Path.Combine(@"Images", Path.GetFileName(imageaddress.Text)), true);//True is for OVERWRITTING , so the image cannot be duplicated .

                c.Model = carmodel.Text;

                int x = int.Parse(horsepower.Text);
                c.Power = x;

                x = int.Parse(speed.Text);
                c.Speed = x;

                double y = double.Parse(price.Text);
                c.Price = y;
                try
                {
                    string sql = "insert into cartable(model,maxspeed,horsepower,price,color,pic) values('" + c.Model + "'," + c.Speed + "," + c.Power + "," + c.Price + ",'" + c.COLOR + "','" + imageaddress.Text + "');";
                    SQLiteCommand command = new SQLiteCommand(sql, cardb);
                    int exnq = command.ExecuteNonQuery();
                    MessageBox.Show("The item has been inserted successfully");
                    carmodel.Text = "";
                    speed.Text = "";
                    price.Text = "";
                    horsepower.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().ToString(), "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void addimage_Click(object sender, EventArgs e)//adding an image for our car
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";

            fileOpen.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                displayimage.Image = new Bitmap(fileOpen.FileName);//display the selected image in the pictureBox
                imageaddress.Text = fileOpen.FileName;//
            }
        }

        private void showbtn_Click(object sender, EventArgs e)//Displays a list of added cars  , go to form2
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void speed_TextChanged(object sender, EventArgs e)//validate the speed textbox value
        {
            
            string s = speed.Text;
            Regex regex1 = new Regex(@"[0-9]+.*[0-9]*");//A* ={,A,AA}   |||| A+ ={A,AA} 

            if (regex1.IsMatch(s))
            {
                if (s != "" && s[0] != '-')//double check on validation
                {
                    int x = int.Parse(speed.Text);
                    if (int.TryParse(speed.Text, out x))
                    {
                        if (x == 0)
                        {

                            warningspeed.Text = "speed must be more than zero!";
                            warningspeed.Visible = true;
                        }
                        else
                        {
                            warningspeed.Visible = false;
                        }
                    }
                }
                else if (s != "" && s[0] == '-')
                {
                    warningspeed.Text = "Horse power must be more than zero!";
                    warningspeed.Visible = true;
                }
                else if (s == "")
                {
                    warningspeed.Text = "YOU MUST enter number !";
                    warningspeed.Visible = true;
                }
            }
            else
            {
                warningspeed.Text = "YOU MUST enter a number !";
                warningspeed.Visible = true;
            }
        }

        private void horsepower_TextChanged(object sender, EventArgs e)//validate the horse power textbox value
        {
            string s = horsepower.Text;
            Regex regex1 = new Regex(@"[0-9]+");
            if (regex1.IsMatch(s))
            {
                if (s != "" && s[0] != '-')
                {
                    int x = int.Parse(horsepower.Text);
                    if (int.TryParse(horsepower.Text, out x))
                    {
                        if (x == 0)
                        {
                            warningpower.Text = "Horse power must be more than zero!";
                            warningpower.Visible = true;
                        }
                        else
                        {
                            warningpower.Visible = false;
                        }
                    }
                }
                else if (s != "" && s[0] == '-')
                {
                    warningpower.Text = "Horse power must be more than zero!";
                    warningpower.Visible = true;
                }
                else if (s == "")
                {
                    warningpower.Text = "YOU MUST enter number !";
                    warningpower.Visible = true;
                }
            }
            else
            {
                warningpower.Text = "YOU MUST enter a number !";
                warningpower.Visible = true;
            }
        }

        private void price_TextChanged(object sender, EventArgs e)//validate the price textbox value
        {
            string s = price.Text;
            Regex regex1 = new Regex(@"[0-9]+.*[0-9]*");//1.123564
            if (regex1.IsMatch(s))
            {
                if (s != "" && s[0] != '-')
                {
                    double x = double.Parse(price.Text);
                    if (double.TryParse(price.Text, out x))
                    {
                        if (x == 0)
                        {
                            warningprice.Text = "Horse power must be more than zero!";
                            warningprice.Visible = true;
                        }
                        else
                        {
                            warningprice.Visible = false;
                        }
                    }
                }
                else if (s != "" && s[0] == '-')
                {
                    warningprice.Text = "price must be more than zero!";
                    warningprice.Visible = true;
                }
                else if (s == "")
                {
                    warningprice.Text = "YOU MUST enter number !";
                    warningprice.Visible = true;
                }
            }
            else
            {
                warningprice.Text = "YOU MUST enter a number !";
                warningprice.Visible = true;
            }
        }

        private void ShowCras_Click(object sender, EventArgs e)//a shortcut to form2
        {
            Form2 f2 = new Form2(this);
            f2.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            try
            {
                cardb.Close();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(), "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void showAllCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private bool validation()//validate all the cars properties
        {
            if (warningpower.Visible || warningprice.Visible || warningspeed.Visible || speed.Text == "" || horsepower.Text == "" || price.Text == "" || carmodel.Text =="")
            {
                MessageBox.Show("You have to satisfy all conditions in order to add a car");
                return false;
            }
            return true;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addition();
        }

        private void addfilebtn_Click(object sender, EventArgs e)
        {
            // write car info into file ,  line by line    
            string s1, s2, s3, s4;
            s1 = carmodel.Text;
            s2 = speed.Text;
            s3 = horsepower.Text;
            s4 = price.Text;
            using (var sw = new StreamWriter(textFile))
            {
                sw.WriteLine($"{s1}\n{s2}\n{s3}\n{s4}\n");
            }
            MessageBox.Show("The information have been written into the file .");
        }

        private void getfilebtn_Click(object sender, EventArgs e)
        {
            // Read car info into file line by line    
            using (StreamReader file = new StreamReader(textFile))
            {
                int counter = 0;
                string ln;
                
                while ((ln = file.ReadLine()) != null)
                {
                    //Console.WriteLine(ln);
                    counter++;
                    if (counter == 1)
                    {
                        carmodel.Text = ln;
                    }
                    else if (counter == 2)
                    {
                        speed.Text = ln;
                    }
                    else if (counter == 3)
                    {
                        horsepower.Text = ln;
                    }
                    else if (counter == 4)
                    {
                        price.Text = ln;
                    }
                    else
                    {
                        break;
                    }
                }
                MessageBox.Show("The information have been copied from the file .");
                file.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void carmodel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
