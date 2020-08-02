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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            String connection = "Provider=OraOLEDB.Oracle;Data Source=localhost;User Id=system;Password=system;OLEDB.NET=True";
            OleDbConnection obj1 = new OleDbConnection(connection);
            String query = "Select * from CUSTOMER";
            obj1.Open();
            OleDbCommand cm2 = new OleDbCommand(query, obj1);
               {

                    OleDbDataReader reader = cm2.ExecuteReader();
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }

                }
                obj1.Close();
            }
        }
    }

