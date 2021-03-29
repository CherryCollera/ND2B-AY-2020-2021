using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Villanueva
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(text1.Text);
            int num2 = int.Parse(text2.Text);
            txtAnswer.Text = (num1 + num2).ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 to = new Form1();
            to.Show();
            this.Hide();
        }

        private void diff_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(text1.Text);
            int num2 = int.Parse(text2.Text);
            txtAnswer.Text = (num1 - num2).ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(text1.Text);
            int num2 = int.Parse(text2.Text);
            txtAnswer.Text = (num1 * num2).ToString();
        }

        private void rem_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(text1.Text);
            int num2 = int.Parse(text2.Text);
            txtAnswer.Text = (num1 % num2).ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(text1.Text);
            int num2 = int.Parse(text2.Text);
            txtAnswer.Text = (num1 / num2).ToString();
        }

        private void clr_Click(object sender, EventArgs e)
        {
            text1.Text = String.Empty;
            text2.Text = String.Empty;
            txtAnswer.Text = String.Empty;
        }
    }
}
