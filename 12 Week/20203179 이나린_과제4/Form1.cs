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
        CheckBox[] num;
        const int count = 20;

        public Form1()
        {
            InitializeComponent();
            num = new CheckBox[count];
            num[0] = checkBox1;
            num[1] = checkBox2;
            num[2] = checkBox3;
            num[3] = checkBox4;
            num[4] = checkBox5;
            num[5] = checkBox6;
            num[6] = checkBox7;
            num[7] = checkBox8;
            num[8] = checkBox9;
            num[9] = checkBox10;
            num[10] = checkBox11;
            num[11] = checkBox12;
            num[12] = checkBox13;
            num[13] = checkBox14;
            num[14] = checkBox15;
            num[15] = checkBox16;
            num[16] = checkBox17;
            num[17] = checkBox18;
            num[18] = checkBox19;
            num[19] = checkBox20;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random Rnum = new System.Random();
            for (int i = 0; i < count; i++)
            {
                num[i].Text = Rnum.Next(1, 99).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("각 체크박스의 숫자들");
                listBox1.Items.Add("---------------------");
                for (int i = 0; i < count; i++)
                {
                    listBox1.Items.Add("checkBox" + (i + 1) + " = " + num[i].Text);
                }

                listBox2.Items.Clear();
                listBox2.Items.Add("선택된 체크박스의 숫자들");
                listBox2.Items.Add("-------------------------");

            }
            catch
            {

            }
            
        }
    }
}
