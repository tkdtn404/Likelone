﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//증감 연산자
            int b = 3;

            //전위 ++b, 후위 b++

            *//*Console.WriteLine("b의 값은 :" + (b++));
            b++;
            Console.WriteLine("b의 값은 :" + (b));*//*

            --b;
            Console.WriteLine("b의 값은 : " + (b--));
            Console.WriteLine("b의 값은 : " + (b));*/

            /*  // 두 값을 비교하여 관계를 평가한다.
              // == 같다 != 같지 않다 a < b  c > d <=  =>
              int x = 5, y = 10;

              Console.WriteLine(x == y);  // false
              Console.WriteLine(x != y);  // true
              Console.WriteLine(x < y);   // true
              Console.WriteLine(x > y);   // false
              Console.WriteLine(x >= y);  // false
              Console.WriteLine(x <= y);  //true  */

            /* // 논리 연산자
             bool a = false;
             bool b = false;

             Console.WriteLine(a && b); 
             // AND :  1 : 1   t
             //        1 : 0   f
             //        0 : 1   f
             //        0 : 0   f
             Console.WriteLine(a || b);
             //OR :   1 : 1   t
             //OR :   1 : 0   t
             //OR :   0 : 1   t
             //OR :   0 : 0   f

            //NOt
            //!a

            b = a;

            Console.WriteLine(b); //false*/

            /* //비트 연산자
             int x = 5; //0101
             int y = 3; //0011

             Console.WriteLine(x & y); // AND : 1 (0001)
             Console.WriteLine(x | y); // OR : 7 (0111)
             Console.WriteLine(x ^ y); // XOR : 6 (0110)
             Console.WriteLine(~x);  // NOT : -6 (1111 1010)*/

            /*//시프트 연산자
            int value = 4; // 0100

            Console.WriteLine(value << 1); // 왼쪽이동 8 (1000)
            Console.WriteLine(value >> 1); // 왼쪽이동 2 (0010)*/

            /* int a = 10, b = 20;

             int max;

             max = (a < b) ? a : b;//삼항 연산자

             Console.WriteLine(max);

             // (비교) ? 참 : 거짓*/

            /* int key = 1;

             string str;
             str = (key == 2) ? "문이 열었습니다" : "문을 못 열었습니다.";

             Console.WriteLine(str);*/

            /*int result = 10 + 2 * 5; //곱샘이 덧셈보다 우선
            Console.WriteLine(result);

            int adjustResult = (10 + 2) * 5; // 괄호 우선순위 먼저계산

            Console.WriteLine(adjustResult);*/

            /* int score = 85;

             if(score >= 90)
             {
                 Console.WriteLine("A 학점");
             }
             else
             {
                 Console.WriteLine("B 학점");
             }*/

            /*string GameID = "멋사검존";

            if (GameID == "멋사검존")
            {
                Console.WriteLine("아이디가 일치합니다.");
            }
            else
            {
                Console.WriteLine("아이디가 일치하지 않습니다.");
            }*/

            /*int score = 75;

            if (score > 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }*/

            //1단계
            //가지고있는 소지금을 입력하세요 :  
            //0~100  무한의대검 +1
            //101~200 카타나 +2
            //201~300 진은검 +3
            //301~400 집판검 +4
            //401~500 엑스칼리버 +5
            //501~600 유령검 +6
            //601 넘어가면 전설의검 + 7


            //2단계 출력
            //캐릭터 멋사검존 
            //무기 : 가지고있는 무기이름표시하기
            //공격력 : 100 +1

            /*  int money = 0;
              int AddAtt = 0;
              string weapon = "";
              Console.WriteLine("가지고 있는 소지금을 입력하세요 : ");

              money = int.Parse(Console.ReadLine());

              //소지금에 따른 무기와 공격력 결정
              if (money >= 0 && money <= 100)
              {
                  weapon = "무한의대검";
                  AddAtt = 1;
              }
              else if (money >= 101 && money <= 200)
              {
                  weapon = "카타나";
                  AddAtt = 2;
              }
              else if (money >= 201 && money <= 300)
              {
                  weapon = "진은검";
                  AddAtt = 3;
              }
              else if (money >= 301 && money <= 400)
              {
                  weapon = "집판검";
                  AddAtt = 4;
              }
              else if (money >= 401 && money <= 500)
              {
                  weapon = "엑스칼리버";
                  AddAtt = 5;
              }
              else if (money >= 501 && money <= 600)
              {
                  weapon = "유령검";
                  AddAtt = 6;
              }
              else
              {
                  weapon = "전설의검";
                  AddAtt = 7;
              }



              //2단계출력
              Console.WriteLine("캐릭터 멋사검존");
              Console.WriteLine("무기 : " + weapon);
              Console.WriteLine("공격력 : 100 +" + AddAtt);*/


            /*//1문제
            int a = 0;
            int b = 0;
            int c = 0;

            Console.WriteLine("정수 a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("정수 b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("정수 c: ");
            c = int.Parse(Console.ReadLine());

            int max = 0;
            if(a >= b)
            {
                max = (a > c) ? a : c;
            }
            else if(a < b)
            {
                max = (b > c) ? b : c;
            }

            Console.WriteLine($"최대값 : {max}");
            Console.WriteLine((""));

            //2문제
            int score = 0;
            Console.WriteLine("점수을 입력하세요.");
            score = Int32.Parse(Console.ReadLine());
         
            if(score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if(score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if(score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else if(score >= 60)
            {
                Console.WriteLine("D 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }

            //3문제
            int d = 0;
            int e = 0;

            Console.WriteLine("숫자를 입력하세요");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("숫자를 입력하세요");
            e = int.Parse(Console.ReadLine());

            Console.WriteLine("사칙연산을 입력하세요.");
            string refult = Console.ReadLine();
            if (refult == "+")
            {
                Console.WriteLine($"결과는 : {d + e}");
            }
            if (refult == "-")
            {
                Console.WriteLine($"결과는 : {d - e}");
            }
            if (refult == "*")
            {
                Console.WriteLine($"결과는 : {d * e}");
            }
            if (refult == "/")
            {
                if (e == 0)
                {
                    Console.WriteLine("0으로 나눌 수 없습니다.");
                }
                Console.WriteLine($"결과는 : {d / e}");
            }*/

        }
    }
}