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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = "1", upass = "1", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if(name.Equals(uname) && pass.Equals(upass))
            {
                //login
                
               // MessageBox.Show("LOGIN SUCCESSFULLY");
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("LOGIN SUY");
                textBox1.Clear();

                    

                
                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
