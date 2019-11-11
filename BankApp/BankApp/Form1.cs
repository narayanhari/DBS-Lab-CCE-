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
    public partial class Form1 : Form
    {
        public static String user_name1 = "user";
        public static String pwd1 = "password";
        public static double balance = 100000.0;
        public static String last_access = "30/07/19";
        public static double[] a = new double[5];
        public static String[] benef = new String[5];
        public static int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            if (user_text.Text.Equals("") && password_text.Text.Equals(""))
                MessageBox.Show("Enter valid credentials");
            else
            {
                user_name1 = user_text.Text;
                pwd1 = password_text.Text;
            }

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (user_text.Text == user_name1 && password_text.Text == pwd1)
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            else
                MessageBox.Show("enter valid info");
        }

        private void change_password_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }
    }
}
