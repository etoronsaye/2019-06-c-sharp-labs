using System;
using System.Collections.Generic;

namespace lab_16_rabbits
{
    class Program
    {
        static List<Rabbit> rabbits = new List<Rabbit>();

        static void Main(string[] args)
        {
            Console.WriteLine("\n\nPrinting Rabbits One By One\n\n");
            for (int i = 1; i <= 10; i++)
            {
                //create and add rabbit
                Rabbit newRabbit = new Rabbit(i);
                rabbits.Add(newRabbit);
                System.Threading.Thread.Sleep(200);
                //Console.WriteLine($"At loop {i} Name {newRabbit.Name, -20} Age {newRabbit.Age}");
                Console.WriteLine($"Loop {i}");
                foreach (var rabbit in rabbits)
                {
                    rabbit.Age++;
                    Console.WriteLine($"{rabbit.Name} is now {rabbit.Age}");
                }
            }
            Console.WriteLine("\n\nPrinting All Rabbits\n\n");
            foreach (var rabbit in rabbits)
            {
                Console.WriteLine($"Name {rabbit.Name,-20} Age {rabbit.Age}");
            }
        }
    }
    }
    class Rabbit
    {
        public int Age{get;set;}
        public string Name{get;set;}

        public Rabbit(int counter)
        {
            this.Age = 0;
            this.Name = "Rabbit" + counter;
        }
    }

