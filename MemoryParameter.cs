using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SystemMonitorByFobox
{
    public class MemoryParameter : BaseParameter
    {
        public MemoryParameter() { }
        ulong installedMemory = 0;

        protected override void Init()
        {
            counter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        }
        public string GetUsingMemory()
        {
           return Convert.ToString(Math.Round((currentValue / 100 * GetInstalledMemory()) / 1073741824, 1)) + " Gb"; // Перевели в ГБ
        }
        public string GetAvailableMemory()
        {
            return Convert.ToString(Math.Round((GetInstalledMemory() - currentValue / 100 * GetInstalledMemory()) / 1073741824, 1)) + " Gb"; // Перевели в ГБ
        }
        public ulong GetInstalledMemory()
        {
            if(installedMemory == 0)
            {
                installedMemory = 1234567;
            }
            return installedMemory;
        }
    }
}
