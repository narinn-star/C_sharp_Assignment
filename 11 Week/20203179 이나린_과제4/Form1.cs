using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203179_이나린_과제4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string [] sUnacceptableWords = new string[4];
            sUnacceptableWords[0] = "바보";
            sUnacceptableWords[1] = "메롱";
            sUnacceptableWords[2] = "님아";
            sUnacceptableWords[3] = "8억";
            string contents = textBox1.Text;
            
            foreach (string word in sUnacceptableWords)
            {
                string First = "";
                string Second = "";
                int Position = contents.IndexOf(word);
                while (Position >= 0)
                {
                    First = contents.Substring(0, Position);
                    Second = contents.Substring(Position + contents.Length);

                    contents = First + "금지어" + Second;
                    Position = contents.IndexOf(word);
                }
            }
            textBox1.Text = contents;
            
        }
    }
}
