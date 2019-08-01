using System;
using System.Collections.Generic;

namespace snap_lab_18_interfaces
{
    class Program
    {
        static List<Dog> dogs = new List<Dog>();
        static void Main(string[] args)
        {
            // Create 3 dogs and compare heights.
            var d01 = new Dog(300);
            var d02 = new Dog(500);
            var d03 = new Dog(150);
            // Put into a collection or array and sort by height.
            dogs.Add(d01);
            dogs.Add(d02);
            dogs.Add(d03);
            
            Dog[] dogArrray = dogs.ToArray();
            Dog temp;
            Console.WriteLine("=== Sorted Dogs - Array (bubble sort)");
            /*foreach(var dog in dogs)
            {
                if (d01.CompareTo(d02) == 1)
                {
                    temp = d02.Height;
                }
            }*/
            
            for (int d = 0; d <= dogArrray.Length - 2; d++)
            {
                for (int i = 0; i <= dogArrray.Length - 2; i++)
                {
                    if (dogArrray[i].CompareTo(dogArrray[i + 1]) == -1)
                    {
                        temp = dogArrray[i + 1];
                        dogArrray[i + 1] = dogArrray[i];
                        dogArrray[i] = temp;
                    }
                }
            }
            foreach(var dog in dogArrray)
            {
                Console.WriteLine(dog.Height);
            }

            dogs.Sort();
            Console.WriteLine("=== Sorted Dogs - .Sort Version ===");
            foreach(var dog in dogs)
            {
                Console.WriteLine(dog.Height);
            }
            // Use custom CompareTo by implementing IComparable
            Console.WriteLine("=== Dog Comparisons ===");
            Console.WriteLine(d01.CompareTo(d02));
            Console.WriteLine(d01.CompareTo(d03));
            Console.WriteLine(d02.CompareTo(d03));


        }
    }

    class Dog : IComparable
    {
        public int Height { get; set; }
        public int CompareTo(Object o)
        {
            Dog d = (Dog)o;
            if (this.Height > d.Height) return 1;
            if (this.Height < d.Height) return -1;
            return 0;
        }
        // constructor
        public Dog(int height)
        {
            this.Height = height;
        }
    }
}
