using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (Double.Parse(amountText.Text) <= Form1.balance)
            {
                Form1.balance -= Double.Parse(amountText.Text);
                if (Form1.count < 5)
                {
                    Form1.benef[Form1.count] = benefText.Text;
                    Form1.a[Form1.count] = Double.Parse(amountText.Text);
                    Form1.count++;
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Form1.benef[i] = Form1.benef[i+1];
                        Form1.a[i] = Form1.a[i+1];
                    }
                    Form1.benef[4] = benefText.Text;
                    Form1.a[4] = Double.Parse(amountText.Text);
                }
                MessageBox.Show("Amount Transferred=" + Double.Parse(amountText.Text) + "\n Balance=" + Form1.balance);
            }  
            else
                MessageBox.Show("Insufficient Balance");
        }
    }
}
