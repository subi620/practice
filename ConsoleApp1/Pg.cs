using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Pg
    {
        static void Main_z(string[] args)
        {
            Car car = new Car(325, "BMW");
        }
    }

    class Car
    {
        private int maxSpeed;
        private int speed;
        private string model;

        // Car 객체가 만들어지면 자동으로 이 생성자가 호출된다.
        public Car(int maxSpeed, string model)
        {
            this.speed = 0;
            this.maxSpeed = maxSpeed;
            this.model = model;
        }

        public void ShowCarInformation()
        {
            Console.WriteLine(model + "의 현재 속도: " + speed + "km/h, 최대 속도: " +
                maxSpeed + "km/h");
        }
        public void IncreaseSpeed(int increment)
        
        {
            if (speed + increment > maxSpeed)
                Console.WriteLine("최대 속도" + maxSpeed + "km/h를 넘길 수 없습니다.");
            else
            {
                speed += increment;
                Console.WriteLine(model + "의 현재 속도는 " + speed + "km/h 입니다.");
            }
        }

        public void DecreaseSpeed(int decrement)
        {
            if (speed - decrement < 0)
                Console.WriteLine("속도는 0 아래로 떨어질 수 없습니다.");
            else
            {
                speed -= decrement;
                Console.WriteLine(model + "의 현재 속도는 " + speed + "km/h 입니다");
            }
        }
    }
}
