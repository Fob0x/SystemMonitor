using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitorByFobox
{
    public abstract class BaseParameter
    {
        protected PerformanceCounter counter;
        protected float currentValue;
        public BaseParameter()
        {
            Init();
        }

        virtual protected void Init()
        {
            if (counter is null)
            {
                throw new Exception("Не указан PerformanceCounter");
            }
        }

        virtual public float GetValue()
        {
            currentValue = counter.NextValue();
            return currentValue;
        }

        virtual public string GetRoundedValue()
        {
            return Convert.ToString(Math.Round(currentValue, 1)) + " %";
        }
    }
}
