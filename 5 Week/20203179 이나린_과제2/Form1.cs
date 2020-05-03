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
            try
            {
                string str = textBox1.Text;

                if (char.Parse(str) >= 'a' && char.Parse(str) <= 'z')
                {

                    switch (char.Parse(str))
                    {
                        case 'a':
 
                        case 'e':
   
                        case 'i':
   
                        case 'o':
     
                        case 'u':
                            label3.Text = "\"" + textBox1.Text + "\"" + " is a vowel";
                            break;
                        default:
                            label3.Text = "\"" + textBox1.Text + "\"" + "is a consonant";
                            break;
                    }
                }
                else
                {
                    label3.Text = "\"" + textBox1.Text + "\"" + "을 입력하였습니다." + "\n"
                        + "영문 알파벳 한글자를 입력하세요!";
                }
            }
            catch 
            {
                label3.Text = "문자열의 길이는 1자여야 합니다.";
            }
        }
    }
}
