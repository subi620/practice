using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Parent
    {
        public int num; 
        public Parent()
        {
            Console.WriteLine("부모 클래스의 생성자가 호출되었습니다.");
        }
    }
    class Child : Parent
    {
        public Child(int num) // 매개변수 num

        {    // parent의 num과 child의 num
            // 매개 변수 하나를 받고, 부모 클래스의 num으로 초기화
            base.num = num;
            Console.WriteLine("자식 클래스의 생성자가 호출되었습니다.");
        }
        public void DisplayValue()
        {
            Console.WriteLine("num의 값은 {0} 입니다.", num);
        }
    }
    class Family
    {
        static void Main(string[] args)
        {
            Child cd = new Child(20);

            cd.DisplayValue();
        }
    }
}
