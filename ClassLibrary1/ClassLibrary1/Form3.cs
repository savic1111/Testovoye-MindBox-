using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class Form3 : Form
    {
        Form1 f1 = new Form1();
        public Form3()
        {
            InitializeComponent();
        }
        public double square(double a)
        {


            return a * a;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(square(Convert.ToDouble(textBox1.Text)));
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            Close();
        }
    }
}
