using System;
using System.Collections.Generic;

namespace lab_12_classes
{
    class Program
    {
        static List<Dog> dogs = new List<Dog>();

        static void Main(string[] args)
        {
            var m01 = new Mammal();
            m01.Height = 100;
            m01.Length = 150;
            m01.Weight = 2000;

            var d01 = new Dog();
            d01.Height = 80;
            d01.Length = 50;
            d01.Weight = 1000;
            d01.DogID = "dog01";
            Console.WriteLine($"Dog has height {d01.Height}, weight {d01.Weight} and length {d01.Length}");
            //var counter = 0;
            for(int i = 1; i<=20; i++)
            {
                //same height, lenght, width but ID is dog + i
                //create dog
                Dog newDog = new Dog();
                newDog.Height = 80;
                newDog.Length = 50;
                newDog.Weight = 1000;
                newDog.DogID = $"dog{i}";
                dogs.Add(newDog);
            }

            foreach(var dog in dogs)
            {
                Console.WriteLine($"Dog has height {dog.Height}, weight {dog.Weight} and length {dog.Length} and ID {dog.DogID}");
            }
        }
    }

    class Dog : Mammal { }

    class Cat : Mammal { }

    class Mammal
    {
        public int Height;
        public int Length;
        public int Weight;
        public string DogID;
    }
}
