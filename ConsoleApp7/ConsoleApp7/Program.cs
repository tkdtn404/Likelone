using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//이진수를 정수로 변환
           Console.Write("2진수를 입력하세요:");
           string binaryInput = Console.ReadLine();  //입력받는다 문자열
           int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수 -> 10진수 변환

           //정수를 이진수로 변환
           string binaryOutput = Convert.ToString(decimalValue, 2);//10진수 ->2진수

           Console.WriteLine($"입력한 이진수: {binaryInput}");
           Console.WriteLine($"10진수로변환 : {decimalValue}");
           Console.WriteLine($"다시 이진수로 변환 :{binaryOutput}");*/

            /*//var를 사용하여 변수 선언
            var name = "Alice"; //문자열로 추론
            var age = 25;    //정수로 추론
            var isStudent = true; //노리갑스로 추론

            Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");*/

            /*//default 키워드 사용한 기본값 설정
            int defaultInt = default; // 기본값 0
            string defaultString = default; //기본값 : null
            bool defaultBool = default; //기본값 : false

            Console.WriteLine($"정수 기본값: {defaultInt}"); // 출력: 0
            Console.WriteLine($"문자열 기본값: {defaultString}"); // 출력: (null)
            Console.WriteLine($"논리값 기본값: {defaultBool}"); // 출력: False*/

            /*int a = 5, b = 3;

            int sum = 0;

            sum = a + b; //사눌 연잔사 사용
            Console.WriteLine($"합 : {sum}"); //출력: 8

            sum = a - b; //사눌 연잔사 사용
            Console.WriteLine($"합 : {sum}"); 

            sum = a * b; //사눌 연잔사 사용
            Console.WriteLine($"합 : {sum}"); 

            sum = a / b; //사눌 연잔사 사용
            Console.WriteLine($"합 : {sum}");

            int c = 0, d= 0;

            c = 10;
            d = 3;
            sum = c % d;//니머지 구하는 연산자
            Console.WriteLine($"합 : {sum}");*/

            /*bool isEqual = false;//거짓 0
            int a = 5;
            int b = 5;

            //관계형 연산자
            isEqual = (a == b);

            Console.WriteLine("같은가? " + isEqual);*/

            /*//단항 연산자
            int naumber = 5;

            Console.WriteLine(+naumber); //양수 출력 : 5
            Console.WriteLine(-naumber); // 음수 출력 : -5

            bool flag = true;
            Console.WriteLine(!flag); //논리 부정 : false*/

            //~비트 반전
            //10 1010
            //   0101

            /*  int num = 10;
              int result = ~num;  //모든 비트 반전 1111 0101 결과

              Console.WriteLine("원래값 :" + num);
              Console.WriteLine("~ 연잔자 적용 후 : " + result);*/

            /*//캐스팅
            double pi = 3.14;
            int integerPi = (int)pi; //실수형 -> 정수형로 변환

            Console.WriteLine(integerPi); //3*/

            /*int iKor = 90;
            int iEng = 75;
            int iMath = 58;

            int sum = 0;
            float average = 0.0f;

            sum = iKor + iEng + iMath;

            average = (float)sum / 3;  //평균

            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + average);*/

            /*int a = 10, b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);*/

            /*//문자열 연결 연삱자
            string firstName = "Alice";
            string lastName = "Smith";

            Console.WriteLine(firstName + " " + lastName); // 출력*/

            /*//할당 연산자
            int a = 10;

            a += 5;// a =  a + 5
            Console.WriteLine(a); 
            a -= 5;// a = a - 5
            Console.WriteLine(a); 
            a *= 5;// a = a * 5
            Console.WriteLine(a); 
            a /= 5;// a = a / 5
            Console.WriteLine(a); 
            a %= 5;// a = a % 5
            Console.WriteLine(a); */

           /* int kor;
            int eng;
            int math;
            int sum;
            float average;
           

            Console.WriteLine("국어 점수를 입력하세요");
            kor = Int32.Parse(Console.ReadLine());

            Console.WriteLine("영어 점수를 입력하세요");
            eng = Int32.Parse(Console.ReadLine());

            Console.WriteLine("수학 점수를 입력하세요");
            math = Int32.Parse(Console.ReadLine());

            sum = kor + eng + math;           
            Console.WriteLine("총점 : " + sum);
            average = (float)sum / 3;
            Console.WriteLine("평균 : " + average.ToString("F2"));

            int a;
            Console.WriteLine("정수를 입력하세요");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("입력받은 정수 비트 반전 결과: " + ~a);*/
            

        }
    }
}
