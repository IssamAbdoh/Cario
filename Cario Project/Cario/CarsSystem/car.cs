using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace CarsSystem
{
    class car
    {
        private string model;
        public string Model { get; set; }

        private int power;
        public int Power { get; set; }

        private int speed;
        public int Speed { get; set; }

        private double price;
        public double Price { get; set; }

        private string color;
        public string COLOR { get; set; }
    }
}
