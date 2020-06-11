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
        string[] Xword;
        public Form1()
        { 
            InitializeComponent();
            Xword = new string[4];
            Xword[0] = "바보";
            Xword[1] = "님아";
            Xword[2] = "8억";
            Xword[3] = "메롱";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Valid = true;
            string contents = textBox1.Text;

            foreach (string word in Xword)
            {
                if (contents.IndexOf(word) >= 0)
                {
                    Valid = false;
                    MessageBox.Show(word + "은(는) 금지어입니다", "결과");
                    break;
                }
            }
            if (Valid == true) MessageBox.Show("정상적인 게시물입니다", "결과");
        }
    }
}
