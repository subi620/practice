using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Params
    {
        static void Main_f(string[] args)
        {
            Console.WriteLine("sum={0}", total(20, 10, 40, 4, 7, 6, 44, 55, 2));
            Console.WriteLine("sum={0}", total(30, 4, 5));

        }

        static int total(params int[] list) // params 매개변수 사용, int[]=>정수형배열
        {   // list={20, 10, 40, 5, 7, 6, 44, 55, 2}
            int sum = 0;
            for (int i = 0; i < list.Length; i++) //배열list의 길이까지(배열의 값 전부 더하라 는 뜻)
                sum += list[i]; // list[i]는 인덱스값, sum = sum+ list[i] 배열의 덧셈

            return sum;
        }

    }
}
