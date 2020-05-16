using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace _20203179_이나린_과제2
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
                if (num > 0 && num <= 20)
                {

                    string blank = "                 ";
                    for (int i = 1; i <= num; i++)
                    {
                        if (i == 8 || i == 15)
                            result += "\n" + blank;

                        result += i + ", ";

                    }
                    label3.Text = "수행된 i 값 : " + result.TrimEnd(',',' ');
                }
                else
                {
                    label3.Text = "1과 20 사이의 수를 입력 하세요!";
                }

            }
            catch (Exception ee)
            {
                label3.Text = ee.Message + "\n" + "1과 20 사이의 정수를 입력 하세요!";
            }


        }
    }
}
