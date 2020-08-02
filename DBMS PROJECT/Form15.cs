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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;User Id=system;Password=system;OLEDB.NET=True";
            OleDbConnection obj1 = new OleDbConnection(connection);
            String q1 = "Delete FROM  CUSTOMER WHERE c_email ='" + textBox4.Text + "'";
            obj1.Open();
            try
            {
                OleDbCommand cm2 = new OleDbCommand(q1, obj1);
                cm2.ExecuteNonQuery();
                MessageBox.Show("Deleted Successful");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
            obj1.Close();

        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }
    }
}
