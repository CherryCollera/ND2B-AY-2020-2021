using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cartmanCollegeDataSet.tblStudents' table. You can move, or remove it, as needed.
            this.tblStudentsTableAdapter.Fill(this.cartmanCollegeDataSet.tblStudents);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_HighGPA_Click(object sender, EventArgs e)
        {
            listBox_WithHighGPA.Items.Clear();
            const double CUTOFF = 3.00;
            this.tblStudentsTableAdapter.Fill(this.cartmanCollegeDataSet.tblStudents);
            var goodStudents =
            from s in this.cartmanCollegeDataSet.tblStudents
            where s.GradePointAverage > CUTOFF
            orderby s.GradePointAverage descending
            select s;
            foreach(var s in goodStudents)
            listBox_WithHighGPA.Items.Add(s.LastName + "  " + s.FirstName);
        }

        private void btn_ShowRecords_Click(object sender, EventArgs e)
        {
            listBox_WithMinGPA.Items.Clear();
            double minGPA = Convert.ToDouble(textBox_MinGPA.Text);
            this.tblStudentsTableAdapter.Fill(this.cartmanCollegeDataSet.tblStudents);
            var goodStudents =
                from s in this.cartmanCollegeDataSet.tblStudents
                where s.GradePointAverage > minGPA
                orderby s.GradePointAverage descending
            select s;
            foreach (var s in goodStudents)
                listBox_WithMinGPA.Items.Add(s.LastName + ", " + s.FirstName);
        }

        private void btn_ViewGradeStatistics_Click(object sender, EventArgs e)
        {
            var gpas =
    from s in this.cartmanCollegeDataSet.tblStudents
    select s.GradePointAverage;
            labelCount.Text = " Count is " + "\t" + gpas.Count();
            labelMin.Text = " Lowest is " + "\t" + gpas.Min();
            labelMax.Text = " Highest is " + "\t" + gpas.Max();
            labelAverage.Text = " Average of all GPAs is " + "\t" + gpas.Average();
        }

        private void btn_GroupByGPA_Click(object sender, EventArgs e)
        {
            listBox_GroupByGPA.Items.Clear();
            var studgpa =
                from s in this.cartmanCollegeDataSet.tblStudents
                group s by (int)s.GradePointAverage;

            foreach (var GroupGPA in studgpa)
            {
                listBox_GroupByGPA.Items.Add("GPA: " + GroupGPA.Key);
                foreach(var s in GroupGPA)
                listBox_GroupByGPA.Items.Add(" " + s.GradePointAverage + " " + s.LastName);
            }
        }
    }
}
