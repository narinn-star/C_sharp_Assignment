using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203179이나린1번
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
                string num = textBox1.Text;
                string name = textBox2.Text;

                label4.Text = "학생 학번 : " + num + "\n" + "\n" + "학생 이름 : " + name;
            }
            catch (Exception ee)
            {
                label4.Text = ee.Message;
            }
            

            
        }
    }
}
