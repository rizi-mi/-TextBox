using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать в программу");
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int res1 = 2 * (a + b);
            string res = res1.ToString(); 
            textBox6.Text = res;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox14.Text);
            int b = int.Parse(textBox13.Text);
            int res1 = a * b;
            string res = res1.ToString();
            textBox9.Text = res;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox21.Text);
            int b = int.Parse(textBox20.Text);
            double res1 = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b, 2));
            string res = res1.ToString();
            textBox16.Text = res;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            int a = int.Parse(textBox28.Text);
            int b = int.Parse(textBox27.Text);
            double res1 = pi * Math.Pow(a,2) * b;
            string res = res1.ToString();
            textBox23.Text = res;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            int a = int.Parse(textBox35.Text);
            int b = int.Parse(textBox34.Text);
            double s = 0.333333333333;
            double res1 = s * pi * Math.Pow(a, 2) * b;
            string res = res1.ToString();
            textBox30.Text = res;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
