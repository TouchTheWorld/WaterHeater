using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterHeater waterHeater = new WaterHeater();
            //waterHeater.Alarm += waterHeater.Prompt
            //waterHeater.Alarm += waterHeater.Alarming;
            waterHeater.Boilwater(20);
        }
    }
}
