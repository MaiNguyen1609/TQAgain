using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a + b;
=======
            int d = int.Parse(textBox1.Text);
            int g = int.Parse(textBox2.Text);
            int f = d + g;
>>>>>>> TestingAg
        }
    }
}
