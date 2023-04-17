using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_3_app
{
    class Car
    {
        string color;
        int yearModel;
        int maxSpeed;
        string uniqueNumber;

        public string Name { get; set; }
        public string Maker { get; set; }
        public string Color { get; set; }
        public int YearModel { get; set; }
        public int MaxSpeed { get; set; }
        public string UniqueNumber { get; set; }

        public void Start()
        {
            Console.WriteLine("{0}의 시동을 겁니다", Name);
        }

        public void Accelerate()
        {
            Console.WriteLine("최대시속 {0}km/h로 가속합니다.", MaxSpeed);
        }

        public void TurnRight()
        {
            Console.WriteLine("{0}이 우회전합니다.", Name);
        }
        public void Brake()
        {
            Console.WriteLine("{0}의 브레이크를 밟습니다.", Name);
        }

    }

    class ElectricCar : Car
    {
        public void Recharge()
        {
            Console.WriteLine("달리면서 배터리를 충전합니다.");
        }
    }
    class HybridCar : ElectricCar
    {
        public new void Recharge()
        {
            Console.WriteLine("달리면서 배터리를 충전합니다.");
        }
    }

    internal class Program3
    {
        static void Main(string[] args)
        {
            HybridCar ioniq = new HybridCar();
            ioniq.Name = "아이오닉";
            ioniq.Maker = "현대자동차";
            ioniq.Color = "White";
            ioniq.YearModel = 2018;
            ioniq.MaxSpeed = 220;
            ioniq.UniqueNumber = "54라 3346";

            ioniq.Start();
            ioniq.Accelerate();
            ioniq.Recharge();
            ioniq.TurnRight();
            ioniq.Brake();
        }
    }
}
