using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAssignment
{
    public partial class Form1 : Form
    {
        private int first_number = 0;
        private int second_number = 0;
        private bool flag = false;
        private char btn = ' ';
        private int result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "7";
            else
                textBox1.Text = "7";
            flag = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "8";
            else
                textBox1.Text = "8";
            flag = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "9";
            else
                textBox1.Text = "9";
            flag = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "4";
            else
                textBox1.Text = "4";
            flag = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "5";
            else
                textBox1.Text = "5";
            flag = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "6";
            else
                textBox1.Text = "6";
            flag = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "1";
            else
                textBox1.Text = "1";
            flag = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "2";
            else
                textBox1.Text = "2";
            flag = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "3";
            else
                textBox1.Text = "3";
            flag = false;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textBox1.Text += "0";
            else
                textBox1.Text = "0";
            flag = false;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            second_number = Convert.ToInt32(textBox1.Text);
            if (btn == '+')
            {
                result = first_number + second_number;
                textBox1.Text = first_number + " + " + second_number; 
                label1.Text = result + "";
                label1.Visible = true;
            }
            else if (btn == '-')
            {
                result = first_number - second_number;
                textBox1.Text = first_number + " - " + second_number; 
                label1.Text = result + "";
                label1.Visible = true;
            }
            else if (btn == '×')
            {
                result = first_number * second_number;
                textBox1.Text = first_number + " × " + second_number; 
                label1.Text = result + "";
                label1.Visible = true;
            }
            else if (btn == '÷')
            {
                result = first_number / second_number;
                textBox1.Text = first_number + " ÷ " + second_number;
                label1.Text = result + "";
                label1.Visible = true;

            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToInt32(textBox1.Text);

            label1.Text = first_number + " + ";
            flag = true;
            btn = '+';
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToInt32(textBox1.Text);

            label1.Text = first_number + " - ";
            flag = true;
            btn = '-';
        }

        private void buttonInto_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToInt32(textBox1.Text);

            label1.Text = first_number + " × ";
            flag = true;
            btn = '×';
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToInt32(textBox1.Text);

            label1.Text = first_number + " ÷ ";
            flag = true;
            btn = '÷';
        }
    }
}
