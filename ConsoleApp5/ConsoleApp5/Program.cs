using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//숫자 데이터 형식: 정수와 실수를 다룰 떄 사용하는 다양한 타입
            int integerNum = 10;     //정수 데이터
            float flaotNum = 3.14f;  //단정밀도 실수
            double doubleNum = 3.14159;  //배정밀도 실수

            Console.WriteLine(integerNum); 
            Console.WriteLine(flaotNum); 
            Console.WriteLine(doubleNum);*/

            /*  //정수 데이터형식: 소수점이 없는 숫자를 표현
              int intValue = 100; //4바이트 크기의 정수
              long longValue = 1234567890L; //8바이트 크기의 정수

              Console.WriteLine(intValue); //출력: -100
              Console.WriteLine(longValue);//출력 : 1234567890*/

            //1비트 00000000        8  1바이트

            /* //부호 있는 정수: 음수와 양수를 모두 표현 가능
             sbyte signedBye = -50; //1바이트 크기
             short signeshort = -32000;// 2바이트 크기
             int signeint = -20000000;  // 4바이트 크기

             Console.WriteLine(signedBye);
             Console.WriteLine(signeshort);
             Console.WriteLine(signeint);*/
            /*
                        //부호 없는 정수 데이터 형식
                        byte unsignedBye = 255;        //1바이트 크기
                        ushort unsignedShort = 65000;  //2바이트 크기
                        uint unsignedIn = 4000000000;  //4바이트 크기

                        Console.WriteLine(unsignedBye);
                        Console.WriteLine(unsignedShort);
                        Console.WriteLine(unsignedIn);*/

            /*//실수 데이터 형식 : 소수점이 있는 숙자를 표현
            float singlaPrecisiong = 3.14f;     //단정밀도 실수
            double doubleprecission = 3.1415926535; //배정밀도 실수 (8바이트)
            decimal highPreecion = 3.14456213134561215m; //고정밀도 (16바이트)

            Console.WriteLine(singlaPrecisiong);
            Console.WriteLine(doubleprecission);
            Console.WriteLine(highPreecion);*/

            /*  //char형식 단일 문자를 표현
              char letter = 'A'; //문자 'A'를 저장
              char symbol = '#'; //특수 가호 저장
              char number = '9'; //숫자 형태의 문자 저장

              Console.WriteLine(letter);
              Console.WriteLine(symbol);
              Console.WriteLine(number);*//*

            //string 형식; 여러 문자를 저장
            string greeting = "Heello world"; //문자열 저장
            string name =  "Alice"; // 이름 저장 ; Alice

            *//* Console.WriteLine(greeting);
             Console.WriteLine(name);*//*

            //Hello world Aiice

            Console.WriteLine(greeting +" "+ name);*/

            /*//bool 형식 : 참(true) = 1  거짓 (false) = 0
            bool isrunning = true;   //프로그램 실행 상태
            bool isFinisher = false; //프로그램 종료 상태

            Console.WriteLine(isrunning);
            Console.WriteLine(isFinisher);*/

            /*// 닷넷 형식 : 기본ㄴ 형식의 닷넷표현
            Int32 number = 123; //in닷넷형식
            String text = "Hello"; //string의 닷넷 형식
            Boolean flag = true;//bool의 닷넷 형식

            Console.WriteLine(number);
            Console.WriteLine(text);
            Console.WriteLine(flag);*/

            /*//int 래퍼 형식의 매서드 활용
            int numder = 123;

            string numberAsString = numder.ToString(); //정수를 문자열로 변환

            //bool 래퍼형식
            bool flag = true;

            string flagAsSting = flag.ToString(); //논리랎을 문자열로 변환

            Console.WriteLine(flagAsSting);
            Console.WriteLine(numberAsString);*/





        }

    }
}
