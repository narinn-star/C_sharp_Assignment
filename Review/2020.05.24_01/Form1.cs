using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._05._24_01
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
                uint snum = uint.Parse(textBox1.Text);
                uint fnum = uint.Parse(textBox2.Text);
                double sum01 = 0;
                double sum02 = 1;
                string result = "";

                for (uint i = snum; i <= fnum; i++)
                {
                    sum01 += i;
                    sum02 = sum02 * i;
                }
                label4.Text = snum + "부터 " + fnum + "까지의 합은 " + sum01 + "\n 곱은 " + sum02 + " 입니다.";
            }
            catch(Exception ee)
            {
                label4.Text = ee.Message;
            }
        }
    }
}
