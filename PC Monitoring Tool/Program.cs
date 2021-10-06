using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_Monitoring_Tool.UI;
using PC_Monitoring_Tool.PC;


namespace PC_Monitoring_Tool
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {


            //SystemInfo.GetSystemInfo();

            //SystemInfo_Old.GetSystemInfo();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home()); 
        }
    }
}