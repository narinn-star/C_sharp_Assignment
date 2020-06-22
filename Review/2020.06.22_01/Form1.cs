using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._06._22_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int snum = int.Parse(textBox1.Text);
                int fnum = int.Parse(textBox2.Text);

                string result = "";
                if (!(snum < 2 || fnum > 9))
                {
                    for (int i = snum; i <= fnum; i++)
                    {
                        result += "\n\n";
                        for (int j = 2; j <= 9; j++)
                        {
                            int sum = 0;
                            sum = i * j;
                            result += i + " * " + j + " = " + sum + "\n";

                        }
                        label4.Text = "구구단 " + snum + "부터 " + fnum + " 단까지 입니다!" + result;
                    }
                }
                else
                    label4.Text = "2와 9사이의 수를 입력하세요!";
            }
            catch (Exception ee)
            {
                label4.Text = ee.Message;
            }
            
        }
    }
}
