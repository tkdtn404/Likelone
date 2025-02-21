using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //캐릭터
            int hp = 100;
            double att = 56.7;
            string name = "카타리나";
            char tear = 's';

            Console.WriteLine("HP : " + hp);
            Console.WriteLine("공격력 : " + att);
            Console.WriteLine("캐릭터 이름 : " + name);
            Console.WriteLine("등급 : " + tear);
        }
    }
}
