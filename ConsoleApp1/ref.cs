using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class @ref
    {
        static void Main(string[] args)
        {
            int a = 40;
            int b = 10;

            Console.WriteLine("Swap before: a={0}, b={1}", a, b);

            Swap(ref a, ref b);

            Console.WriteLine("Swap after:a={0}, b={1}", a, b); // Swap 후  

        }

        static void Swap(ref int a, ref int b) // 매개변수 ref를 써서 참조형식으로 사용.
        {
            int temp = b; // temp변수 선언, 후에 b로 초기화 
            b = a; // b에 a값을 담는다. 
            a = temp; // a에 temp값을 담는다. 
            // Swap함수는 a와 b값을 바꿔 버리는 기능
        }


    }
}
