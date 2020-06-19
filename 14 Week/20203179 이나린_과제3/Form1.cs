using System;
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
        bool drawing = false;
        Point pPoint;
        Pen MyPen = new Pen(Color.Black);

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            pPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing == true)
            {
                Point fPoint = new Point(e.X, e.Y);
                Graphics G = pictureBox1.CreateGraphics();
                G.DrawLine(MyPen, pPoint, fPoint);
                pPoint = fPoint;
            }
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 굵기10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.Width = 10;
        }

        private void 굵기5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.Width = 5;
        }

        private void 굵기3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.Width = 3;
        }

        private void 굵기1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.Width = 1;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void dashDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void colorLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                MyPen.Color = colorDialog1.Color;
        }
    }
}
