using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuelOS
{
    public partial class TaskManager : UserControl
    {

        public TaskManager()
        {
            InitializeComponent();
            loadProcesses();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            loadProcesses();
        }

        public void loadProcesses()
        {
           
        }
    }
}
