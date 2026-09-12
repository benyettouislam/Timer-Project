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
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }
        int Counter = 0;
        private void TimerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRsest_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Counter = 0;
            lblTimer.Text = "00:00:00";

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            lblTimer.Text = Counter.ToString();
            TimeSpan time = TimeSpan.FromSeconds(Counter);

            // فرمتة النص ليظهر بشكل تايمر دقيق
            lblTimer.Text = time.ToString(@"hh\:mm\:ss");
        }
    }
}
