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
        bool Modified = false;
        bool file_name = false;
        string name = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void 새파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modified == true)
            {
                DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    if (file_name == true)
                    {
                        System.IO.StreamWriter fs = System.IO.File.CreateText(name);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        Modified = false;
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            name = saveFileDialog1.FileName;
                            System.IO.StreamWriter fs = System.IO.File.CreateText(name);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            file_name = false;
                            Modified = true;
                        }
                    }
                }
            }
            textBox1.Text = "";
            Modified = false;
            file_name = false;
            name = "";
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (file_name == true)
                        {
                            System.IO.StreamWriter fs = System.IO.File.CreateText(name);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            Modified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                name = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = System.IO.File.CreateText(name);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                file_name = true;
                                Modified = false;
                            }
                        }
                    }
                }
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    name = openFileDialog1.FileName;
                    System.IO.StreamReader fs = System.IO.File.OpenText(name);
                    textBox1.Text = fs.ReadToEnd();
                    fs.Close();
                    file_name = true;
                    Modified = false;
                }
            }
            catch
            {
                MessageBox.Show("열기를 하는 도중 이상이 발생했습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (file_name == true)
                {
                    System.IO.StreamWriter fs = System.IO.File.CreateText(name);
                    fs.WriteLine(textBox1.Text);
                    fs.Close();
                    Modified = false;
                }
                else
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        name = saveFileDialog1.FileName;
                        System.IO.StreamWriter fs = System.IO.File.CreateText(name);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        file_name = true;
                        Modified = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("저장을 하는 도중 이상이 발생했습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (file_name == true)
                        {
                            System.IO.StreamWriter fs = System.IO.File.CreateText(name);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            Modified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                name = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = System.IO.File.CreateText(name);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                file_name = true;
                                Modified = false;
                            }
                        }
                    }
                }
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("끝내기를 하는 도중 이상이 발생했습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Modified = true;
        }
    }
}
