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
                uint num = uint.Parse(textBox1.Text);

                bool isPrime = true;
                for(uint i = 2; i < num; i++)
                {
                    if(num % i == 0)
                    {
                        isPrime = false;
                        break;                        
                    }
                }
                if (isPrime == true) label3.Text = num + " 은 소수 입니다!";
                else label3.Text = num + " 은 소수가 아닙니다!";
            }
            catch (Exception ee)
            {
                label3.Text = ee.Message + "\n다시 입력하세요!";
            }
        }
    }
}
