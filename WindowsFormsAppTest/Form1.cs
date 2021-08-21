using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fCPU = pCPU.NextValue();
            float fRAM = pRAM.NextValue();
            gunaCircleProgressBarRAM.Value = (int)fRAM;
            lblRAMP.Text = ((int)fRAM).ToString() + " %";
            gunaCircleProgressBarCPU.Value = (int)fCPU;
            lblCPUP.Text = ((int)fCPU).ToString() + " %";
            lblHour.Text = DateTime.Now.ToString("HH:mm:ss");

            var date = DateTime.Now;
            gunaCircleProgressBarHour.Value = date.Hour;
            gunaCircleProgressBarMinute.Value = date.Minute;
            gunaCircleProgressBarSec.Value = date.Second;
        }
    }
}
