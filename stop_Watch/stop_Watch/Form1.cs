using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stop_Watch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            msiclb.Text = "00";
            seclb.Text = "00";
            minlb.Text = "00";
            hourlb.Text = "00";
            timer1.Enabled = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int msecs = Convert.ToInt32(msiclb.Text);
            int secs = Convert.ToInt32(seclb.Text);
            int mins = Convert.ToInt32(minlb.Text);
            int hrs = Convert.ToInt32(hourlb.Text);

            msecs = msecs + 1;
            msiclb.Text = msecs.ToString();

            if (msecs >= 60)
            {
                msiclb.Text = "00";
                secs = secs + 1;
                seclb.Text = secs.ToString();


            }
            else if (secs >= 60)
            {
                seclb.Text = "00";
                mins = mins + 1;
                minlb.Text = mins.ToString();

            }
            else if (mins >= 60)
            {
                minlb.Text = "00";
                hrs = hrs + 1;
                hourlb.Text = hrs.ToString();




            }

        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void resume_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
