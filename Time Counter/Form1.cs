using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hour = 0;
        int minute = 0;
        int seconds = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int seconds = Convert.ToInt32(label4.Text);
            seconds++;
            label4.Text = seconds.ToString();

            if (seconds == 59)
            {
                seconds = 0;
                label4.Text = seconds.ToString();
                minute++;
                label5.Text = minute.ToString();
            }

            if (minute == 59)
            {
                minute = 0;
                label5.Text = minute.ToString();
                hour++;
                label6.Text = hour.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            label4.Text = Convert.ToString(0);
            label5.Text = Convert.ToString(0);
            label6.Text = Convert.ToString(0);
        }
    }
}
