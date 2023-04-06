using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs13_class
{
    class Cat       // private라도 같은 cs13_class안에 있기때문에 접근 가능
    {
        #region < 생성자 >

        /// <summary>
        /// 기본 생성자
        /// </summary>
        public Cat()
        {
            Name = string.Empty;
            Color = string.Empty;
            Age = 0;
        }

        /// <summary>
        /// 사용자 지정 생성자
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="age"></param>
        public Cat(string name, string color = "흰색", sbyte age = 1)
        {
            Name = name;
            Color = color;
            Age = age;
        }

        #endregion


        #region < 멤버변수 - 속성 >
        public string Name;    // 고양이 이름
        public string Color;   // 고양이 색상
        public sbyte Age;      // 고양이 나이 (0 ~ 255) 까지
        #endregion

        #region < 멤버메서드 - 기능 >
        public void Meow()
        {
            Console.WriteLine("{0} - 야옹~~!", Name);
        }

        public void Run()
        {
            Console.WriteLine("{0} 달린다.", Name);
        }
        #endregion
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat Yatong = new Cat();  // Nero라는 이름의 객체 생성
            Yatong.Name = "이얏호응!";
            Yatong.Color = "흰색, 회색";
            Yatong.Age = 4;

            Yatong.Meow();
            Yatong.Run();

            // 객체 생성하면서 속성 초기화
            Cat Samsaek = new Cat()
            {
                Name = "삼색이",
                Color = "검정, 흰, 주황",
                Age = 5,
            };
            Samsaek.Meow();
            Samsaek.Run();
           
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}살 입니다", Yatong.Name, Yatong.Color, Yatong.Age);
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}살 입니다", Samsaek.Name, Samsaek.Color, Samsaek.Age);

            // 기본생성자 사용
            Cat Mu = new Cat();
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}살 입니다", Mu.Name, Mu.Color, Mu.Age);

            Cat DoDo = new Cat("도도", "흰색, 회색");
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}살 입니다", DoDo.Name, DoDo.Color, DoDo.Age);




        }
    }
}
