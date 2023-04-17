using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_5_app
{
    interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }

        void Eat();
        void Sleep();
        void Sound();

    }

    class Dog : IAnimal
    {
        private string name;
        public string Name { get { return name; } set{ name = value; }}

        private int age; 
        public int Age { get { return age; } set { age = value; }}

        public void Eat()
        {
            Console.WriteLine("밥을 맛있게 먹습니다. 멍멍");
        }
        public void Sleep()
        {
            Console.WriteLine("굿나잇. 멍멍");
        }
        public void Sound()
        {
            Console.WriteLine("멈ㅇ멍ㅁ엄엄엄ㅁ어ㅓㅇ멍멍 왈오ㅓㅏㄹ 크르ㅡ");
        }
    }

    class Cat : IAnimal
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int age;
        public int Age { get { return age; } set { age = value; } }

        public void Eat()
        {
            Console.WriteLine("밥을 맛있게 먹습니다. 야옹");
        }
        public void Sleep()
        {
            Console.WriteLine("굿나잇. 야옹");
        }
        public void Sound()
        {
            Console.WriteLine("야야아아아ㅏㅇ야아야ㅏ야아야아옹");
        }
    }

    class Horse : IAnimal
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int age;
        public int Age { get { return age; } set { age = value; } }

        public void Eat()
        {
            Console.WriteLine("밥을 맛있게 먹습니다. 히히힝");
        }
        public void Sleep()
        {
            Console.WriteLine("굿나잇. ㅎ히히힝");
        }
        public void Sound()
        {
            Console.WriteLine("히히ㅣ히히히히히이히히잉ㅎㅇ");
        }
    }

    internal class Program5
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Horse horse = new Horse();
            dog.Eat();
            dog.Sleep();
            dog.Sound();
            cat.Eat();
            cat.Sleep();
            cat.Sound();
            horse.Eat();
            horse.Sleep();
            horse.Sound();
        }
    }
}
