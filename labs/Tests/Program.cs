using System;
using System.Collections.Generic;

namespace Tests
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // Eng35Tests.Create_Array_From_Sentence("This is a test");
            // Eng35Tests.Calculate_Words_In_Sentence("This is another test");
            // Eng35Tests.Turns_First_Word_To_Uppercase();
            // Eng35Tests.Turns_All_Words_To_Uppercase_But_Last_Word_To_Lowercase();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Eng35Tests.Mega_Multiple_Coding_Loops(array);

            /* for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
            }*/
        }

    }
    public class Eng35Tests
    {
        // Pass in a sentence and return an array of individual words
        public static string[] Create_Array_From_Sentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            return words;
        }

        // Pass in a sentence and return the number words
        public static int Calculate_Words_In_Sentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            Console.WriteLine(words.Length);
            return words.Length;
        }

        // Turns first word to uppercase
        public static string Turns_First_Word_To_Uppercase(string sentence)
        {
            string[] words = sentence.Split(' ');
            foreach (var word in words)
            {

            }
            // "" returns "THIS is a sentence"
            return "";
        }

        public static string Turns_All_Words_To_Uppercase_But_Last_Word_To_Lowercase(string sentence)
        {
            // "" returns "THIS IS A sentence"
            return "";
        }

        static List<Cat> cats = new List<Cat>();

        public static int Mega_Multiple_Coding_Loops(int[] myArray)
        {
            int c = 0;
            // While loop ==> add one to each number  [11,12,16
            while (c < myArray.Length) {
                myArray[c]++;
                Console.WriteLine(myArray[c]);
                c++;
            }
            Console.ReadLine();
            // Do..While loop ==> add 3 to each number[14, 15, 19..
            int count = 0;
            do
            {
                myArray[count] += 3;
                Console.WriteLine(myArray[count]);
                count++;
            } while (count < myArray.Length);
            Console.ReadLine();
            // Foreach loop ==> double each number[28, 30, 38...
            int counter = 0;
            int totalAge = 0;
            foreach (int a in myArray)
            {
                //myArray[counter] = 2 * a;
                myArray[counter] *= 2;
                Console.WriteLine(myArray[counter]);
                var ca = new Cat(a);
                counter++;
                cats.Add(ca);
                foreach (var cat in cats)
                {
                    totalAge += cat.Age;
                    //cat.Age++;
                }
            }
            foreach (var cat in cats)
            {
                Console.WriteLine($"{cat.Name,-20}{cat.Age,-20}");
                //cat.Age++;
            }
            // Console.ReadLine();

            Console.ReadLine();
            return totalAge;
        }

        public static int SumOfArray(int[] array)
        {
            int sumOfArray = 0;
            foreach (int x in array)
            {
                sumOfArray += x;
            }
            return sumOfArray;
        }

        public static double Multiply(double x, double y, double n)
        {
            double ans = x * y;
            return Math.Pow(ans,n);
        }

        public static int[] ThreeArray(int[] array)
        {
            Array.Sort(array);
            return array;
        }

        public static int How_Many_Numbers_Divisible_By(int start, int end, int divisor)
        {
            // how many integers are divisiible by given divisor in the given range
            // example (2,10,4) means start at 2 and count up to 10
            // only 4 and 8 are divisible by 4
            // so answer is 2

            int result = 0;
            for(int i = start; i <= end; i++)
            {
                if(i % divisor == 0)
                {
                    result++;
                }
            }
            return result;
        }

        public static int Array_Loop_Queue_Stack(int[] array)
        {
            var list03 = new List<int>();
            foreach (var item in array)
            {
                list03.Add(item * 10);
            }
            // create que, add 1
            var queue01 = new Queue<int>();
            foreach (var q in list03)
            {
                queue01.Enqueue(q + 1);
            }
            // create stack, add 2
            var stack01 = new Stack<int>();
            foreach (var s in queue01)
            {
                stack01.Push(s + 2);
            }
            // whats the sum
            int result = 0;
            foreach (var item in stack01)
            {
                result += item;
            }
            return result;
        }
    }
    // Create a Cat class with string Name and int Age.Have a Constructor.
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(int counter)
        {
            this.Age = counter;
            this.Name = "Cat" + counter;
        }
    }

    public class Cats
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cats(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    
    

}
