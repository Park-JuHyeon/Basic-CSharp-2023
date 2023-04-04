using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs06_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 4000000;        // 모든 자료형 표시가능한 var 형식!!
            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

            var b = 3.141952;       // f여부에 따라서 double/float 알아서 변경해주는 var!
            Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);

            var c = "Hello";
            Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);


        }
    }
}
