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
    public partial class CurrentTimeForm : Form
    {
        public CurrentTimeForm()
        {
            InitializeComponent();
        }

        private void CurrentTimeForm_Load(object sender, EventArgs e)
        {
            lblCurrnetTime.Text = "";
          
            
              
            
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime();
            dt1 = DateTime.Now;
            lblCurrnetTime.Text = dt1.ToString("T");
        }
    }
}
