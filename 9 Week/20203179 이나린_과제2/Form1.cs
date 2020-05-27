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
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                int sum = 0;

                if (num >= 2 && num < 50000)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        sum += i;
                    }
                    count += 1;
                    label2.Text = "합 : " + sum;
                    label3.Text = "프로그램 실행 후 현재까지 이용횟수 : " + count + "회";
                }
                else label2.Text = "1~50000 사이의 수만 입력해 주세요";
            }
            catch (Exception ee)
            {
                label2.Text = ee.Message;
            }


        }
    }
}
