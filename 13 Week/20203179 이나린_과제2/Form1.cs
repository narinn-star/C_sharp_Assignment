using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203179_이나린_과제2
{
    public partial class Form1 : Form
    {
        bool file_name = false;
        bool Modified = false;
        string name = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void 새로만들ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modified == true)
            {
                DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    if (file_name == true)
                    {
                        StreamWriter fs = new StreamWriter(name, false, Encoding.Default);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        Modified = false;
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            name = saveFileDialog1.FileName;
                            StreamWriter fs = new StreamWriter(name, false, Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            file_name = true;
                            Modified = false;
                        }
                        
                    }
                }
            }
            textBox1.Text = "";
            Modified = false;
            file_name = false;
            name = "";
        }

        private void 열ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modified == true)
            {
                DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    if (file_name == true)
                    {
                        StreamWriter fs = new StreamWriter(name, false, Encoding.Default);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        Modified = false;
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.Yes)
                        {
                            name = saveFileDialog1.FileName;
                            StreamWriter fs = new StreamWriter(name, false, Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            Modified = false;
                            file_name = true;
                        }
                    }
                }
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                StreamReader fs = new StreamReader(name, Encoding.Default);
                textBox1.Text = fs.ReadToEnd();
                fs.Close();
                Modified = false;
                file_name = true;

            }
        }

        private void 저장SCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modified == true)
            {
                DialogResult answer = MessageBox.Show("Text 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    if (file_name == true)
                    {
                        StreamWriter fs = new StreamWriter(name, false, Encoding.Default);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        Modified = false;
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            name = saveFileDialog1.FileName;
                            StreamWriter fs = new StreamWriter(name, false, Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            file_name = true;
                            Modified = false;
                        }
                    }
                }
            }
        }

        private void 복사CCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modified == true)
            {
                DialogResult answer = MessageBox.Show("변경된 내용을 저장하고 종료 하겠습니까?", "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (file_name == true)
                    {
                        StreamWriter fs = new StreamWriter(name, false, Encoding.Default);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        Modified = false;
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            name = saveFileDialog1.FileName;
                            StreamWriter fs = new StreamWriter(name, false, Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            Modified = false;
                            file_name = true;
                        }
                    }

                }
            }
            Application.Exit();
        }
    }
}
