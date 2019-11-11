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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            username_text.Text = Form1.user_name1;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (new_pwd_text.Text == confirm_pwd_text.Text)
                Form1.pwd1 = new_pwd_text.Text;
            this.Close();
        }

        private void username_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
