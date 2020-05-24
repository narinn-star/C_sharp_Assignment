using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203179_이나린_과제3
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
                int sum = 0;
                string result = "";
                if (snum <= fnum) 
                {
                    if (snum <= 9 && snum >= 2 )
                    {
                        if (fnum <= 9 && fnum >= 2)
                        {
                            for (int i = snum; i <= fnum; i++)
                            {
                                for (int j = 2; j <= 9; j++)
                                {
                                    sum = i * j;
                                    result = result + i + "  *  " + j + "  =  " + sum + "\n";
                                }
                                result += "\n";
                            }
                            label4.Text = "구구단 " + snum + "부터 " + fnum + " 단까지 입니다!\n\n" + result + "\n\n";
                        }
                        else
                        {
                            label4.Text = "2와 9 사이의 수를 입력 하세요!";
                        }
                    }
                    else
                    {
                        label4.Text = "2와 9 사이의 수를 입력 하세요!";
                    }
                }
                else
                {
                    label4.Text = "시작 단수가 마지막 단수보다 작거나 같아야합니다!";
                }
            }
            catch (Exception ee)
            {
                label4.Text = ee.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "5";
            textBox2.Text = "9";
        }
    }
}
