﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Happy Birthday " + fn.Text + " " + ln.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 to = new Form3();
            to.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 to = new Form1();
            to.Show();
            this.Hide();
        }

        private void fn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}