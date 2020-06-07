using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._06._07_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "결과가 나오는 곳입니다";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                uint Max = uint.Parse(textBox1.Text);
                uint Plus = uint.Parse(textBox2.Text);
                double sum = 0;
                double sum02 = 1;

                if (Max < Plus) label4.Text = "증가값은 최대값보다 작은 수를 입력하세요!";
                else
                {
                    for (uint i = 1; i <= Max; i += Plus)
                    {
                        sum += i;
                        sum02 = sum02 * i;
                    }
                    label4.Text = "1 부터 입력된 최대 값: " + Max + " 까지   증가값: " + Plus + " 로 반복한 결과"
                        + "\n\n<< i 의 더하기 합계 값: " + sum + " >>"
                        + "\n\n<< i 의 곱하기 합계 값: " + sum02 + " >>";
                }
            }
            catch (Exception ee)
            {
                label4.Text = ee.Message + "\n다시 입력하세요!";
            }
        }
    }
}
