using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs05_nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null ;      // Int형은 Null값이 될수 없다! C# 6.0 Nullable
                                 // int 뒤에 ?를 붙이면 int에서도 null값이 출력이 가능하다!
            Console.WriteLine(a == null);
            //Console.WriteLine(a.GetType());     // null의 타입을 지정할수 없으므로 예외발생!

            int b = 0;
            Console.WriteLine(b == null);
            Console.WriteLine(b.GetType());

            // 값 형식 short, byte, int , long, float, double, char등은 null값을 가질수 없다!
            // null을 할당 할 수 있도록 만드는 방식 = type?

            float? c = null;
            Console.WriteLine(c.HasValue);      // HasValue : c에 값이 있는지 물어보는것 = false

            c = 3.14f;
            Console.WriteLine(c.HasValue);      // true
            Console.WriteLine(c.Value);         // 3.14
            Console.WriteLine(c);       // 3.14


        }
    }
}
