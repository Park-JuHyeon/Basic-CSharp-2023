using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs30_filereadwirte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;     // 텍스트 읽어와서 출력
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(@".\python.py");     // 스트림리더 파일 연결
                
                line = reader.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);    // 한줄 읽은것 출력
                    
                    line = reader.ReadLine();   // 다음줄을 읽음
                }

                reader.Close();     // 파일을 읽으면 무조건 마지막에 닫아줘야함
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외! {ex.Message}");
            }
            finally
            {
                reader.Close();     // 파일 읽으면 무조건 마지막에 닫아줘야함@!!!!!
            }

            // 읽기 끝!

            StreamWriter writer = new StreamWriter(@".\pythonByCsharp_py");

            try
            {
                writer.WriteLine("import sys;");
                writer.WriteLine("");
                writer.WriteLine("print(sys.executable);");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외! {ex.Message}");
            }
            finally
            {
                writer.Close();
            }

            Console.WriteLine("파일생성 완료!");


        }
    }
}
