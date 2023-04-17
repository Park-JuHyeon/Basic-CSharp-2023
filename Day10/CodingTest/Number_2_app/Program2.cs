using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_2_app
{
    class Boiler
    {
        public byte voltage;
        public int temperature;

        public byte Voltage
        {
            get
            {
                return this.voltage;
            }
            set
            {
                this.voltage = value;
                value = 110;
                value = 220;
            }
        }

        public int Temperature
        {
            get
            {
                return this.temperature;
            }
            set
            {
                if (value <= 5)
                {
                    temperature = 5;
                }
                else if (value >= 70) 
                {
                    temperature = 70;
                }
            }
        }


    }

    internal class Program2
    {
        static void Main(string[] args)
        {
        }
    }
}
