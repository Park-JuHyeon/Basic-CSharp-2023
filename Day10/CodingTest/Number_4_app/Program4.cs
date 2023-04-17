using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_4_app
{
    class Rainbow
    {
        public string Red { get; set; }
        public string Orange { get; set; }
        public string Yellow { get; set; }
        public string Green { get; set; }
        public string Blue { get; set; }
        public string DeepBlue { get; set; }
        public string Purple { get; set; }
    }

    internal class Program4
    {
        static void Main(string[] args)
        {
            Rainbow rainbow = new Rainbow();
            rainbow.Red = "빨간색";
            rainbow.Yellow = "노란색";
            rainbow.Green = "초록색";
            rainbow.Blue = "파란색";
            rainbow.DeepBlue = "남색";
            rainbow.Purple = "보라색";
            rainbow.Orange = "주황색";
            Console.WriteLine("무지개의 색은 {0}, {1}, {2}, {3}, {4}, {5}, {6}, 입니다\n",
                   rainbow.Red, rainbow.Orange, rainbow.Yellow, rainbow.Green, rainbow.Blue, rainbow.DeepBlue, rainbow.Purple);
            Console.WriteLine("Key와 Value 확인");
            Console.WriteLine("Purple은 {0} 입니다.", rainbow.Purple);

        }
    }
}
