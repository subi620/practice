using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main_y(string[] args)
        {
            // Person은 아래 클래스로부터 참조
            Person person = new Person
            {
                Name = "홍길동",
                Age = 20,
                Address = new Address
                {
                    Street = "서울시 서초구 서초동",
                    City = "서울",
                    State = "서울특별시"
                }
            };

            Console.WriteLine(person.Name); // 홍길동
            Console.WriteLine(person.Age); // 20
            Console.WriteLine(person.Address.City); // 서울
            Console.WriteLine(person.Address.State); // 서울특별시
        }
    }

    class Person
    {
        public string Name;
        public int Age;
        public Address Address;
    }

    class Address
    {
        public string Street;
        public string City;
        public string State;
    }
}
