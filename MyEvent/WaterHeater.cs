using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvent
{
    class WaterHeater
    {
        private int waterTemperature;

        public delegate void AlarmEventHandler(int waterTemperature);
        public event AlarmEventHandler Alarm;

        public void Boilwater(int waterTem)
        {
            for (waterTemperature = waterTem; waterTemperature <= 100; waterTemperature++)
            {
                if (waterTemperature == 80)
                {
                    Alarm += Prompt;
                    if (Alarm != null)
                        Alarm(waterTemperature);
                    Alarm -= Prompt;
                    Alarm += Alarming;
                }
                if (waterTemperature > 80)
                    if (Alarm != null)
                        Alarm(waterTemperature);
            }
        }

        public void Alarming(int waterTemperature)
        {
            Console.WriteLine("警告：水温以超出80度，现在温度"+ waterTemperature);
        }

        public void Prompt(int waterTemperature)
        {
            Console.WriteLine("提示：水温以达{0}度，请尽快关闭热水器",waterTemperature);
        }
    }
}
