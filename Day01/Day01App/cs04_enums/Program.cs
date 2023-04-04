using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs04_enums
{
    internal class Program
    {
        enum HomeTown
        {
            SEOUL = 1,      // 열거형들은 숫자로 직접 값 지정이 가능하다
            DAEJEON = 2,
            DAEGU = 4,
            BUSAN = 7,
            JEJU = 5
        }

        static void Main(string[] args)
        {
            HomeTown myHomeTown;
            myHomeTown = HomeTown.BUSAN;

            if (myHomeTown == HomeTown.SEOUL)
            {
                Console.WriteLine("마 니 스울이가!");
            }
            else if(myHomeTown == HomeTown.DAEJEON)
            {
                Console.WriteLine("대전 노잼도시");
            }
            else if(myHomeTown==HomeTown.DAEGU) 
            {
                Console.WriteLine("대프리카 Open");           
            }
            else if(myHomeTown == HomeTown.BUSAN)
            {
                Console.WriteLine("붓싼 아이가~");
            }
        }
    }
}
