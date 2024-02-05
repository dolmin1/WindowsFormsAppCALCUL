using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCALCUL
{
    public partial class Form1 : Form
    {
        public string d;
        public string N1;
        public bool N2;
     public Form1()
        {
            N2 = false;
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(N2)
            {
                N2 = false;
                textBox1.Text = "";

            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            d = button.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "КАЛЬКУЛЯТОР";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double dn1 , dn2 , res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if(d == "+")
            {
                res = dn1 + dn2;
            }
            if (d == "-")
            {
                res = dn1 - dn2;
            }
            if (d == "*")
            {
                res = dn1 * dn2;
            }
            if (d == "/")
            {
                res = dn1 / dn2;
            }
            d = "=";
            N2 = true;
            textBox1.Text = res.ToString();
        }
    }
}
