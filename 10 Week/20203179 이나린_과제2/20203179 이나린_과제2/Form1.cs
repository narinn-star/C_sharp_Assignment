using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int[] Array = new int[100];
            label2.Text = "";
            for (int i = 0; i < Array.Length; i++)
            { Array[i] = i + 1; }

            foreach (int output in Array)
            {
                if (output % 10 == 0)
                {
                    label2.Text += output.ToString() + " ";
                    label2.Text += "\n";
                }
                else
                    label2.Text += output.ToString() + " ";
            }
        }
    }
}
