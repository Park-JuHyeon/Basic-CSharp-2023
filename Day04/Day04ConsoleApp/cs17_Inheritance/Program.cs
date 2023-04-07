using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs17_Inheritance
{
    // 상속을 해줄 부모클래스
    class Parent
    {
        protected string Name;     // 상속할때는 private 쓰지말것! , protected 사용가능

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine("{0} from Parent 생성자", Name);
        }

        public void ParentMethod()
        {
            Console.WriteLine("{0} from Parent 메서드", Name);
        }
    }

    // 상속 받을 Child
    class Child : Parent
    {
        public Child(string Name) : base(Name)  // 부모생성자 먼저 실행한뒤 자식 생성자를 실행
        {
            Console.Write("{0} from Child 생성자", Name);
        }

        public void ChildMethod()
        {
            Console.WriteLine("{0} from Child 메서드", Name);
        }
    }

    class Mammal   // 포유류 클래스
    { 
        public void Nurse()
        {
            Console.WriteLine("포유류 기르다");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Cat : Mammal 
    { 
        public void Meow()
        {
            Console.WriteLine("이얏호응!");
        }
    }

    class Elephant : Mammal
    {
        public void Poo()
        {
            Console.WriteLine("뿌우우");
        }
    }

    class ZooKeeper     // 동물들을 씻기는 사육사 클래스
    {
        public void Wash(Mammal mammal)
        {
            if (mammal is Elephant)
            {
                var animal = mammal as Elephant;    // as : 형식변환 연산자
                Console.WriteLine("코끼리를 씻깁니다.");
                animal.Poo();
            }
            else if (mammal is Dog)
            {
                var animal = mammal as Dog;
                Console.WriteLine("강아지를 씻깁니다");
                animal.Bark();
            }
            else if (mammal is Cat)
            {
                var animal = mammal as Cat;
                Console.WriteLine("고양이를 씻깁니다");
                animal.Meow();
                animal.Meow();
                animal.Meow();
                animal.Meow();
                animal.Meow();
            }
        }

        

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region < 기본상속 개념 >
            Parent p = new Parent("p");
            p.ParentMethod();

            Console.WriteLine("자식클래스 생성");
 
            Child c = new Child("c");   // 생성자 호출!
            c.ParentMethod();
            c.ChildMethod();        // 자식클래스는 부모클래스의 속성 기능을 모두 사용 가능!(단, Public, Protected일때만)
            #endregion

            #region < 클래스간 형식변환 >

            //Mammal mammal = new Mammal(); // 기본
            Mammal mammal = new Dog();
            // mammal.Bark()   // 바로는 안됨
            if (mammal is Dog)      // is : 객체가 해당 형식에 해당하는지 검사
            {
                Dog midDog = mammal as Dog;     // (Dog)mammal 은 구식
                midDog.Bark();
            }

            // Dog dog = new Mammal(); // 부모클래스가 자식클래스로 변환은 불가
            Dog dog2 = new Dog();
            Cat cat2 = new Cat();
            Elephant el2 = new Elephant();

            ZooKeeper keeper = new ZooKeeper();
            keeper.Wash(dog2);
            keeper.Wash(cat2);
            keeper.Wash(el2);

            #endregion


        }
    }
}
