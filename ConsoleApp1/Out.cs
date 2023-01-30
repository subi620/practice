using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Out
    {
        static void Main_e(string[] args)
        {
            int a; // 변수 a, 초기화는 안되있음

            Add(out a); // 매개변수로 변수 a의 주소값을 넘김
            Console.WriteLine("a={0}", a);
        }

        static void Add(out int a) // Add메소드에서, 이 a의 주소값가지고 a에 접근
        {
            a = 100; // a에 100대입

        }

    }
}
