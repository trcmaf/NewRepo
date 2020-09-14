using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class Timer : Form
    {
        System.Windows.Forms.Timer t;

        public Timer()
        {
            InitializeComponent();
        }

        void t_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 10;

            if (progressBar.Value >= 100)
                t.Stop();
        }

        private void Timer_Shown(object sender, EventArgs e)
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }
    }
}