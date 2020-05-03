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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textBox1.Text;

                if (textBox1.Text != "")
                {

                    switch (str)
                    {
                        case "int":
                            int iData01 = int.MaxValue;
                            int iData02 = int.MinValue;
                            label3.Text = textBox1.Text + " 의 허용값은 " + iData02 + " ~ " + iData01;
                            break;
                        case "uint":
                            uint uiData01 = uint.MaxValue;
                            uint uiData02 = uint.MinValue;
                            label3.Text = textBox1.Text + " 의 허용값은 " + uiData02 + " ~ " + uiData01;
                            break;
                        case "float":
                            float fData01 = float.MaxValue;
                            float fData02 = float.MinValue;
                            label3.Text = textBox1.Text + " 의 허용값은 " + fData02 + " ~ " + fData01;
                            break;
                        case "double":
                            double dData01 = double.MaxValue;
                            double dData02 = double.MinValue;
                            label3.Text = textBox1.Text + " 의 허용값은 " + dData02 + " ~ " + dData01;
                            break;
                        case "long":
                            long lData01 = long.MaxValue;
                            long lData02 = long.MinValue;
                            label3.Text = textBox1.Text + " 의 허용값은 " + lData02 + " ~ " + lData01;
                            break;
                        case "ulong":
                            ulong ulData01 = ulong.MaxValue;
                            ulong ulData02 = ulong.MinValue;
                            label3.Text = textBox1.Text + " 의 허용값은 " + ulData02 + " ~ " + ulData01;
                            break;
                        case "byte":
                            byte bData01 = byte.MaxValue;
                            byte bData02 = byte.MinValue;
                            label3.Text = textBox1.Text + " 의 허용값은 " + bData02 + " ~ " + bData01;
                            break;
                        case "sbyte":
                            sbyte sbData01 = sbyte.MaxValue;
                            sbyte sbData02 = sbyte.MinValue;
                            label3.Text = textBox1.Text + " 의 허용값은 " + sbData02 + " ~ " + sbData01;
                            break;
                        case "short":
                            short shData01 = short.MaxValue;
                            short shData02 = short.MinValue;
                            label3.Text = textBox1.Text + " 의 허용값은 " + shData02 + " ~ " + shData01;
                            break;
                        case "ushort":
                            ushort ushData01 = ushort.MaxValue;
                            ushort ushData02 = ushort.MinValue;
                            label3.Text = textBox1.Text + " 의 허용값은 " + ushData02 + " ~ " + ushData01;
                            break;
                        default:
                            label3.Text = "\"" + textBox1.Text + "\"" + "는 알수없는 Data Type 입니다!";
                            break;
                    }
                }
                else
                {
                    label3.Text = "10 가지 Data Type 중 하나를 입력 하세요!";
                }
                textBox1.Text = "";
            }

            catch (Exception ee)
            {
                label3.Text = ee.Message;
            }
        }
    }
}
