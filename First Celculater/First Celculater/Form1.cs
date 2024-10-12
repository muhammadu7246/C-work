using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Celculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ver_1 = int.Parse(textBox1.Text);
            int ver_2 = int.Parse(textBox2.Text);

            int res = ver_1 + ver_2;

            MessageBox.Show("the result:" + res.ToString() , "Calculation Result:", MessageBoxButtons.OK, MessageBoxIcon.Information  );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ver_1 = int.Parse(textBox1.Text);
            int ver_2 = int.Parse(textBox2.Text);

            int res = ver_1 - ver_2;

            MessageBox.Show("the result:" + res.ToString(), "Calculation Result:", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ver_1 = int.Parse(textBox1.Text);
            int ver_2 = int.Parse(textBox2.Text);

            int res = ver_1 * ver_2;

            MessageBox.Show("the result:" + res.ToString(), "Calculation Result:", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ver_1 = int.Parse(textBox1.Text);
            int ver_2 = int.Parse(textBox2.Text);

            int res = ver_1 / ver_2;

            MessageBox.Show("the result:" + res.ToString(), "Calculation Result:", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
