using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3_Villanueva
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hello", "My Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Form4 f4 = new Form4();
                this.Hide();
                f4.ShowDialog();
            }

            else
            {
               
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

