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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
               

                label3.Text = "입력한 수 : " + num + " 은 " + (num % 2 == 0 ? "짝수" : "홀수") + " 입니다";
            }
            catch (Exception ee) 
            {
                label3.Text = ee.Message;
            }
        }
    }
}
