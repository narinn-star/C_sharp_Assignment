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

                switch (num)
                {
                    case 1:
                        label3.Text = "one";
                        break;
                    case 2:
                        label3.Text = "two";
                        break;
                    case 3:
                        label3.Text = "three";
                        break;
                    case 4:
                        label3.Text = "four";
                        break;
                    case 5:
                        label3.Text = "five";
                        break;
                    default:
                        label3.Text = "알수없는 수 입니다!";
                        break;
                }
            }
            catch (Exception ee)
            {
                label3.Text = ee.Message;
            }
        }
    }
}
