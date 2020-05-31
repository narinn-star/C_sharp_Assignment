using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._05._31_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                string result = "";

                if (num > 20 || num < 1)
                {
                    label3.Text = "1과 20 사이의 수를 입력 하세요!";
                }
                else
                {
                    for(int i = 1; i <= num; i++)
                    {
                        if (i == 8 || i == 15)
                            result += "\n\n                 ";

                        result += i + ", ";
                    }
                    label3.Text = "수행된 i 값 : " + result.TrimEnd(',', ' ');
                }
            }
            catch (Exception ee)
            {
                label3.Text = ee.Message + "\n 1과 20 사이의 정수를 입력 하세요!";
            }
        }
    }
}
