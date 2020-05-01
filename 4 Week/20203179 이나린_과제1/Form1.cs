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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                string blank = "";

                    if (num < 0) blank = "0보다 작은";

                    else if (num < 10) blank = "0과 10사이 ";

                    else if (num < 50) blank = "10과 50사이 ";

                    else if (num < 100) blank = "50과 100사이 ";

                    else blank = "100보다 큰";

                    textBox2.Text = blank + "수를 입력했습니다!";
            }
            catch (Exception ee)
            {
                if (textBox1.Text == "")
                    textBox2.Text = "숫자를 입력 하세요!";
                else
                textBox2.Text = ee.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
