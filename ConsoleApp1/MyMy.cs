using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MyMy
    {
        static void Main_ddd(string[] args)
        {
            MyClasss mc = new MyClasss();
            Console.WriteLine("mc.Name: {0}", mc.Name);

            mc.Name = "Kelley";
            Console.WriteLine("mc.Name:{0}", mc.Name);
        }
    }

    public class MyClasss
    {
        private string name = "John"; // private 제한

        public string Name
        {
            get
            {
                return name; // 반환값
            }
            set
            {
                if(value.Length < 5) // value의 길이가 5보다 작아야 새 값 할당
                    name = value; 
            }
        }
    }
}
