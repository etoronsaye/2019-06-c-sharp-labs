using System;

namespace lab_13_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var d01 = new Dog();
            d01.Name = "Rover";
            d01.Age = 1;
            d01.Grow();
           // Console.WriteLine("Hello World!");
           for (int i = 1; i <= 20; i++)
            {
                d01.Grow();
            }
            Console.WriteLine($"The Dog is now {d01.Age}");

            for(int i = 1; i <= 17; i++)
            {
                d01.GoBackInTime();
            }
            Console.WriteLine($"The Dog is now {d01.Age}");
        }
    }

    class Dog
    {
        public string Name;
        public int Age;

        public void Grow()
        {
            Age++;
        }
        
        public void GoBackInTime()
        {
            Age--;
        }
    }
}
