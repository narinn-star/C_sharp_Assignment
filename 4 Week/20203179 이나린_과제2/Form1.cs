using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203179_이나린_과제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
            label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                double num02 = double.Parse(textBox2.Text);

                if (num == 1)
                {
                    num02 = num02 * 3.28;
                    textBox3.Text = num02.ToString();
                    label6.Text = "feet";
                }
                else if (num == 2)
                {
                    num02 = num02 / 3.28;
                    textBox3.Text = num02.ToString();
                    label6.Text = "meter";
                }
                else textBox1.Text = "1 또는 2를 입력하세요.";
              
            }
            catch (Exception ee)
            {
                if (textBox1.Text == "")
                    textBox1.Text = "1 또는 2를 입력하세요!";

                else if (textBox2.Text == "")
                    textBox2.Text = "환산할 수를 입력하세요!";

                else 
                    textBox3.Text = ee.Message;
            }
        }
    }
}
