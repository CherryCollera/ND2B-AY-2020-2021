using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3_Villanueva
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnInteger_Click(object sender, EventArgs e)
        {
            int number = 25;
            MessageBox.Show(number.ToString());
        }

        private void BtnFloat_Click(object sender, EventArgs e)
        {
            float number = 25.78F;
            MessageBox.Show(number.ToString());
        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            double number = 25.7889;
            MessageBox.Show(number.ToString());
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;

            num1 = Convert.ToInt32(txtBox1.Text);
            num2 = Convert.ToInt32(txtBox2.Text);

            sum = num1 + num2;

            MessageBox.Show("The sum is " + Convert.ToString(sum));
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
        }

       
    }
}
