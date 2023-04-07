using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs19_interface
{
    interface ILogger     // 인터페이스 생성자
    {
        void WriteLog(string log);
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params object[] args); // args 다중 파라미터
        
    }

    class ConsoleLogger : ILogger   // 인터페이스를 가져오는것은 '구현'이라고함
    {
        public void WriteLog(string log)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), log);
        }
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)   // 인터페이스 구현
        {
            string message = string.Format(format, args);
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string log)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), log);
        }
    }

    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void Stop()
        {
            Console.WriteLine("정지!");
        }
    }

    interface IHoverable
    {
        void Hover();   // 물에서 달리는 자동차
    }

    interface IFlyable
    {
        void Fly();     // 나는 자동차
    }

    // C#에는 다중상속
    class FlyHoverCar : Car, IFlyable, IHoverable   // C#에서 다중상속을 할 수 있는 방법
    {
        public void Fly()
        {
            Console.WriteLine("날다");
        }

        public void Hover()
        {
            Console.WriteLine("물에서 달림");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("안녕~");

            IFormattableLogger logger2 = new ConsoleLogger2();
            logger2.WriteLog("{0} * {1} = {2}", 6, 5, (6 * 5));
        }
    }
}
