using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            double d = double.Parse(s);
            string t = textBox2.Text;
            double n = double.Parse(t);
            double Product = n * d;
            label1.Text = "两数的乘积是" + Product;


        }
    }
}
