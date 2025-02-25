using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//swich문
            int day = 2;

            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                default:
                    Console.WriteLine("주말입니다.");
                    break;*/

            /*int input = 0;
            Console.WriteLine("캐릭터를 선택하세요(1. 검사 2, 마법사 3.도적");
            input = int.Parse(Console.ReadLine());  

            int cha = 3;
            int att = 0;
            int dex = 0;
            switch(cha)
            {
                case 1:
                    att = 100;
                    dex = 90;

                    Console.WriteLine("검사");
                    Console.WriteLine("공격력 :" + att);
                    Console.WriteLine("방어력 :" + dex);

                    break;
                case 2:
                    att = 110;
                    dex = 90;

                    Console.WriteLine("마법사");
                    Console.WriteLine("공격력 :"+att);
                    Console.WriteLine("방어력 :"+dex);

                    break;
                case 3:
                    att = 115;
                    dex = 70;

                    Console.WriteLine("도적");
                    Console.WriteLine("공격력 : "+att);
                    Console.WriteLine("방어력 : "+dex);

                    break;
                default:
                    {
                        Console.WriteLine("캐릭터를 사용할 수 없습니다.");
                        break;
                    }*/

            //반복문(for)
            //초기화   /조건문  /증감식
            /*for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"숫자: {i}");
            }*/

            /*//무한반복
            for (; ; )
            {
                Console.WriteLine("무한반복");
            }*/

            /* for(int i = 0; i <= 9; i++)
             {
                 Console.WriteLine("숫자 : " + i);
             }*/

            /*int sum = 0;

            //1부터 10까지의 합 구하기
            for(int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.WriteLine($"sum : {sum} i : {i}");
            }
            Console.WriteLine("1부터 10까지의 함 : " + sum);*/

            /*  //while(조건문)
              int count = 1; //초기화

              while(count <= 5) //조건식
              {
                  Console.WriteLine("Count : " + count);

                  count++;// 증가, 감소

                  if(count == 3)
                  {
                      Console.WriteLine("3일때 반복문 탈출");
                      break;
                  }
              }
              Console.WriteLine("Count : " + count);*/

            /*// 랜덤
            Random rand = new Random(); //Random 객체를 생성한다

            //0이상 10 미만의 랜덤 정수 생성
            *//*for (int i = 0; i < 10; i++)
            {
                int randomNumder = rand.Next(0, 10); //0~9
                Console.WriteLine("0 이상 10미만의 랜덤 정수 : " + randomNumder);
            }*//*
            for (int i = 0; i < 100; i++)
            {
                int randomNumder = rand.Next(5, 15); //0~9
                Console.WriteLine("5부터 14까지 랜덤 정수 : " + randomNumder);
            }*/

            /*//대장장이 키우기
            Random rand = new Random(); // 랜덤값을 뽑는 문장

            int rnd = 0;

            for(int i = 0; i<20; i++)
            {
                rnd = rand.Next(1, 101); // 1~100


                if(rnd >= 1 && rnd <= 10)
                {
                    Console.WriteLine("도끼등급 sss");
                }
                else if (rnd >= 11 && rnd <= 40)
                {
                    Console.WriteLine("도끼등급 ss");
                }
                else
                {
                    Console.WriteLine("도끼등급 s");
                }
                Thread.Sleep(500); //0.5정도로 뽑아라*/

            /*//do while
            //1회 무조건 실행하고 while문과 같이 조건진행

            int x = 5;

            do
            {
                Console.WriteLine("최소 한번은 실행됩니다.");
                x--;
            } while (x > 0);*/

            /*//breal 문
            //반복문을 탈출할 수 있다.

            for(int i=1; i <= 10; i++)
            {
                if(i == 5) 
                { 
                    
                    break;
                }
                Console.WriteLine(i);
            }*/

            //continue
            //현재 반복을 건너뛰고 다음 반복으로 넘어간다

           /* for(int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0) 
                    continue;

                Console.WriteLine(i); // 홀수만 출력
            }*/

           /* //goto

            int n = 1;

            start:

            if (n <= 5)
            {
                Console.WriteLine(n);
                n++;

                goto start; //레이블로 이동
            }*/
        }
    }
}
