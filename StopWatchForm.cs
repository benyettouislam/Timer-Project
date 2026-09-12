using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Timer_Project
{
    public partial class StopWatchForm : Form
    {
        private double Counter = 0;
        private double FirstCounter = 0;
        
        public StopWatchForm()
        {
            InitializeComponent();
        }

        private void StopWatchForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 23; i++)
            {
                comboBoxHours.Items.Add(i);
            }
            comboBoxHours.SelectedIndex = 0;
            for (int i = 0; i <= 59; i++)
            {
                comboBox2Minutes.Items.Add(i);
            }
            comboBox2Minutes.SelectedIndex = 0;
            for (int i = 0; i <= 59; i++)
            {
                comboBoxSeconds.Items.Add(i);
            }
            comboBoxSeconds.SelectedIndex = 0;
            Count();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Counter > 0)
            {
                TimeSpan time = TimeSpan.FromSeconds(Counter);
                Counter--;
                LblTimer.Text = time.ToString(@"hh\:mm\:ss");
                if(FirstCounter>=Counter)
                progressBar1.Value = (int)((Counter / FirstCounter) * 100);
               
            }
            else
            {
                timer1.Enabled = false;
                notifyIcon1.Icon = SystemIcons.Application;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                    notifyIcon1.BalloonTipTitle = "End";
                    notifyIcon1.BalloonTipText = "This the End";
                    notifyIcon1.ShowBalloonTip(1000);
                
                
            }
           
        }
           
        private void Count()
        {
            if (comboBoxHours.SelectedItem == null ||
        comboBox2Minutes.SelectedItem == null ||
        comboBoxSeconds.SelectedItem == null)
            {
                return; 
            }

           
            int Hours = Convert.ToInt32(comboBoxHours.SelectedItem);
            int Minutes = Convert.ToInt32(comboBox2Minutes.SelectedItem);
            int Seconds = Convert.ToInt32(comboBoxSeconds.SelectedItem);

            Counter = (Hours * 60 * 60) + (Minutes * 60) + Seconds;
            FirstCounter=Counter;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Count();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Count();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Count();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
           
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Value = 100;
            
        }
    }
}
