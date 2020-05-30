using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203179_이나린_과제4
{
    public partial class Form1 : Form
    {
        string step = "0";
        double result = 0;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "수행단계 : ";
            label2.Text = "계산결과 : 결과가 나오는 곳입니다!";
            label3.Text = "계산 수행 횟수";
            textBox1.Text = "";
            textBox1.Focus();
            step = "";
            result = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                double num01 = double.Parse(textBox1.Text);

                step += " + " + num01;
                label1.Text = "수행단계: " + step;
                
                result += num01;
                label2.Text = "계산결과 : " + result;
                
                count += 1;
                label3.Text = "계산 수행 횟수 " + count.ToString();

                textBox1.Text = "";
                textBox1.Focus();
            }
            catch (Exception ee)
            {
                label2.Text = "계산결과 : " + ee.Message;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                double num02 = double.Parse(textBox1.Text);

                step += " - " + num02;
                label1.Text = "수행단계: " + step;

                result -= num02;
                label2.Text = "계산결과 : " + result;

                count += 1;
                label3.Text = "계산 수행 횟수 " + count.ToString();

                textBox1.Text = "";
                textBox1.Focus();
            }
            catch (Exception ee)
            {
                label2.Text = "계산결과 : " + ee.Message;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                double num03 = double.Parse(textBox1.Text);

                step += " * " + num03;
                label1.Text = "수행단계: " + step;

                result = result * num03;
                label2.Text = "계산결과 : " + result;

                count += 1;
                label3.Text = "계산 수행 횟수 " + count.ToString();

                textBox1.Text = "";
                textBox1.Focus();
            }
            catch (Exception ee)
            {
                label2.Text = "계산결과 : " + ee.Message;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                double num04 = double.Parse(textBox1.Text);

                if (textBox1.Text != "0")
                {
                    result = result / num04;
                    label2.Text = "계산결과 : " + result;

                    step += " / " + num04;
                    label1.Text = "수행단계: " + step;

                    count += 1;
                    label3.Text = "계산 수행 횟수 " + count.ToString();

                    textBox1.Text = "";
                    textBox1.Focus();
                }
                              
            }
            catch (Exception ee)
            {
                label2.Text = "계산결과 : " + ee.Message;
            }
        }
    }
}
