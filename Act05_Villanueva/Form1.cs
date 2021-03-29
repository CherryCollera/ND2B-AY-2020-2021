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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            HappyBirthday hb = new HappyBirthday();
            MessageBox.Show(hb.GetMessage("Mervic"));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 to = new Form2();
            to.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}