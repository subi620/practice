using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Dp
    {
        static void Main(string[] args)
        {
            Parentt parentt = new Parentt();
            parentt.A();

            Childd childd = new Childd();
            childd.A();

            Daughter daughter = new Daughter();
            daughter.A();
        }
    }

    class Parentt
    {
        public virtual void A()
        {
            Console.WriteLine("부모 클래스의 A() 메서드 호출!");
        }
    }

    class Childd : Parentt
    {
        public override void A()
        {
            Console.WriteLine("자식 클래스(Child)의 A() 메서드 호출!");
        }
    }

    class Daughter : Parentt
    {
        public override void A()
        {
            Console.WriteLine("자식 클래스(Daughter)의 A() 메서드 호출!");
        }
    }

    
}
