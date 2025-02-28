using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
           ///내장형 구조체
            DateTime now = DateTime.Now;
            Console.WriteLine($"Courrent Date and Time: {now}"); //현제 날짜시간

            TimeSpan duration = new TimeSpan(1, 30, 0);  //1시간 30분
            Console.WriteLine($"Duration: {duration}");

        }
    }
}
