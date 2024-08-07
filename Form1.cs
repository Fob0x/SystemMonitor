﻿using System;
using System.Linq;
using MetroFramework.Forms;

namespace SystemMonitorByFobox
{
    public partial class SystemMonitorWindow : MetroForm
    {
        private int historyLength = 60; // Длина истории в секундах
        MemoryParameter RAM;
        CentralProcessorParameter CPU;
        GPUEngine GPU;
        
        public SystemMonitorWindow()
        {
            InitializeComponent();
            RAM = new MemoryParameter();
            CPU = new CentralProcessorParameter();
            GPU = new GPUEngine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // МилиСекунд = 1 сек
            timer1.Start();
            
            CounterInstalledMemory.Text = Convert.ToString(Math.Round(((float)RAM.GetInstalledMemory() / 1073741824), 1)) + " Gb"; // Зн-е возвращается в байтах, поэтому переводим в ГБ
            LabelProcessorName.Text = CPU.GetNameOfProcessor();
        }

        private void timer1_Tick(object sender, EventArgs e) // Таймер будет срабатывать каждую секунду и в нём будет происходить наша логика
        {
            ProgressBarCPU.Value = (int)CPU.GetValue(true);
            ProgressBarRAM.Value = (int)RAM.GetValue(true);
            ProgressBarGPU.Value = (int)GPU.GetValue();
           
            metroLabel2.Text = CPU.GetRoundedValue();
            metroLabel3.Text = RAM.GetRoundedValue();
            metroLabel13.Text = GPU.GetRoundedValue();
            
            CounterUsingMemory.Text = RAM.GetUsingMemory();
            CounterAvailableMemory.Text = RAM.GetAvailableMemory();
            CounterProcessorTemperature.Text = CPU.GetTemperatureOfProcessor().ToString();
            CounterGPUTemperature.Text = GPU.GetTemperatureOfGPU().ToString();

            // Добавлем новые значения в историю
            CPU.cpuHistory.Enqueue(CPU.GetValue());
            RAM.ramHistory.Enqueue(RAM.GetValue());
            GPU.gpuHistory.Enqueue(GPU.GetValue());


            if (CPU.cpuHistory.Count > historyLength) { CPU.cpuHistory.Dequeue(); } // Бляха, так-то можно if ебануть, но вдруг будет какой-то баг и число превысит 61. Хм-хм-хм

            if (RAM.ramHistory.Count > historyLength) { RAM.ramHistory.Dequeue(); }

            if (GPU.gpuHistory.Count > historyLength) { GPU.gpuHistory.Dequeue(); }

            // Обновляем график
            UpdateChart();

            metroLabel14.Text = CPU.GetMinTemperatureOfCPU().ToString();
            CounterProcessorTemperatureMax.Text = CPU.GetMaxTemperatureOfCPU().ToString();

            CounterGPUTemperatureMax.Text = GPU.GetMaxTemperatureOfGPU().ToString();
            CounterGPUTemperatureMin.Text = GPU.GetMinTemperatureOfGPU().ToString();
        }

        private void UpdateChart()
        {
            chart1.Series["CPU"].Points.Clear();
            chart1.Series["RAM"].Points.Clear();
            chart1.Series["GPU"].Points.Clear();

            // Добавляем значения из истории в график
            for (int i = 0; i < CPU.cpuHistory.Count(); ++i)
            {
                chart1.Series["CPU"].Points.AddY(CPU.cpuHistory.ElementAt(i));
                chart1.Series["RAM"].Points.AddY(RAM.ramHistory.ElementAt(i));
                chart1.Series["GPU"].Points.AddY(GPU.gpuHistory.ElementAt(i));
            }
        }
    }
}
