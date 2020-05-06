using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203179이나린2번
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
                string User01 = textBox1.Text;
                string User02 = textBox2.Text;
                if ((User01 == "가위" || User01 == "바위" || User01 == "보") && (User02 == "가위" || User02 == "바위" || User02 == "보"))
                {
                    if (User01 == "가위")
                    {
                        if (User02 == "가위")
                            label6.Text = "User1 은 -> " + textBox1.Text + "\n" + "\n" +
                                    "User2 는 -> " + textBox2.Text + "\n" + "\n" +
                                    "결과는 -> 무승부";
                        else if (User02 == "바위")
                            label6.Text = "User1 은 -> " + textBox1.Text + "\n" + "\n" +
                                    "User2 는 -> " + textBox2.Text + "\n" + "\n" +
                                    "결과는 -> User1 패";
                        else if (User02 == "보")
                            label6.Text = "User1 은 -> " + textBox1.Text + "\n" + "\n" +
                                    "User2 는 -> " + textBox2.Text + "\n" + "\n" +
                                    "결과는 -> User1 승";
                    }

                    else if (User01 == "바위")
                    {
                        if (User02 == "가위")
                            label6.Text = "User1 은 -> " + textBox1.Text + "\n" + "\n" +
                                    "User2 는 -> " + textBox2.Text + "\n" + "\n" +
                                    "결과는 -> User1 승";
                        else if (User02 == "바위")
                            label6.Text = "User1 은 -> " + textBox1.Text + "\n" + "\n" +
                                    "User2 는 -> " + textBox2.Text + "\n" + "\n" +
                                    "결과는 -> 무승부";
                        else if (User02 == "보")
                            label6.Text = "User1 은 -> " + textBox1.Text + "\n" + "\n" +
                                    "User2 는 -> " + textBox2.Text + "\n" + "\n" +
                                    "결과는 -> User1패";
                    }
                    else if (User01 == "보")
                    {
                        if (User02 == "가위")
                            label6.Text = "User1 은 -> " + textBox1.Text + "\n" + "\n" +
                                    "User2 는 -> " + textBox2.Text + "\n" + "\n" +
                                    "결과는 -> User1 패";
                        else if (User02 == "바위")
                            label6.Text = "User1 은 -> " + textBox1.Text + "\n" + "\n" +
                                    "User2 는 -> " + textBox2.Text + "\n" + "\n" +
                                    "결과는 -> User1 승";
                        else if (User02 == "보")
                            label6.Text = "User1 은 -> " + textBox1.Text + "\n" + "\n" +
                                    "User2 는 -> " + textBox2.Text + "\n" + "\n" +
                                    "결과는 -> 무승부";
                    }
                }
                else label6.Text = "입력값이 '가위, 바위, 보' 중 하나가 아닙니다. 다시 입력하세요";

            }
            catch (Exception ee)
            {
                label6.Text = ee.Message;
            }
        }
    }
}
