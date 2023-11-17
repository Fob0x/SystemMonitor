using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Runtime.InteropServices;
using System.Management;
using System.Runtime.CompilerServices;

namespace SystemMonitorByFobox
{
    public partial class Form1 : MetroForm
    {
        private float cpu; // Записываем данные со счётчиков производительности

        private float ram; // Записываем данные со счётчиков производительности

        private ulong installedMemory; // Первоначальное кол-во оперативной памяти

        private Queue<float> cpuHistory = new Queue<float>();
        private Queue<float> ramHistory = new Queue<float>();
        private int historyLength = 60; // Длина истории в секундах

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MEMORYSTATUSEX mEMORYSTATUSEX = new MEMORYSTATUSEX();

            if (GlobalMemoryStatusEx(mEMORYSTATUSEX))
                installedMemory = mEMORYSTATUSEX.ullTotalPhys; // Общий объём оперативки

            metroLabel10.Text = Convert.ToString(Math.Round(((float)installedMemory / 1073741824), 1)) + " Gb"; // Зн-е возвращается в байтах, поэтому переводим в ГБ

            timer1.Interval = 1000; // МилиСекунд = 1 сек

            timer1.Start();

            metroLabel11.Text = GetProcessorName();
        }
        // Атрибут StructLayout позволяет вам управлять тем, как компилятор размещает поля данных в памяти для структуры.
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        /*StructLayout(LayoutKind.Sequential): 
        Указывает, что поля в структуре должны располагаться в памяти последовательно, одно за другим. 
        Это означает, что порядок объявления полей в коде будет соответствовать порядку их размещения в памяти. 
        CharSet = CharSet.Auto:
        Определяет, как компилятор должен обрабатывать символы (char) в структуре при взаимодействии с внешним кодом (например, вызовами API). 
        CharSet.Auto позволяет компилятору автоматически выбирать между Unicode и ANSI в зависимости от настроек компиляции проекта и целевой платформы.*/


        private class MEMORYSTATUSEX                /* Структура MEMORYSTATUSEX содержит информацию о памяти компьютера (общей, доступной и виртуальной). 
                                                     * Все значения хранятся как 64-битные числа (https://rusproject.narod.ru/winapi/m/memorystatusex.html)*/
        {
            public uint dwLenght;                   // Размер структуры в байтах
            public uint dwMemoryLoad;               // Процент используемой памяти
            public ulong ullTotalPhys;              // Общий объём физической памяти в байтах
            public ulong ullAvailPhys;              // Объём доступной физической памяти в байтах
            public ulong ullTotalPageFile;          // Размер файла подкачки в байтах
            public ulong ullAvailPageFile;          // Доступный объём байтов в файле подкачки
            public ulong ullTotalVirtual;           // Общёи объём виртуальной памяти
            public ulong ullAvailVirtual;           // Объём доступной виртаульной памяти
            public ulong ullAvailExtendedVirtual;   // Объем незарезервированной памяти в расширенной части виртуальной памяти в байтах
            public MEMORYSTATUSEX() // Kонструктор класса MEMORYSTATUSEX. Он инициализирует поле dwLenght, которое представляет размер структуры.
            {
                this.dwLenght = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX)); // Marshal предоставляет средства для решения проблем, связанных с взаимодействием между управляемым и неменеджерируемым кодом
            }
        }

        [return: MarshalAs(UnmanagedType.Bool)] /* указывает, что возвращаемое значение функции GlobalMemoryStatusEx должно быть интерпретировано как bool и, при необходимости, преобразовано в соответствующий тип в управляемом коде 
                                                 UnmanagedType.Bool говорит о том, что в неменеджерируемом коде ожидается, что значение представляет собой булевское значение */
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBudder); // Она используется для получения информации о состоянии глобальной памяти. вляется внешней функцией из библиотеки kernel32.dll

        private void timer1_Tick(object sender, EventArgs e) // Таймер будет срабатывать каждую секунду и в нём будет происходить наша логика
        {
            cpu = performanceCPU.NextValue();
            ram = performanceRAM.NextValue();

            metroProgressBar1.Value = (int)cpu;
            metroProgressBar2.Value = (int)ram;

            metroLabel2.Text = Convert.ToString(Math.Round(cpu, 1)) + " %";
            metroLabel3.Text = Convert.ToString(Math.Round(ram, 1)) + " %";

            metroLabel8.Text = Convert.ToString(Math.Round((ram / 100 * installedMemory) / 1073741824, 1)) + " Gb"; // Перевели в ГБ
            metroLabel9.Text = Convert.ToString(Math.Round((installedMemory - ram / 100 * installedMemory) / 1073741824, 1)) + " Gb"; // Перевели в ГБ

            //chart1.Series["CPU"].Points.AddY(cpu);
            //chart1.Series["RAM"].Points.AddY(ram);

            // Добавлем новые значения в историю
            cpuHistory.Enqueue(cpu);
            ramHistory.Enqueue(ram);

            while (cpuHistory.Count > historyLength) { cpuHistory.Dequeue(); } // Бляха, так-то можно if ебануть, но вдруг будет какой-то баг и число превысит 61. Хм-хм-хм
            
            while (ramHistory.Count > historyLength) {  ramHistory.Dequeue(); }

            // Обновляем график
            UpdateChart();
            //metroLabel11.Text = GetProcessorName(); //Сука ебаная, блять, что ж ты так нагружаешь приложуху
        }

        //private string GetProcessorName()
        //{
        //    string query = "SELECT * FROM Win32_Processor";

        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

        //    foreach (ManagementObject obj in searcher.Get())
        //    {
        //        processorName = obj["Name"].ToString();
        //        break; // Аыаыаы, блять, как убрать.
        //    }

        //    return processorName;
        //}

        //private string GetProcessorName()
        //{
        //    string query = "SELECT Name FROM Win32_Processor";
        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

        //    return processorName;
        //}

        private string GetProcessorName()
        {
            string query = "SELECT Name FROM Win32_Processor";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            ManagementObject processor = searcher.Get().Cast<ManagementObject>().FirstOrDefault();

            string processorName = processor != null ? processor["Name"].ToString() : "Unknown";

            return processorName;
        }

        private void UpdateChart()
        {
            chart1.Series["CPU"].Points.Clear();
            chart1.Series["RAM"].Points.Clear();

            // Добавляем значения из истории в график
            for (int i = 0; i < cpuHistory.Count(); ++i)
            {
                chart1.Series["CPU"].Points.AddY(cpuHistory.ElementAt(i));
                chart1.Series["RAM"].Points.AddY(ramHistory.ElementAt(i));
            }
        }
    }
}
