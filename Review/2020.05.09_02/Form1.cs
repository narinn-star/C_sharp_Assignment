using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._05._09_2
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
                int month = int.Parse(textBox1.Text);


                switch (month)
                {
                    case 1:
                        label3.Text = "입력값 " + month + "-> January";
                        break;
                    case 2:
                        label3.Text = "입력값 " + month + "-> February";
                        break;
                    case 3:
                        label3.Text = "입력값 " + month + "-> March";
                        break;
                    case 4:
                        label3.Text = "입력값 " + month + "-> April";
                        break;
                    case 5:
                        label3.Text = "입력값 " + month + "-> May";
                        break;
                    case 6:
                        label3.Text = "입력값 " + month + "-> June";
                        break;
                    case 7:
                        label3.Text = "입력값 " + month + "-> July";
                        break;
                    case 8:
                        label3.Text = "입력값 " + month + "-> August";
                        break;
                    case 9:
                        label3.Text = "입력값 " + month + "-> September";
                        break;
                    case 10:
                        label3.Text = "입력값 " + month + "-> October";
                        break;
                    case 11:
                        label3.Text = "입력값 " + month + "-> November";
                        break;
                    case 12:
                        label3.Text = "입력값 " + month + "-> December";
                        break;
                    default:
                        label3.Text = "해당하는 Month가 없으니" + "\n" + "1~12 사이의 숫자를 입력하세요";
                        break;
                }
            }
            catch (Exception ee)
            {
                textBox1.Text = ee.Message;
            }
        }
    }
}
