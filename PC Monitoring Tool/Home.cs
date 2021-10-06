using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_Monitoring_Tool.PC;
using Timer = System.Timers.Timer;

namespace PC_Monitoring_Tool.UI
{
    public partial class Home : Form
    {
        public Home()
        {
            try
            {
                InitializeComponent();

                AddSensorData();
            } catch (Exception ex)
            {
                MessageBox.Show("The app has failed to load. Please contact the author to diagnose the problem. \n" + ex.Message);
            }

        }

        public void AddSensorData()
        {

            SystemInfo.GetSystemInfo();

            WireUpCpuData();
            WireUpGpuData();

            RefreshData();

        }

        private void RefreshData()
        {
            // Create a timer with a two second interval.
            Timer RefreshTimer = new Timer(500);
            // Hook up the Elapsed event for the timer. 
            RefreshTimer.Elapsed += (sender, args) => { TimerEvent(); }; // Basically needs a callback
            RefreshTimer.SynchronizingObject = this; // this = Root class here I believe
            RefreshTimer.AutoReset = true;
            RefreshTimer.Enabled = true;
        }

        private void TimerEvent()
        {
            SystemInfo.GetSystemInfo();
            WireUpCpuData();
            WireUpGpuData();

        }

        private void WireUpCpuData()
        {
            cpuTempsListBox.Items.Clear();
            cpuClocksListBox.Items.Clear();
            cpuUtilisationListBox.Items.Clear();
            gpuSensorListBox.Items.Clear();


            cpuTempsListBox.Items.Add(SystemInfo.CPU.packageTemp);
            cpuTempsListBox.Items.Add(SystemInfo.CPU.ccd1Temp);
            cpuTempsListBox.Items.Add(SystemInfo.CPU.clockBusSpeed);


            foreach (string clocks in SystemInfo.CPU.Clocks)
            {

                cpuClocksListBox.Items.Add(clocks);

            }

            foreach (string percentage in SystemInfo.CPU.Utilisation)
            {

                cpuUtilisationListBox.Items.Add(percentage);

            }
        }

        private void WireUpGpuData()
        {

            gpuSensorListBox.Items.Add(SystemInfo.GPU.temp);
            gpuSensorListBox.Items.Add(SystemInfo.GPU.coreClock);
            gpuSensorListBox.Items.Add(SystemInfo.GPU.memClock);
            gpuSensorListBox.Items.Add(SystemInfo.GPU.memUsed);
            gpuSensorListBox.Items.Add(SystemInfo.GPU.utilisation);

        }

    }
}
