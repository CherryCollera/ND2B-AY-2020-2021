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

namespace Program
{
    public partial class Form1 : Form
    {
        private OleDbConnection bookConn;
        private OleDbCommand OleDbCmd = new OleDbCommand();
        private String connParam = @" Provider = Microsoft.ACE.OLEDB.12.0; 
        Data Source = D:\AJ\Object-Oriented Programming\Activity9\book3.accdb; Persist Security Info = False";

        public Form1()
        {
            bookConn = new OleDbConnection(connParam);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'book3DataSet1.bookrecords' table. You can move, or remove it, as needed.
            this.bookrecordsTableAdapter1.Fill(this.book3DataSet1.bookrecords);
            // TODO: This line of code loads data into the 'book3DataSet.bookrecords' table. You can move, or remove it, as needed.
            this.bookrecordsTableAdapter.Fill(this.book3DataSet.bookrecords);
                
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            bookConn.Open();
            OleDbCmd.Connection = bookConn;

            OleDbCmd.CommandText = "Insert into bookrecord (booktitle, description)" + " "
                    + " values ('" + this.text_BookTitle.Text + "' , '" + this.text_Desc.Text + "');";

            int temp = OleDbCmd.ExecuteNonQuery();
            if (temp > 0)
            {
                text_BookTitle.Text = null;
                text_BookTitle.Text = null;
                MessageBox.Show("Record Successfully Added");
            }
            else
            {
                MessageBox.Show("Failed to Add a Record");
            }
            bookConn.Close();

        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            OleDbDataAdapter dAdapter = new OleDbDataAdapter("Select * From bookrecords", connParam);
            OleDbDataAdapter dAdpter1 = new OleDbDataAdapter("Select *From bookrecords", connParam);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);

            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();

            dAdapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1]);
            }
        }
    }
}
