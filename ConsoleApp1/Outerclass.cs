using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class OuterClass
    {
        private int a = 70;

        public class InnerClass
        {
            OuterClass instance;

            public InnerClass(OuterClass a_instance)
            {
                instance = a_instance;
            }

            public void AccessVariable(int num)
            {
                this.instance.a = num;
            }

            public void ShowVariable()
            {
                Console.WriteLine("a:{0}", this.instance.a);
            }
        }
        class Program33
        {
            static void Main(string[] args)
            {
                OuterClass outer = new OuterClass();
                OuterClass.InnerClass inner = new OuterClass.InnerClass(outer);

                inner.ShowVariable();
                inner.AccessVariable(60);
                inner.ShowVariable();

            }
        }

       
    }
}
