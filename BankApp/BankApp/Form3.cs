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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form3_Load_1(object sender, EventArgs e)
        {
            usernameText.Text = Form1.user_name1;
            balanceText.Text = Form1.balance.ToString();
            last_accessText.Text = Form1.last_access;

            String transact = "";
            for (int i = 0; i < 5; i++)
            {
                if (Form1.a[i] != 0)
                {
                    transact += Form1.benef[i] + "-" + Form1.a[i].ToString() + "    " + Environment.NewLine ;
                }
            }
            transactionsText.Text = transact;
        }

        private void transact_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}
