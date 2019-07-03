using System;

namespace lab_18_method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rabbit();
            r.Age = 0;
            for (int i = 0; i < 10; i++)
            {
                r.Grow();
                Console.WriteLine(r.Age); //1
            }
            Console.WriteLine("\n\nHey its summer now, growth rate has increased\n\n");
            for (int i = 0; i < 10; i++)
            {
                r.Grow(2);
                Console.WriteLine(r.Age); //1
            }
            Console.WriteLine("\n\nHey its winter now, growth rate has decreased\n\n");
            for (int i = 0; i < 10; i++)
            {
                r.Grow(0.1);
                Console.WriteLine(r.Age); //1
            }

            Console.WriteLine("\n\nSubrabbit taking over\n\n");
            var s = new SubRabbit();
            //s.Age = 0;
            for (int i = 0; i < 10; i++)
            {
                r.Grow(5);
                Console.WriteLine(r.Age); //1
            }
            s.HereIsACustonField = "Hey I'm changing the subRabbit";
        }

        sealed class Rabbit
        {
            public double Age { get; set; }
            public void Grow()
            {
                Age++;
            }
            public void Grow(int growthFactor)
            {
                Age += growthFactor;
            }
            public void Grow(double winterGrowth)
            {
                Convert.ToDecimal(winterGrowth);
                Age += winterGrowth;
            }
        }

        class SubRabbit
        {
            public string HereIsACustonField;
        }
    }
}
