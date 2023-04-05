using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs10_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트연산자  << == *2 / >> == /2
            int firstval = 0b1111;      // 15 = 0b1111
            int secondval = firstval << 1;      // 11110 으로 바뀜 = 16 + 8 + 4 + 2 = 30
            Console.WriteLine(secondval);       // 30 출력

            firstval = 15;
            secondval = 13;
            Console.WriteLine(firstval & secondval);
            firstval = 10;
            secondval = 5;
            Console.WriteLine(firstval | secondval);
            Console.WriteLine(firstval ^ secondval);    // XOR
            Console.WriteLine(~secondval);      // 보수
            // 실무에서는 그닥 안씀

            // Null 병합 연산자
            int? checkval = null;
            Console.WriteLine(checkval == null? 0 : checkval);  // 만약에 checkval이 널이면, 0을출력하고 아니면 checkval을 출력해라! = 0출력                                      
            Console.WriteLine(checkval ?? 0);

            checkval = 25;
            Console.WriteLine(checkval.HasValue ? checkval.Value : 0);  // 만약에 checkval이 값을가지고 있으면, checkval값 출력하고 아니면 0출력 = 25출력                                      
            Console.WriteLine(checkval ?? 0);   // 위와 같은 작업 = 25출력

        }
    }
}
