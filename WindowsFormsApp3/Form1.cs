using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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
            double width = double.Parse(textBox2.Text);
            double length = double.Parse(textBox1.Text);
            double height  = double.Parse(textBox3.Text);
            double area = 2 * (length * width + length * height + width * height);
            label5.Text = "area = " + area;


        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double width = double.Parse(textBox2.Text);
            double length = double.Parse(textBox1.Text);
            double height = double.Parse(textBox3.Text);
            double volume = length * width * height;
            label4.Text = "volume = " + volume;


                
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox4.Text);
            double surface_area = 4 * 3.14159 * radius * radius;
            label6.Text = "surface area  = " + surface_area;

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox4.Text);
            double volume = 4 * 3.14159 * radius * radius * radius / 3;
            label7.Text = "volume =" + volume;
        }
    }
}
