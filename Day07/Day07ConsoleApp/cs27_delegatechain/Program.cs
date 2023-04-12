using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace cs27_delegatechain
{
    delegate void ThereIsAFire(string location);    // 불났을때 대신해주는 대리자

    delegate int Calc(int a, int b);    // 대리자

    delegate string Concatenate(string[] args);

    class Sample
    {
        private int valueA;   // 멤버 변수 - 외부에서 접근 불가

        public int ValueA    // 프로퍼티
        {
            //get { return valueA; }
            //set { valueA = value; }
            get => valueA;
            set => valueA = value;  // 람다식으로 정의
        }
    }

    internal class Program
    {
        static void Call119(string location)
        {
            Console.WriteLine("그기 소방서죠? {0}에 불났어요~!", location);
        }

        static void ShoutOut(string location) 
        { 
            Console.WriteLine("{0}에 불이야! 불~!", location); 
        }

        static void Escape(string location)
        {
            Console.WriteLine("{0}에서 탈출합니다", location);
        }

        static string ProcConcate(string[] args)
        {
            string result = string.Empty;   // == "";
            foreach (string s in args)
            {
                result += s + "/";
            }
            return result;
        }

        static void Main(string[] args)
        {
            #region < 대리자체인 >
            // 하나하나 따로 수행해야하는 구문
            //var loc = "우리집";
            //Call119(loc);
            //ShoutOut(loc);
            //Escape(loc);

            //// 불이 날 수도 있으니까 미리 준비 한번에 연결해서 실행 가능함.
            //var loc2 = "경찰서";
            //ThereIsAFire fire = new ThereIsAFire(Call119);
            //fire += new ThereIsAFire(ShoutOut);
            //fire += new ThereIsAFire(Escape);       // 대리자에 메서드 추가

            //fire(loc2);

            //fire -= new ThereIsAFire(ShoutOut);     // 대리자에 메서드 삭제

            //fire("다른집");

            //// 익명함수
            //Calc plus = delegate (int a, int b)
            //{
            //    return a + b;
            //};

            //Console.WriteLine(plus(6, 7));

            //Calc minus = (a, b) => { return a - b; };

            //Console.WriteLine(minus(9, 7));

            //Calc simpleMinus = (a, b) => a - b;     // 람다식 (익명 함수)
            #endregion

            Concatenate concat = new Concatenate(ProcConcate);
            var result = concat(args);

            Console.WriteLine(result);

            Console.WriteLine("람다식으로..");
            Concatenate concat2 = (arr) =>
            {
                string res = string.Empty;   // == "";
                foreach (string s in args)
                {
                    res += s + "/";
                }
                return res;
            };
            Console.WriteLine(concat2(args));

        }
    }
}
