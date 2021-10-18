using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NewYearsEve
{
    public partial class Form1 : Form
    {
        private DateTime CurrentTime;
        private DateTime Midnight;
        private TimeSpan CountDown;
        TimerCallback tc;
        private System.Threading.Timer t;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentTime = DateTime.Now;

            Midnight = new DateTime(2020, 12, 31, 23, 59, 59, DateTimeKind.Local);

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            restart();
            int dayOfYear = DateTime.Now.DayOfYear;
            progressBar1.Value = dayOfYear;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.ForeColor = Color.Purple;
            progressBar1.BackColor = Color.Violet;
           
                          

            

        }

        
        private void restart()
        {
            tc = new TimerCallback(CheckTime);
            t = new System.Threading.Timer(tc, null, 1000, 1000);
        }

        private void CheckTime(object state)
        {
            CurrentTime = DateTime.Now;
            CountDown = Midnight - CurrentTime;


            labelCurrentDays.Invoke((MethodInvoker)delegate
            {
                if (DateTime.Now.Hour >= 0 | DateTime.Now.Hour < 12)
                {
                    int correction = CountDown.Days - 1;
                    labelCurrentDays.Text = string.Format("{0:F0}", correction.ToString("N0"));
                }
                else
                {
                    labelCurrentDays.Text = string.Format("{0:F0}", CountDown.Days.ToString("N0"));
                }
                
            });
            labelCurrentHours.Invoke((MethodInvoker)delegate
            {
                labelCurrentHours.Text = String.Format("{0:D02}", Math.Abs(CountDown.Hours));
            });
            labelCurrentMinutes.Invoke((MethodInvoker)delegate
            {
                labelCurrentMinutes.Text = string.Format("{0:D02}", Math.Abs(CountDown.Minutes));
            });
            labelCurrentSeconds.Invoke((MethodInvoker)delegate
            {
                labelCurrentSeconds.Text = string.Format("{0:D02}", Math.Abs(CountDown.Seconds));
            });
            labelHours.Invoke((MethodInvoker)delegate
            {
                labelHours.Text = string.Format("Total hours to go: {0:F0}", Math.Floor(CountDown.TotalHours));
            });
            
            this.Invoke((MethodInvoker)delegate
            {
                this.Text = string.Format("Total hours to go: {0:F0}", Math.Floor(CountDown.TotalHours));
            });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
