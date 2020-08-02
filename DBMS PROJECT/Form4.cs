using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BOOKSTORE
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 obj = new Form2();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 obj = new Form3();
            obj.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
             this.Hide();
            Form5 obj = new Form5();
            obj.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 obj = new Form6();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 obj = new Form7();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 obj = new Form17();
            obj.Show();
        }
    }
}
