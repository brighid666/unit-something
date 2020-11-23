using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unit_something
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //read text from txtboxes
                double Length = double.Parse(textBox1.Text);
                double width = double.Parse(textBox2.Text);
                double height = double.Parse(textBox3.Text);
                //calculate the voulume 
                double volume = (Length * width * height);
                //output answears label 
                label1.Text = "volume is " + volume;
            }
            catch
            {
                MessageBox.Show("COMPUTER SAYS NOOO");
            }

            try
            {
                //doing the surface area 
                double Length = double.Parse(textBox4.Text);
                double width = double.Parse(textBox5.Text);
                double height = double.Parse(textBox6.Text);
                double surface = 2 * Length * height + 2 * Length * width + 2 * width * height;
                label2.Text = "surface area = " + surface;
            }
            catch
            {

            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            try


            {
                //read text from textboxes
                double radius = double.Parse(textBox1.Text);


            }
            catch
            {

            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
