using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    partial class Nested
    {
        public void Test()
        {
            Console.WriteLine("Test()");
        }
    }

    partial class Nested
    {
        public void Test2()
        {
            Console.WriteLine("Test2()");
        }
    }

    partial class Nested
    {
        public void Test3()
        {
            Console.WriteLine("Test3()");
        }
    }

    class Program31
    {
        static void Main_12(string[] args)
        {
            Nested nested = new Nested();
            nested.Test();
            nested.Test2();
            nested.Test3();
        }
    }
}
