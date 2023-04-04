using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cs03_object   // object 형식은 모든 데이터형식을 담을 수 있다!!
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object 형식
            //int == system.Int32
            // long == system.Int64;
            long val = 1111;
            long idata = 1024;         // C#의 모든것들은 클래스로 만들어짐
            Console.WriteLine(idata);
            Console.WriteLine(idata.GetType());

            object iobj = (object)idata;    // 박싱: 데이터타입의 값을 object로 담아라
            Console.WriteLine(iobj);
            Console.WriteLine(iobj.GetType());

            long udata = (long)iobj;        // 언박싱: 오브젝트를 원래 데이터타입으로 바꿔라    
            Console.WriteLine(udata);
            Console.WriteLine(udata.GetType());

            double ddata = 3.141592;
            object pobj = (object)ddata;
            double pdata = (double)pobj;

            Console.WriteLine(pobj);
            Console.WriteLine(pobj.GetType());
            Console.WriteLine(pdata);
            Console.WriteLine(pdata.GetType());

            short sdata = 32000;
            int indata = sdata;
            Console.WriteLine(indata);

            long lndata = long.MaxValue;
            Console.WriteLine(lndata);
            indata = (int)lndata;
            Console.WriteLine(indata);      // long의 데이터값을 int에 담으려고 하니 overflow가 일어남

            // float double간 형변환
            float fval = 3.141592f;  // float 타입은 마지막에 반드시 f를 써줘야한다!
            Console.WriteLine("fval = " + fval);
            double dval = (double)fval;
            Console.WriteLine("dval = " + dval);
            Console.WriteLine(fval == dval);
            Console.WriteLine(dval == 3.141592);

            // 즈엉말 중요@!@ 실무에서 많이 쓰임
            int numival = 1024;
            string strival = numival.ToString();
            Console.WriteLine(strival);
            Console.WriteLine(numival);
            //Console.WriteLine(numival == strival);
            Console.WriteLine(strival.GetType());

            double numdval = 3.14159265358979;
            string strdval = numdval.ToString();
            Console.WriteLine(strdval);

            // 문자열을 숫자로
            // 문자열내에 숫자가 아닌 특수문자나 정수인데 . 이 있거나 하면 안된다!
            string originstr = "45677";     // 숫자가아닌 문자가 들어가서는 안된다
            int convval = Convert.ToInt32(originstr);   // int.Parse()와 동일
            Console.WriteLine(convval);

            originstr = "1.2345";
            float convfloat = float.Parse(originstr);
            Console.WriteLine(convfloat);

            //예외발생하지 않도록 형변환 방법
            originstr = "123.5f";   // f때문에 예외가 발생하게됨
            float ffval;
            // TryParse는 예외발생시 값은 0으로 대체, 예외없으면 원래값으로
            float.TryParse(originstr, out ffval);  // 예외발생하지 않게 숫자변환 비정상적 종료를 막아줌!
            Console.WriteLine(ffval);

            const double pi = 3.141592;     // const로 상수화를 시키면 값의 변경이 불가능하다!!
            Console.WriteLine(pi);

            // pi = 4.56;

            

        }
    }
}
