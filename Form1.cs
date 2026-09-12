using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncurrentclock_Click(object sender, EventArgs e)
        {
             CurrentTimeForm currentTimeForm = new CurrentTimeForm();
            currentTimeForm.ShowDialog();
        }
        private void CurrentTime()
        {

        }

        private void btntime_Click(object sender, EventArgs e)
        {
            TimerForm timerForm = new TimerForm();
            timerForm.ShowDialog();
        }

        private void btnstopwatch_Click(object sender, EventArgs e)
        {
            StopWatchForm StopWatchForm = new StopWatchForm();
            StopWatchForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
