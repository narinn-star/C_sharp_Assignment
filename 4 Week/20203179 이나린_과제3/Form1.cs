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
            textBox1.Text = "2";
            textBox2.Text = "3";
            textBox3.Text = "";
            textBox3.Focus();
            label5.Text = "결과가 나오는 곳 입니다!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num01 = int.Parse(textBox1.Text);
                int num02 = int.Parse(textBox2.Text);
                string mark = textBox3.Text;
                bool num03 = true;
                if (mark == "") label5.Text = "Operator에 관계연산자 하나를 입력하세요!";
                else
                {

                    if (mark == "==" || mark == "!=" || mark == ">" || mark == "<" || mark == ">=" || mark == "<=")
                    {
                        if (mark == "==") num03 = num01 == num02;

                        else if (mark == "!=") num03 = num01 != num02;

                        else if (mark == ">") num03 = num01 > num02;

                        else if (mark == "<") num03 = num01 < num02;

                        else if (mark == ">=") num03 = num01 >= num02;

                        else if (mark == "<=") num03 = num01 <= num02;


                        label5.Text = num01 + " " + mark + " " + num02 + " 의 결과는 " + num03;
                        textBox3.Text = "";

                    }
                    else
                    {
                        label5.Text = "\"" + mark + "\"" + " 는 올바른 관계연산자가 아님" +
                            '\n' + '\n' + " 올바른 관계연산자를 입력하세요!";
                    }
                }
            }
            catch (Exception ee)
            {
                label5.Text = ee.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = "2";

            textBox2.Text = "3";

            textBox3.Text = "";

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox3.Focus();
        }
    }
}
