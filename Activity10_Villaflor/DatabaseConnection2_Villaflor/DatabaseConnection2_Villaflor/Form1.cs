using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DatabaseConnection2_Villaflor
{
    public partial class Form1 : Form
    {
        private OleDbConnection bookConn;
        private OleDbCommand oleDbCmd = new OleDbCommand();
        private String connParam = @"Provider=Microsoft.ACE.OLEDB.12.0;
        Data Source=D:\AJ\Object-Oriented Programming\Activity10_Villaflor\book3.accdb";
        public Form1()
        {
            InitializeComponent();
            bookConn = new OleDbConnection(connParam);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'book3DataSet1.bookrecords' table. You can move, or remove it, as needed.
            this.bookrecordsTableAdapter1.Fill(this.book3DataSet1.bookrecords);
            // TODO: This line of code loads data into the 'book3DataSet.bookrecords' table. You can move, or remove it, as needed.
            this.bookrecordsTableAdapter.Fill(this.book3DataSet.bookrecords);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            text_bookTitle.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text_Desc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bookConn.Open();
            oleDbCmd.Connection = bookConn;
            oleDbCmd.CommandText = "Insert into bookrecords (booktitle, description)" + " " + " values ('" + 
                this.text_bookTitle.Text + "', '" + this.text_Desc.Text + "');";

            int temp = oleDbCmd.ExecuteNonQuery();
            if (temp > 0)
            {
                text_bookTitle.Text = null;
                text_Desc.Text = null;
                MessageBox.Show("Record Added Successfully");
            }
            else
            {
                MessageBox.Show("Failed to Add a Record");
            }
            bookConn.Close();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            OleDbDataAdapter dAdapter = new OleDbDataAdapter("SELECT * FROM bookrecords", connParam);
            OleDbDataAdapter dAdapter1 = new OleDbDataAdapter("SELECT * FROM bookrecords", connParam);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);

            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();

            dAdapter.Fill(dataTable);

            for (int i = 0; 1 < dataTable.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dataTable.Rows[i][0],dataTable.Rows[i][1]);
            }
        }
         
        private void btn_dltRecord_Click(object sender, EventArgs e)
        {
            bookConn.Open();
            oleDbCmd.Connection = bookConn;
            oleDbCmd.CommandText = "delete from bookrecords where BookTitle ='" + text_bookTitle.Text + "'";
            oleDbCmd.ExecuteNonQuery();
            if (String.IsNullOrEmpty(text_bookTitle.Text))
            {
                MessageBox.Show("Select a Record to be Deleted");
            }
            else
            {
                MessageBox.Show("Successfully Deleted!");
                text_bookTitle.Clear();
                text_Desc.Clear();
            }
            bookConn.Close();
        }
    }
}
