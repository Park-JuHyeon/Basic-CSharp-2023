using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs12_methods
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {
        /// <summary>
        /// 실행시 메모리에 최초로 올라가야하기때문에 static이 있어야 하고
        /// 메서드 이름이 Main이면 실행될때 알아서 제일 먼저 시작된다.
        /// </summary>
        /// <param name="args"></param>
  
        static void Main(string[] args)
        {
            #region < static 메서드 >
            int result = Calculator.Plus(1, 2);
            // static은 최초실행때 메모리에 바로 올라가기때문에
            // 클래스에 객체를 만들 필요가 없다(new를 만들 필요가 없다.)

            //Calculator.Minus(3, 2);   // minus는 static이 아니기때문에 접근불가( 객체 생성해야 접근 가능 ) 
            result = new Calculator().Minus(3, 2);
            Console.WriteLine(result);
            #endregion

            #region <Call by reference vs Call by value 비교>
            int x = 40; int y = 4;
            // ref없으면 value를 가져옴
            Swap(ref x, ref y);     // x, y가 가지고 있는 주소를 전달하라 Call by reference == pointer

            Console.WriteLine("x = {0}, y = {1}", x, y);

            //Console.ReadLine(GetNumber(x));
            #endregion

            #region < out 매개변수 >

            int divid = 30;
            int divor = 2;
            int rem = 0;

            //Divide(divid, divor, ref result, ref rem);

            Divide(divid, divor, out result, out rem);// ref를 out으로 대체ㅐ해서 사용 가능
            Console.WriteLine("나누기값 {0}, 나머지 {1}", result, rem);    // 나누기 값 15, 나머지 0

            (result, rem) = Divide(20, 6);
            Console.WriteLine("나누기값 {0}, 나머지 {1}", result, rem);    // 나누기값 3, 나머지 2

            #endregion

            #region < 가변길이 매개변수 >

            //int resSum = Sum(1, 3, 5, 7, 9);
            Console.WriteLine(Sum(1, 3, 5, 7, 9));

            #endregion
        }

        /*
        static int Divide(int x, int y)
        {
            return x / y;
        }

        static int Reminder(int x, int y)
        {
            return x % y;
        }*/

        // 메서드 두개만들것을 하나로 만들수있음
        // static void Divide(int x, int y, ref int val, ref int rem)

        static void Divide(int x, int y, out int val, out int rem)
        {
            val = x / y;
            rem = x % y;
        }

        static (int result, int rem) Divide(int x, int y)
        {
            return (x / y, x % y);
        }

        static (float result, float rem) Divide(float x, float y)
        {
            return (x/y, (int)x % y);   // 나머지는 실수가 없으므로 int로 변환
        }

        // Main 메서드와 같은 레벨에 있는 메서드들은 전부 static이 되어야함(무조건!!)
        public static void Swap(ref int a, ref int b)
        {
            int temp = 0;
            temp = a;   // 5 : temp = 5
            a = b;      // a = 4
            b = temp;   // b = 5
        }

        static int val = 100;

        public static ref int GetNumber(ref int val1)
        {
            return ref val;     // static메서드에 접근할 수 있는 변수는 static 밖에 없음
        }

        public static int Sum(params int[] args)    // Python 가변길이 매개변수랑 비교
        {
            int sum = 0;

            foreach (var item in args)
            {
                sum += item;
            }
            return sum;
        }
    }
}
