using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs21_Property
{
    class Boiler
    {
        public int temp;    // 멤버변수

        public int Temp     // 프로퍼티(속성)
        {
            get { return temp; }
            set { 
                if (value <= 10 || value >= 70)
                {
                    temp = 10;  // 제일 낮은 온도로 변경설정
                }
                else
                {
                    temp = value;
                }

                
            }
        }


        // 위의 get; set;과 비교 // 아래의 Get메서드와 Set메서드는 자바에서만 사용, C#에선 거의 안씀 (프로퍼티 사용함)
        public void SetTemp(int temp)
        {
            if (temp < 10 || temp >= 70)
            {
                //Console.WriteLine("수온설정값이 너무 낮거나 높습니다. 10~70도 사이로 지정해주세요");
                //return;
                this.temp = 10;
            }
            else
            {
                this.temp = temp;
            }

            this.temp = temp;
        }

        public int GetTemp() { return this.temp;}
    }

    class Car       // 프로퍼티 => 변수들 전체 드래그 후, Alt Enter => 캡슐화클릭
    {

        int year;
        string fueltype;
        int door;
        string tireType;
        string company;

        public string Name { get; set; }        // 필터링 필요없으면 멤버변수 없이 프로퍼티로 대체
        public string Color { get; set; }
        public int Year {
            get {return year; }     // get => year; 람다식에서 나옴
            set
            {
                if(value<=1990 || value >=2023)
                {
                    value = 2023;
                }
                year = value;
            }
        }
        public string FuelType
        {
            get { return fueltype; }     // get => fueltype 
            set
            {
                if (value != "휘발유" || value != "경유")
                {
                    value = "휘발유";
                }
                fueltype = value;
            }
        }
        public int Door { get ; set; }

        public string Company { get; set; } = "현대자동차";
        public string TireType { get => tireType; set => tireType = value; }
    }

    interface Iproduct
    {
        string ProductName { get; set; }

        void Produce();
    }

    class MyProduct : Iproduct
    {
        private string productName;
        public string ProductName { 
            get { return productName; }
            set { productName = value; }
        }

        public void Produce()
        {
            Console.WriteLine("{0}을 생산합니다.", ProductName);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            //kitturami.temp = 60;

            //// ...
            //kitturami.temp = 300;   // 보일러 물 온도가 300도 = 말이안됨
            //kitturami.temp = -120;  // 말이 안됨 => 데이터 오염

            kitturami.SetTemp(50);
            Console.WriteLine(kitturami.GetTemp());

            Boiler navien = new Boiler();
            navien.Temp = 5000;
            Console.WriteLine(navien.Temp);

            Car ionic = new Car();
            
            ionic.Name = "아이오닉";    //  set이 없으면 값을 할당하지 못한다, get이 없으면 값을 가져오지 못한다.
            Console.WriteLine(ionic.Name);

            //생성할때 프로퍼티로 초기화
            Car genesis = new Car()
            {
                Name = "제네시스",
                FuelType = "휘발유",
                Color = "흰색",
                Door = 4,
                TireType = "광폭타이어",
                Year = 0,

            };

            Console.WriteLine("자동차제조회사는 {0}", genesis.Company);
            Console.WriteLine("자동차 제조년도는 {0}", genesis.Year);
        }
    }
}
