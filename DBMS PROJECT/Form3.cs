using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BOOKSTORE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;User Id=system;Password=system;OLEDB.NET=True";
            OleDbConnection obj1 = new OleDbConnection(connection);
            String q1 = "Insert into PUBLISHER values('" + textBox1.Text + "','" + textBox4.Text + "'," + Int32.Parse(textBox3.Text) + ",'" + textBox2.Text + "')";
            obj1.Open();
            try
            {
                OleDbCommand cm2 = new OleDbCommand(q1, obj1);
                cm2.ExecuteNonQuery();
                MessageBox.Show("Insert Successful");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Insert unsuccessful");

            }
            obj1.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
