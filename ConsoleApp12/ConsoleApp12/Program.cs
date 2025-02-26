using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        /*//메모리 영역
        //스택 (stack)
        //힙    (heap)
        //정석메모리 (static memory)
        //1단게 함수
        //반환형 함수(매개변수)
        //{
        //}

      static void Loading()
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);

        }

        //2단계]
        //입력
        static void AttackFunction(int Attack)
        {
            Console.WriteLine("공격력은 : " + Attack);
        }

        //3단계
        //출력
        static int BsseAttack()
        {
            //기본공격력
            int attack = 10;

            return attack;

        }

        static int Add(int a, int b)
        {
            return a + b;
        }*/
        static int Add(int a,int b)
        {  
            return a + b;
        }
        static void Main(string[] args)
        {

            /* Loading();

             Console.WriteLine("게임이 시작됩니다.");
             Console.ReadLine();*//*

             int Attack = 0;
             int bAttack = 0;
             Console.WriteLine("캐릭터의 공격력을 입력 : ");
             Attack = int.Parse(Console.ReadLine());
             //기본공격력
             bAttack = BsseAttack();

             AttackFunction(bAttack+Attack);*/

            /*int result = Add(10, 20);
            Console.WriteLine($"10 + 20 {result}");*/

            /* string[] fruits = { "사과", "바나나", "체리" };

             //반복문
             foreach(string fruit in fruits)
             {
                 Console.WriteLine(fruit);
             }*/
            //Console.WriteLine("=================1번째 문제======================");

            /*int[] num = new int[5];
            int[] num1 = {10, 20, 30, 40, 50};
            
            for(int i=0; i<5;i++)        
            {
                num[i] += num1[i];
                Console.WriteLine(num[i]);
            }*/

            /*int[] num = new int[5];
            int max = 0;
            for(int i=0; i < num.Length; i++)
            {
                Console.WriteLine("정수를 입력하세요: ");
                num[i] = int.Parse(Console.ReadLine());
                max += num[i];

                Console.WriteLine("모든 수의 합은:" + max);
            }*/

            /*int[] num = {3, 6 ,9, 12, 15};
            int max = 0;
            for(int i = 0; i < num.Length-1; i++)
            {
                int a = num[i];
                int b = num[i + 1];
                if(a < b)
                {
                    max = b;
                }
            }
            Console.WriteLine("최대값은 " + max);*/

            /* int a = 1;
             for(int i =1;i<=10; i++)
             {

                 Console.WriteLine(i);

             }*/

            /*int a = 1;
            while(a < 11)
            {
                if(a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                a++;*/
            /*int[] numA = { 1, 2, 3, 4, 5 };
            foreach(int i in numA)
            {
                Console.WriteLine(i);
            }*/
            /*int sum = Add(3, 5);

            Console.WriteLine("합은 :" + sum);*/
            /*string str = "HELLO";
            Console.WriteLine("문자열 입력: " + str);
            Console.WriteLine("문자열 길이: " + str.Length);*/

            int num = 0;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("정수를 입력하세요.");
                int num1 = int.Parse(Console.ReadLine());
                if(num < num1)
                {
                    num = num1;
                }
                Console.WriteLine("가장 큰 수:" + num);
            }

        }

    }

}
