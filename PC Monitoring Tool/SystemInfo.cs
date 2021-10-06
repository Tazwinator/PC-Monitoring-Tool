using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenHardwareMonitor.Hardware;
using System.Windows.Forms;

namespace PC_Monitoring_Tool.PC
{
    /// <summary>
    /// More advanced method of getting temps with more sensors
    /// </summary>
    public class SystemInfo
    {
        public class GPU
        {
            public static string temp;
            public static string coreClock;
            public static string memClock;
            public static string memUsed;
            public static string utilisation;
        };

        public class CPU
        {
            public static string packageTemp;
            public static string ccd1Temp;
            public static string clockBusSpeed;
            public static List<string> Clocks = new List<string>();
            public static List<string> Utilisation = new List<string>();
        };

        /// <summary>
        /// You need to "visit" and "traverse" the PC to get the sensor.sensortype to populate
        /// </summary>
        private class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }
        public static void GetSystemInfo()
        {      
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            try
            {
                computer.Open(); 
                computer.GPUEnabled = true;
                computer.CPUEnabled = true;
                computer.Accept(updateVisitor); // You NEED this line to update
                CPU.Clocks.Clear();
                CPU.Utilisation.Clear();


                if (computer.Hardware.Length > 0)
                {
                    foreach (var item in computer.Hardware)
                    {
                        if (item.HardwareType == HardwareType.CPU)
                        {

                            foreach (ISensor cpu in item.Sensors)
                            {

                                if (cpu.SensorType == SensorType.Clock && cpu.Name == "Bus Speed")
                                    CPU.clockBusSpeed = cpu.Value.ToString();

                                if(cpu.SensorType == SensorType.Clock && cpu.Name != "Bus Speed")
                                    CPU.Clocks.Add("Clock Speed: " + cpu.Value + "Mhz" + cpu.Name);

                                if (cpu.SensorType == SensorType.Load)                               
                                    CPU.Utilisation.Add(cpu.Name + " Usage: " + cpu.Value);                                

                                if (cpu.SensorType == SensorType.Temperature && cpu.Name == "CPU Package")
                                    CPU.packageTemp = cpu.Value + "°C";

                                if (cpu.SensorType == SensorType.Temperature && cpu.Name == "CPU CCD #1")
                                    CPU.ccd1Temp = cpu.Value + "°C"; 
                            }

                        } else if (item.HardwareType == HardwareType.GpuNvidia) {

                            foreach (ISensor gpu in item.Sensors)
                            {
                                if (gpu.Name == "GPU Memory" && gpu.Index == 1)
                                    GPU.memClock = "Memory:" + Math.Round((float)gpu.Value) + "Mhz";

                                if (gpu.Name == "GPU Memory Used")
                                    GPU.memUsed = " Dedicated Memory used:" + Math.Round((float)gpu.Value) + "GB";

                                if (gpu.SensorType == SensorType.Temperature)
                                    GPU.temp = "Temperature:" + Math.Round((float)gpu.Value) + "°C";

                                if (gpu.SensorType == SensorType.Load && gpu.Name == "GPU Core")
                                    GPU.utilisation = "GPU Usage:" + gpu.Value;

                                if (gpu.SensorType == SensorType.Clock && gpu.Name == "GPU Core")
                                    GPU.coreClock = gpu.Value + "Mhz";
                            }

                        }

                    }
                } else
                {
                    MessageBox.Show("No data has been found on your PC, sorry.");
                }

                computer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing hardware data.\n" + ex.Message);
            }           
        }
    }
}
