using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs09_nullcondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foo myfoo = null;       // new Foo();
            // myfoo.member = 30;

            /*int? bar;
            if (myfoo != null)
            {
                bar = myfoo.member;
            }
            else
            {
                bar = null;
            }*/

            // 위의 아홉줄을 모두 축약시킴
            int? bar = myfoo?.member;

            Console.WriteLine(bar);
        }
    }

    class foo
    {
        public int member;

    }


}
