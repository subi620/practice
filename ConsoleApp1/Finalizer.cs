using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Finalizer
    {
        static void Main(String[] args)
        {
            MyyClass objA = new MyyClass("A");
            MyyClass objB = new MyyClass("B");
            MyyClass objC = new MyyClass("C");
        }
    }

    class MyyClass
    {
        //MyyClass 내에 두개의 객체 생성한다. 
        private string name;
        public MyyClass(string name)
        {
            Console.WriteLine(name + "객체 생성!");
            this.name = name;
        }

        ~MyyClass()
        {
            Console.WriteLine(name + "객체 소멸!");
        }
    }
}
