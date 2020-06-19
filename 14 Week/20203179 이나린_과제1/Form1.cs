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
        bool drag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            label1.Text = "드래그 : 안하고있음";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
                label1.Text = "드래그 : 하고있음";
        }
    }
}
