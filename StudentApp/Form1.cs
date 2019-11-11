using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            String name_text = name.Text;
            String address_text = address.Text;
            String national = nationality.Text;
            String state1 = state.Text;
            String sex = "Other";
            if (male.Checked)
                sex = "Male";
            if (female.Checked)
                sex = "Female";
            if(!male.Checked && !female.Checked)
                MessageBox.Show("Select Gender");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < documents.Items.Count; i++)
            {
                if (documents.GetItemChecked(i))
                {
                    sb.Append((String)documents.Items[i]);
                    sb.Append("\n");
                }
            }
            String date = dob.SelectionRange.Start.ToShortDateString();
            if (name_text.Length != 0 && address_text.Length != 0 && national.Length != 0
                && state1.Length != 0 && date.Length != 0)
            {
                MessageBox.Show("Name: " + name_text + "\nAddress: " + address_text +
                  "\nNationality: " + national + "\nState: " + state1 + "\nGender: " + sex
                  + "\nDOB:" + date + "\nDocuments:\n" + sb.ToString());
            }
            else
                MessageBox.Show("Fill all fields");
        }
    }
}