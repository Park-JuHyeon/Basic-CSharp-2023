using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test01
{

    class Parent
    {
        public string name = "ppp";
        public Parent() {
            Console.WriteLine("parent");
        }
        public virtual void info()
        {
            Console.WriteLine(name);
        }
    }

    class Child : Parent
    {
        public string name = "ccc";
        public Child()
        {
            Console.WriteLine("child");   
        }

        public override void info()
        {
            base.info();
            Console.WriteLine(name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.info();
        }
    }
}
