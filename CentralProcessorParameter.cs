using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Management;
using System;
using OpenHardwareMonitor.Hardware;
namespace SystemMonitorByFobox
{
    internal class CentralProcessorParameter : MainParameters
    {
        public CentralProcessorParameter() { }
        string NameOfProcessor;
        public Queue<float> cpuHistory = new Queue<float>();
        public static List<float> Temperatures;
        Double minTemperatureOfCPU = 200;
        Double maxTemperatureOfCPU;
        protected override void Init()
        {
            counter = new PerformanceCounter("Processor", "% Processor Time", "_total");
        }

        public string GetNameOfProcessor()
        {
            string query = "SELECT Name FROM Win32_Processor";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            ManagementObject processor = searcher.Get().Cast<ManagementObject>().FirstOrDefault();

            string NameOfProcessor = processor != null ? processor["Name"].ToString() : "Unknown";
            return NameOfProcessor;
        }

        public float GetTemperatureOfProcessor()
        {

            Computer computer = new Computer();
            computer.CPUEnabled = true;
            computer.Open();
            float temperatureOfProcessor = 0;
            foreach (var hardwareItem in computer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.CPU)
                {
                    hardwareItem.Update();

                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                            temperatureOfProcessor = sensor.Value.GetValueOrDefault();
                    }
                }
            }

           
            
            return temperatureOfProcessor; 
        }

        public double GetMinTemperatureOfCPU()
        {
            if (GetTemperatureOfProcessor() < minTemperatureOfCPU)
                minTemperatureOfCPU = GetTemperatureOfProcessor();
            return minTemperatureOfCPU;
        }

        public double GetMaxTemperatureOfCPU()
        {
            if (GetTemperatureOfProcessor() > maxTemperatureOfCPU)
                maxTemperatureOfCPU = GetTemperatureOfProcessor();
            return maxTemperatureOfCPU;
        }

    }
}
