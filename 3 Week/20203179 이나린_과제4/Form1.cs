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
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
               
                double div, mod;
                div = iData01 / iData02;
                mod = iData01 % iData02;
                label2.Text = iData01 + "나누기 " + iData02 + "의 몫은 " + div + " 이고 나머지는 " + mod + " 입니다.";
            }
            catch
            {
                label2.Text = "결과에 이상이 있습니다.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
            textBox2.Text = "2";
            label2.Text = "결과가 표시 되는 곳입니다!";
        }
    }
}
