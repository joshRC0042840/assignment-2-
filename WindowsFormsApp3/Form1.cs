﻿using System;
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
            try// the try/catch command is there to give an error message if the code is being used incorrectly 
            {

            
            double width = double.Parse(textBox2.Text);//this is where the user will input the width
            double length = double.Parse(textBox1.Text);//this is where the user will input the length 
            double height = double.Parse(textBox3.Text);//this is where the user will input the height 
            double area = 2 * (length * width + length * height + width * height);// this piece of cod edoes the calculation for area for the intergers you put in
            label5.Text = "area = " + area + " cm2";//this tells the computer where to display the answer with correct units 
            }
            catch
            {
                MessageBox.Show("there has been an error");//displays an error message to the user 
            }
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
            try
            {


                double width = double.Parse(textBox2.Text);//this is where the user will input the width 
                double length = double.Parse(textBox1.Text);//this is where the user will input the length 
                double height = double.Parse(textBox3.Text);//this is where the user will input the height 
                double volume = length * width * height;// this does the calculation for volume 
                label4.Text = "volume = " + volume + " cm3";// thi shows the computer where to input the answer with correct units 

            }
            catch
            {
                MessageBox.Show("there was an error");
            }
                
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
            try
            {


                double radius = double.Parse(textBox4.Text);//this is where the user will input the radius
                double surface_area = 4 * 3.14159 * radius * radius;// this is where the users inputs will be calculated to solve the surface area 
                label6.Text = "surface area  = " + surface_area + "cm2";//this shows the computer where to show the answer eith correct units 
            }
            catch
            {
                MessageBox.Show("there was an error");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        { try
            {


                double radius = double.Parse(textBox4.Text);//this is where the user will input the radius
                double volume = 4 * 3.14159 * radius * radius * radius / 3.0;
                label7.Text = "volume =" + volume + "cm3";
            }
            catch
            {
                MessageBox.Show("there was an error");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(textBox5.Text);
                double height = double.Parse(textBox6.Text);//this is where the user will input the radius
                double volume = 1.0 / 3.0 * 3.14159 * radius * radius*height;//this is where the computer will calculate the volume by using the given user inputs.
                label11.Text = "volume =" + volume + "cm3";//this tells the computer where to display the answer with the correct units 
            }
            catch
            {
                MessageBox.Show("there was an error");
            }
            
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(textBox5.Text);//this is where the user will input the radius
                double height = double.Parse(textBox6.Text);//this is where the user will input the height
                double surface_area = 3.141519 * radius * (radius + Math.Sqrt(height * height + radius * radius));//this is where the computer will calculate the suface area with the units given to it by the user
                label12.Text = "surface area =" + surface_area + "cm2";// this tells the computer where to display the answer to the question with the correct units 
            }
            catch
            {
                MessageBox.Show("there was an error");
            }
            
        }
    }
}
