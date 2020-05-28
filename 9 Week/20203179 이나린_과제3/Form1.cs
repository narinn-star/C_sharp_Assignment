﻿using System;
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
        int Kaccount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int deposit = int.Parse(textBox1.Text);
                if (deposit >= 1000 || deposit <= 0)
                {
                    label5.Text = "정상적인 금액을 입금해주세요 \n" + "김태희 계좌잔고 : " + Kaccount + "원";
                }
                else
                {
                    Kaccount += deposit;
                    label5.Text = "김태희 계좌잔고 : " + Kaccount + "원";
                }
            }
            catch (Exception ee)
            {
                label5.Text = ee.Message + "\n김태희 계좌잔고 : " + Kaccount + "원";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int withdraw = int.Parse(textBox2.Text);
                if (withdraw >= Kaccount || withdraw <= 0)
                {
                    label5.Text = "정상적인 금액을 출금해주세요 \n" + "김태희 계좌잔고 : " + Kaccount + "원";
                }
                else
                {
                    Kaccount -= withdraw;
                    label5.Text = "김태희 계좌잔고 : " + Kaccount + "원";
                }
            }
            catch (Exception ee)
            {
                label5.Text = ee.Message + "\n김태희 계좌잔고 : " + Kaccount + "원";
            }
        }
    }
}
