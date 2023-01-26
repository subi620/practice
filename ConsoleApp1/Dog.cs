using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Dog
    {
        public string name; // 개의 이름을 나타내는 필드
        public string gender; // 개의 성별을 나타내는 필드
        public string ownername; // 개의 주인 이름을 나타내는 필드

        public void Bark() // 짓는 행동
        {
            Console.WriteLine("{0}: 멍멍", name);
        }
    }

    class Program
    {
        static void Main_c(string[] args)
        {
            Dog dog = new Dog(); // Dog클래스를 기반으로 dog 객체 생성, Dog()는 생성자
            dog.name = "칸"; // 필드 값 초기화
            dog.gender = "남";
            dog.ownername = "철수";
            dog.Bark();

            Console.WriteLine("개의 이름: {0}, 개의 성별: {1}, 개의 주인 이름: {2}"
                , dog.name, dog.gender, dog.ownername);
        }
    }
}
