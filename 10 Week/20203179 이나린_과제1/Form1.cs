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
            System.Random random = new System.Random();
            int who = random.Next(1, 5);
            int what = random.Next(1, 4);

            string result = "";
            if (who == 1) result += "쏠사람 : 김태휘, ";
            else if (who == 2) result += "쏠사람 : 한가언, ";
            else if (who == 3) result += "쏠사람 : 설유리, ";
            else result += "쏠사람 : 한예술, ";

            if (what == 1) result += "쏠 메뉴 : 짜장면";
            else if (what == 2) result += "쏠 메뉴 : 간짜장";
            else result += "쏠 메뉴 : 짜장라면";

            label3.Text = result;
        }
    }
}
