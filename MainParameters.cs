using System;
using System.Diagnostics;

namespace SystemMonitorByFobox
{
    public class MainParameters
    {
        protected PerformanceCounter counter;
        protected float currentValue = 0f;

        public MainParameters() => Init();

        virtual protected void Init()
        {
            if (counter is null)
                throw new Exception("Не указан PerfomanceCounter");
        }

        /// <summary>
        /// Получить значение параметра
        /// </summary>
        /// <param name="update">Получить следующее значение параметра</param>
        /// <returns></returns>
        virtual public float GetValue(bool update = false)
        {
            if (update)
                currentValue = counter.NextValue();
                
            return currentValue;
        }

        virtual public string GetRoundedValue()
        {
            return Convert.ToString(Math.Round(currentValue, 1)) + " %";
        }
    }
}