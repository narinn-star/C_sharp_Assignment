using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203179_이나린_과제1
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
                ulong num01 = ulong.Parse(textBox1.Text);
                ulong num02 = ulong.Parse(textBox2.Text);
                string output = "";
                ulong sum01 = 0;
                ulong sum02 = 1;

                if (ulong.Parse(textBox1.Text) > ulong.Parse(textBox2.Text))
                {
                    label4.Text = "시작값은 마지막값 보다 작은 값이어야 합니다!";
                }
                else if (ulong.Parse(textBox1.Text) == 0)
                {
                    label4.Text = "시작값은 0보다 큰 값이어야 합니다!";
                }
                else if (ulong.Parse(textBox2.Text) >= 21)
                {
                    label4.Text = "마지막값은 21보다 작은 값이어야 합니다!";
                }
                else
                {
                    for (ulong i = num01; i <= num02; i++)
                    {
                        sum01 = sum01 + i;
                        sum02 = sum02 * i; // sum02 가 0이면 *를 실행했을 때 무조건 0이 나오게 된다.
                    }
                    output = num01 + "부터" + num02 + "까지의 합은 " + sum01 + "\n" + "곱은 " + sum02 + "입니다.";
                    label4.Text = output;
                }
            }
            catch (Exception ee)
            {
                if (textBox1.Text == "")
                    label4.Text = "시작값을 입력하세요!";
                else if (textBox2.Text == "")
                    label4.Text = "마지막값을 입력하세요!";
                else
                    label4.Text = ee.Message;
            }
        }
    }
}
