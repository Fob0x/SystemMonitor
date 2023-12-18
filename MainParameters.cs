using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitorByFobox
{
    public class MainParameters
    {
        protected PerformanceCounter counter;
        protected float currentValue = 0f;
        
        public MainParameters() { Init(); }

        virtual protected void Init()
        {
            if (counter is null)
                throw new Exception("Не указан PerfomanceCounter");
        }

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
