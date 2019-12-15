using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;

            try
            {
                double x1 = Convert.ToDouble(s1);
                double x2 = Convert.ToDouble(s2);

                textBox3.Text = "" + (x1 + x2); 
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Debe ingresar valores correctos");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;

            try
            {
                double x1 = Convert.ToDouble(s1);
                double x2 = Convert.ToDouble(s2);

                textBox3.Text = "" + (x1 - x2); 
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Debe ingresar valores correctos");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;

            try
            {
                double x1 = Convert.ToDouble(s1);
                double x2 = Convert.ToDouble(s2);

                textBox3.Text = "" + (x1 * x2); 
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Debe ingresar valores correctos");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;

            try
            {
                double x1 = Convert.ToDouble(s1);
                double x2 = Convert.ToDouble(s2);

                textBox3.Text = "" + (x1 / x2); 
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Debe ingresar valores correctos");

            }
        }
    }
}
