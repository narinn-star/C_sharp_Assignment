﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._06._22_02
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
            int num = int.Parse(textBox1.Text);
            string result = "";
            bool Prime = true;
            /*
             소수구하기
            1과 자기자신을 포함 1과 자기자신이 아닐때 break를 걸어서
            for문 탈출 소수인걸로 판정
             */
            //13
            // 1 13
            // 2 ~ 12
            for (int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    label3.Text = num + "은 소수가 아닙니다!";
                    Prime = false;
                }
            }
            if (Prime)
                label3.Text = num + " 은 소수입니다!";

        }
    }
}
