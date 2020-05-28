using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203179_이나린_과제1
{
    public partial class Form1 : Form
    {
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            result = 0;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(textBox1.Text);
                result += num;
                label1.Text = result.ToString();
            }
            catch(Exception ee)
            {
                label1.Text = ee.Message;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(textBox1.Text);
                result -= num;
                label1.Text = result.ToString();
            }
            catch (Exception ee)
            {
                label1.Text = ee.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(textBox1.Text);
                result = result * num;
                label1.Text = result.ToString();
            }
            catch (Exception ee)
            {
                label1.Text = ee.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "0")
                {
                    double num = double.Parse(textBox1.Text);
                    result = result / num;
                    label1.Text = result.ToString();
                }
                               
            }
            catch(Exception ee)
            {               
                label1.Text = ee.Message;
            }
        }
    }
}
