using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._1
{
    public partial class Form2 : Form
    {
        string input = string.Empty; //to read the input when clicked 
        string Op1 = string.Empty; //First operand
        string Op2 = string.Empty; //Second operand 
        char Operator; //Operator
        double res = 0.0; //Final result
        public Form2()
        {
            InitializeComponent();
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            Op2 = input;
            double num1, num2; 
            double.TryParse(Op1, out num1); 
            double.TryParse(Op2, out num2);
            if (Operator == '+')
            {
                res = num1 + num2; 
                this.disp.Text = res.ToString();
            }
            else if (Operator == '-')
            {
                res = num1 - num2; 
                this.disp.Text = res.ToString();
            }
            else if (Operator == '*')
            {
                res = num1 * num2; 
                this.disp.Text = res.ToString();
            }
            else if (Operator == 'r')
            {
                res = Math.Sqrt(num2);
                this.disp.Text = res.ToString();
            }
            else if (Operator == 's')
            {
                res = Math.Sin(num2);
                this.disp.Text = res.ToString();
            }
            else if (Operator == '/')
            {
                if (num2 != 0)
                {
                    res = num1 / num2; 
                    this.disp.Text = res.ToString();
                }
                else
                {
                    this.disp.Text = "Division by zero";
                }
            }
            else if (Operator == 'l')
            {
                res = Math.Log(num2);
                this.disp.Text = res.ToString();
            }
            else if (Operator == 'e')
            {
                res = Math.Exp(num2);
                this.disp.Text = res.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.disp.Text = "";
            input = input + "1";
            this.disp.Text += input; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.disp.Text = "";
            input = input + "2";
            this.disp.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.disp.Text = "";
            input = input + "3";
            this.disp.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.disp.Text = "";
            input = input + "4";
            this.disp.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.disp.Text = "";
            input = input + "5";
            this.disp.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.disp.Text = "";
            input = input + "6";
            this.disp.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.disp.Text = "";
            input = input + "7";
            this.disp.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.disp.Text = "";
            input = input + "8";
            this.disp.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.disp.Text = "";
            input = input + "9";
            this.disp.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.disp.Text = "";
            input = input + "0";
            this.disp.Text += input;
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            input = "";
            this.disp.Text = "";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            Op1 = input; 
            Operator = '+';
            input = string.Empty;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '-';
            input = string.Empty;
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '*';
            input = string.Empty;
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 'r';
            input = string.Empty;
        }

        private void button_sin_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 's';
            input = string.Empty;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '/';
            input = string.Empty;
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 'l';
            input = string.Empty;
        }

        private void button_exp_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 'e';
            input = string.Empty;
        }
    }
}
