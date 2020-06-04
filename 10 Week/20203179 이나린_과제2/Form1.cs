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
            int[] Array = new int[10];

            System.Random Num = new System.Random();
            double average = 0;

            for(int i = 0; i < Array.Length; i++)
            {
                Array[i] = Num.Next(1, 101);
                average += Array[i];
            }
            
            label2.Text = "";
            for(int i = 0; i < Array.Length; i++)
            {
                if (i % 2 == 0)

                    label2.Text += "\n" + "iarray [" + i + "] = " + Array[i] + "      ";
                else 
                    label2.Text += "iarray [" + i + "] = " + Array[i];
            }
            int Max = Array[0];
            int Min = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (Max < Array[i]) Max = Array[i];
                if (Min > Array[i]) Min = Array[i];
            }
            average = average / Array.Length;

            label2.Text += "\n\n\n" + "배열값의 최대는 " + Max;
            label2.Text += "\n\n" + "배열값의 최소는 " + Min;
            label2.Text += "\n\n" + "10 개 원소 배열값의 평균은 " + average;
            


            


        }
    }
}
