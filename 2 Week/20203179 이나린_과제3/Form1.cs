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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sData01 = textBox1.Text;
                string sData02 = textBox2.Text;
                label5.Text = "성명 : " + sData01;
                label6.Text = "학번 : " + sData02;
            }
            catch
            {
                label5.Text = "성명 : " ;
                label6.Text = "학번 : " ;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sData03 = textBox3.Text;
                string sData04 = textBox4.Text;
                label7.Text = "유선 : " + sData03;
                label8.Text = "무선 : " + sData04;
            }
            catch
            {
                label7.Text = "유선 : ";
                label8.Text = "무선 : ";
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }
    }
}
