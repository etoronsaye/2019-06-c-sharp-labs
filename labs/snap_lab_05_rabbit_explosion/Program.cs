using System;
using System.Collections.Generic;

namespace snap_lab_05_rabbit_explosion
{
    class Program
    {
        static List<double> rabbits = new List<double>();
        static void Main(string[] args)
        {
            int limitPopulation = 1_000_000;
            double currentPopulation = 0;
            var i = 0;

            while(currentPopulation < limitPopulation)
            {
                currentPopulation = Math.Pow(2, i);
                //rabbits.Add(Math.Pow(2, i));
                Console.WriteLine($"Time: {i} seconds Rabbits: {currentPopulation}");
                i++;
            }
            Console.WriteLine($"Population is {currentPopulation} after {i} seconds");          
        }
    }

    class Rabbit
    {
        public int size;
        public int population;

        public void Populate()
        {
            
        }
    }
}
