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
                int month = int.Parse(textBox1.Text);

                if (month >= 1 && month <= 12)
                {
                    switch (month)
                    {
                        case 1:
                            label3.Text = "입력값 1 -> January";
                            break;
                        case 2:
                            label3.Text = "입력값 2 -> February";
                            break;
                        case 3:
                            label3.Text = "입력값 3 -> March";
                            break;
                        case 4:
                            label3.Text = "입력값 4 -> April";
                            break;
                        case 5:
                            label3.Text = "입력값 5 -> May";
                            break;
                        case 6:
                            label3.Text = "입력값 6 -> June";
                            break;
                        case 7:
                            label3.Text = "입력값 7 -> July";
                            break;
                        case 8:
                            label3.Text = "입력값 8 -> August";
                            break;
                        case 9:
                            label3.Text = "입력값 9 -> September";
                            break;
                        case 10:
                            label3.Text = "입력값 10 -> October";
                            break;
                        case 11:
                            label3.Text = "입력값 11 -> November";
                            break;
                        case 12:
                            label3.Text = "입력값 12 -> December";
                            break;
                    }
                }
                else
                {
                    label3.Text = "해당하는 Month가 없으니" +
                                "\n" + "1~12 사이의 숫자를 입력하세요";
                }

            }
            catch (Exception ee)
            {
                textBox1.Text = ee.Message;
            }
        }
    }
}
