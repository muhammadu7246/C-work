using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
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
            string name = textBox1.Text;
            string pass = textBox2.Text;

            if (name == "usama" && pass == "123")
            {
                MessageBox.Show("YOU have been seccesfully login here!" + MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("YOUR details is wrong!" + MessageBoxButtons.OK);


            }
        }
    }
}
