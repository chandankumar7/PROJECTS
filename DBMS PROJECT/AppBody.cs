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
    public partial class AppBody : Form
    {
        public AppBody()
        {
            InitializeComponent();
        }
        private void closebutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Logoffbutton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 obj = new Form9();
            obj.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 obj = new Form14();
            obj.Show();
        }

        
    }
}
