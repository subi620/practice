using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        public void Main(string[] args)
        {
            int[] reading = new int[6] { 4, 9, 1, 0, 21, 12 }; // int형 배열 선언, 6개의 공간 차지, 각 숫자로 초기화됨

            for (int i = 0; i < reading.Length; i++) // reading의 길이만큼 반복하여 코드 실행
                Console.WriteLine("reading[" + i + "]={0}", reading[i]); //0부터 5행까지 출력


        }
    }
}
