using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class My
    {
        static void Main_f(string[] args)
        {
            // 넘어가는 매개변수의 타입이나 수에 따라서 실행되는 생성자가 다르다.
            MyClass objA = new MyClass();
            MyClass objB = new MyClass(10);
            MyClass objC = new MyClass(25.5);

        }
    }

    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("매개변수가 없는 디폴트 생성자가 호출됨");
        }

        public MyClass(int num)
        {
            Console.WriteLine("정수형 매개변수 num을 받는 생성자가 호출됨");
        }

        public MyClass(double num)
        {
            Console.WriteLine("실수형 매개변수 num을 받는 생성자가 호출됨");
        }
    }
}
