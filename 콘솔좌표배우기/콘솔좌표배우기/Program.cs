using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 콘솔좌표배우기
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int gold = 1000;
            int health = 100;
            int att = 10;
            int input;
            bool isAlive = true;
            //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);

            //코놀 버퍼 크기도 설정(스트롤없이 고정된 창 유지)
            Console.SetWindowSize(80, 25);

            Console.CursorVisible = false; //커서 숨기기


            Console.Clear();  //화면지우지
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("┃              검사 키우기                     ┃");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 16);
            Console.WriteLine("┃                                              ┃");
            Console.SetCursorPosition(0, 17);
            Console.WriteLine("┃                                              ┃"); 
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("┃                                              ┃"); 
            Console.SetCursorPosition(0, 19);
            Console.WriteLine("┃                                              ┃"); 
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Thread.Sleep(3000);

            Console.Clear();

            for(int x=0; x<30; x++)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 10);
                Console.Write("◎");
                Thread.Sleep(100);
            }
            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine($"현재 상태 채력 {health} |  공격력 {att} | 돈 {gold}");
                Console.WriteLine("\n1. 모험하기");
                Console.WriteLine(" 무기 뽑기(1000)");
                Console.WriteLine("3. 휴식하기");
                Console.WriteLine("4. 게임종료");
                Console.Write("입력: ");

                input = int.Parse(Console.ReadLine());

                if(input == 1)//모험하기
                {
                    Console.Clear();
                    Console.WriteLine(" 탐험을 떠납니다.");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다..");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다...");
                    Thread.Sleep(500);
                    Console.WriteLine(" 탐험을 떠납니다....");

                    int eventChance = rand.Next(1, 101);

                    if (eventChance <= 30) //30%확률로 전투 발생
                    {
                        int damage = rand.Next(5, 21);
                        Console.WriteLine($"⚔️ 몬스터를 만났습니다! (체력 -{damage}");
                        health -= damage;

                        Console.Write("┏┯┯┯┯┯┓\r\n┃││∧ ∧│┃살려줘!!\r\n┃│  (≧Д≦)  ┃\r\n┃││ф  ф│┃\r\n┗┷┷┷┷┷┛\r\n");
                        Thread.Sleep(1000);


                    }
                    else if (eventChance <= 70)  //40%확률로 보상
                    {
                        int reward = rand.Next(100, 301); //100~300골드
                        Console.WriteLine($"💰 보물을 발견했습니다! (+{reward} 골드)");
                        gold += reward;
                    }
                    else //30$확률로 회복
                    {
                        int heal = rand.Next(10, 31); //10~30 체력 회복
                        Console.WriteLine($"🌿 신비한 물약를 발견했습니다! (+{heal} 체력)");
                        health += heal;
                    }

                    if (health <= 0)
                    {
                        Console.WriteLine("\n 💀체력이 0이 되어 사망했습니다... 게임 오버!");
                        isAlive = false;
                    }

                    Thread.Sleep(1000);
                }
                else if (input == 2) //무기 뽑기
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();
                        Console.WriteLine("🎲 2.무기를 뽑습니다...");
                        Thread.Sleep(1000);

                        int rnd = rand.Next(1, 101); //1~100랜덤

                        if (rnd == 1)
                        {
                            Console.WriteLine("SSS급 전설의 검 (공격력 +50) 획득!");
                            att += 50;
                        }
                        else if (rnd <= 10)
                        {
                            Console.WriteLine("SS급 희귀한 검 (공격력 +30) 획득!");
                            att += 30;
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine("S급 강철 검 (공격력 +20) 획득!");
                            att += 20;
                        }
                        else
                        {
                            Console.WriteLine("녹슨칼 (공격력 +5) 획득!");
                            att += 5;
                        }
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다. (1000 골드 필요) ");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3) //휴식하기
                {
                    Console.WriteLine("휴식을 취합니다...(+20 체력)");
                    health += 20;
                    Thread.Sleep(1000);
                }
                else if (input == 4) //휴식하기
                {
                    Console.WriteLine("게임을 종료합니다.");
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
