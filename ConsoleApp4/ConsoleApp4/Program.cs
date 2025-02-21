using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //문자열
             string greeting; // 문자열 변수를 선언
             greeting = "Hello world:"; //변수에 값을 저장

             //변수의 값을 사용
             Console.WriteLine(greeting); //출력 : Hello world*/
            /*
                        //변수 선언과 초기화를 한번에 수행
                        int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
                        double temperature = 36.5; //실수형 변수 선언과 초기화
                        string city = "Seoul"; //문여열 변수 선언과 초기화

                        //변수 출력
                        Console.WriteLine(score); //출력 100
                        Console.WriteLine(temperature); // 출력 36.5
                        Console.WriteLine(city);  //출력 Seoul*/

            /* //같은 데이터 타입의 변수를 쉼표로 구분해서 선언
             int x = 10, y = 20, z = 30; //정수형 변수 x,y,z를 선언하고 초기화

             Console.WriteLine(x);
             Console.WriteLine(y);
             Console.WriteLine(z);*/
            /*
                        //상수: 값을 변경할 수 없는 변수
                        const double pi = 3.14159; //상수 pi선언 및 초기화
                        const int MaxScore = 100; //정수형 상수 선언

                        //출력
                        Console.WriteLine("pi : " + pi); //출력 : 3.14159
                        Console.WriteLine("Max Score : " + MaxScore); //출력 Max Score:100*/

            int att = 16755;  //공격략
            int MAxHp = 78103; //최대 체력
            int ci = 36; //치명
            int tl = 1017;//특화
            int ja = 41; // 제압
            int sin = 611; // 신속
            int inn= 22;// 인내
            int sug = 39; //숙련

            Console.WriteLine("공격력 : " + att);
            Console.WriteLine("최대 체력 : " + MAxHp);
            Console.WriteLine("치명 : " + ci);
            Console.WriteLine("특화 : " + tl);
            Console.WriteLine("제압 : " + ja);
            Console.WriteLine("신속 : " + sin);
            Console.WriteLine("인내 : " + inn);
            Console.WriteLine("숙련 : " + sug);
                 

        }
    }
}
