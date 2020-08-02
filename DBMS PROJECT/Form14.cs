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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 obj = new Form15();
            obj.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 obj = new Form16();
            obj.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form19 obj = new Form19();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form20 obj = new Form20();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form21 obj = new Form21();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form22 obj = new Form22();
            obj.Show();
        }
    }
}
