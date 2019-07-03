using System;
using Tests;

namespace lab_32_3_cats_in_order_of_age
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 10 minutes

               Application

               Array of Cats ie Cat[] cats = new Cat[3];

               Instantiate 3 Cats and manually create names and ages 

               Add to Array

               Foreach

               Get Ages 

               Create a new array with cats sorted in order of age
               
             */

            Cats cat01 = new Cats("bob", 2);
            Cats cat02 = new Cats("charlie", 3);
            Cats cat03 = new Cats("david", 4);
            Cats[] cats = new Cats[3];
            cats[0] = cat01;
            cats[1] = cat02;
            cats[2] = cat03;

            int catAge = 0;

            foreach (var cat in cats)
            {
                catAge = cat.Age;
            }

            int[] catAgeArray = new int[3];
            catAgeArray[0] = cat01.Age;
            catAgeArray[1] = cat02.Age;
            catAgeArray[2] = cat03.Age;

            foreach(var age in cats)
            {

            }

        }
    }
}
