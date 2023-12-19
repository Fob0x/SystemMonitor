using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;

namespace SystemMonitorByFobox
{
    internal class MemoryParameter : MainParameters
    {
        public MemoryParameter() { }
        ulong installedMemory = 0;
        const int conversionToGb = 1073741824;
        public Queue<float> ramHistory = new Queue<float>();

        protected override void Init()
        {
            counter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        }

        public string GetUsingMemory()
        {
            return Convert.ToString(Math.Round((currentValue / 100 * installedMemory) / conversionToGb, 1)) + " Gb";
        }

        public string GetAvailableMemory()
        {
            return Convert.ToString(Math.Round((installedMemory - currentValue / 100 * installedMemory) / conversionToGb, 1)) + " Gb"; // Перевели в ГБ
        }

        public ulong GetInstalledMemory()
        {
            if (installedMemory == 0)
            {
                string query = "SELECT TotalPhysicalMemory FROM Win32_ComputerSystem";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
            {
                    long totalMemory = Convert.ToInt64(obj["TotalPhysicalMemory"]);
                    installedMemory = (ulong)totalMemory;
                }
            }
            return installedMemory;
        }
    }
}
