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

                    //foreach (var sensor in hardwareItem.Sensors)
                    //{
                    //    // Добавляем мониторинг для нужных сенсоров GPU, например, температуры, загрузки и т. д.
                    //    if (sensor.SensorType == SensorType.Load && sensor.Name == "GPU Core") //"GPU Video Engine")
                    //    {
                    //        gpu = sensor.Value.GetValueOrDefault();
                    //        break;
                    //    }
                    //}
                }
            }
            return gpu;
        }

        public override string GetRoundedValue()
        {
            return Convert.ToString(Math.Round(GetValue(), 1)) + " %";
        }
    }
}
