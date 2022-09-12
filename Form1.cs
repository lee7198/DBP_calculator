using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double preNum;
        string operate;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            preNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operate = "+";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            preNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operate = "-";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            preNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operate = "*";
        }
        private void button20_Click(object sender, EventArgs e)
        {
            preNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operate = "/";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            preNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operate = "%";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            operate = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('.'))
            {
                return;
            } else
            {
                if (textBox1.Text == "") textBox1.Text += "0.";
                else if (textBox1.Text == "-") textBox1.Text += "-0.";
                else textBox1.Text += ".";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('-'))
            {
                textBox1.Text = textBox1.Text.Substring(1);
            } else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double postNum = Convert.ToDouble(textBox1.Text);

            if(operate == "+")
            {
                textBox1.Text = Convert.ToString(preNum + postNum);
            } else if(operate == "-")
            {
                textBox1.Text = Convert.ToString(preNum - postNum);
            } else if (operate == "*")
            {
                textBox1.Text = Convert.ToString(preNum * postNum);
            } else if(operate == "/")
            {
                if(preNum != 0)
                {
                    textBox1.Text = Convert.ToString(preNum / postNum);
                }
            } else if(operate == "%")
            {
                if (preNum != 0)
                {
                    textBox1.Text = Convert.ToString(preNum % postNum);
                }
            }

            operate = "";

        }
    }
}
