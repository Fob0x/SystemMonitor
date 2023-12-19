using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SystemMonitorByFobox
{
    internal class GPUEngine : MainParameters
    {
        public GPUEngine() { }
        

        public Queue<float> gpuHistory = new Queue<float>();
        float gpu;
        Double minTemperatureOfGPU = 200;
        Double maxTemperatureOfGPU;
        protected override void Init()
        {
            counter = new PerformanceCounter("Processor", "% Processor Time", "_total");
        }

        public float GetValue()
        {
            Computer computer = new Computer();
            computer.GPUEnabled = true;
            computer.Open();

            // Добавляем мониторинг для каждого обнаруженного GPU
            foreach (var hardwareItem in computer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.GpuNvidia || hardwareItem.HardwareType == HardwareType.GpuAti)
                {
                    hardwareItem.Update();

                    gpu = hardwareItem.Sensors.Where(sensor => sensor.SensorType == SensorType.Load && sensor.Name == "GPU Core").Single().Value.GetValueOrDefault();

                }
            }
            return gpu;

        }

        //public float GetValue() => computer.Hardware
        //                          .Where(hardwareItem => hardwareItem.HardwareType == HardwareType.GpuNvidia || hardwareItem.HardwareType == HardwareType.GpuAti)
        //                          .SelectMany(hardwareItem =>
        //                          {
        //                          hardwareItem.Update();
        //                          return hardwareItem.Sensors.Where(sensor => sensor.SensorType == SensorType.Load && sensor.Name == "GPU Core").Select(sensor => sensor.Value.GetValueOrDefault());
        //                          })
        //                          .FirstOrDefault();

        public float GetTemperatureOfGPU()
        {
            Computer computer = new Computer();
            computer.GPUEnabled = true;
            computer.Open();
            float temperatureOfGPU = 0;
            foreach (var hardwareItem in computer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.GpuNvidia || hardwareItem.HardwareType == HardwareType.GpuAti)
                {
                    hardwareItem.Update();

                    temperatureOfGPU = hardwareItem.Sensors.Where(sensor => sensor.SensorType == SensorType.Temperature).Single().Value.GetValueOrDefault();

                    //foreach (var sensor in hardwareItem.Sensors)
                    //{
                    //    if (sensor.SensorType == SensorType.Temperature)
                    //        temperatureOfGPU = sensor.Value.GetValueOrDefault();
                    //}
                }
            }
            return temperatureOfGPU;
        }

        public double GetMinTemperatureOfGPU()
        {
            if (GetTemperatureOfGPU() < minTemperatureOfGPU)
                minTemperatureOfGPU = GetTemperatureOfGPU();
            return minTemperatureOfGPU;
        }

        public double GetMaxTemperatureOfGPU()
        {
            if (GetTemperatureOfGPU() > maxTemperatureOfGPU)
                maxTemperatureOfGPU = GetTemperatureOfGPU();
            return maxTemperatureOfGPU;
        }

        public override string GetRoundedValue()
        {
            return Convert.ToString(Math.Round(GetValue(), 1)) + " %";
        }
    }
}
