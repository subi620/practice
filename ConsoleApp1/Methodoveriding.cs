using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Methodoveriding
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", Add(50, 10));
            Console.WriteLine("{0}", Add(544.2, 63.2));
            Console.WriteLine("{0}", Add(4, 7, 9));

        } // 아래에서 함수를 정의 후, main에서 가져다 쓴다(정수 넣어줌)
        static int Add(int a, int b) // 매개변수 선언
        {
            Console.WriteLine("두 int형 끼리의 덧셈");
            return a + b; // *a + b 덧셈으로 반환 계산

        }
        static double Add(double a, double b) // 실수 자료형double 선언 
        {
            Console.WriteLine("두 double형 끼리의 덧셈");
            return a + b;
        }
        static int Add(int a, int b, int c) // 세 개의 변수 선언
        {
            Console.WriteLine("세 int형 끼리의 덧셈");
            return a + b + c;  // a + b + c 덧셈 반환 계산
        }

    }
}
