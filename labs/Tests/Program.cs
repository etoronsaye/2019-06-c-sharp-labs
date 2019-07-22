using System;
using System.Collections;
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

        public static int Snap_Lab_02(int n1, int n2, int n3, int n4, int n5)
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(n1);
            numbers.Add(n2);
            numbers.Add(n3);
            numbers.Add(n4);
            numbers.Add(n5);

            var arr = new int[5];
            List<int> list = new List<int>();
            var queue = new Queue<int>();
            var stack = new Stack<int>();
            var dict = new Dictionary<int, int>();

            var count = 0;
            int total = 0;
            foreach (int i in numbers)
            {
                arr[count] = i * 4;
                count++;
            }
            foreach (int i in arr)
            {
                list.Add(i * 4);
            }
            foreach (int i in list)
            {
                queue.Enqueue(i * 4);
            }
            foreach (int i in queue)
            {
                stack.Push(i * 4);
            }
            foreach (int i in stack)
            {
                dict.Add(i, i * 4);
            }
            foreach (var val in dict.Keys)
            {
                total += dict[val];
            }
            return total;
        }

        public static double Rabbit_Explosion_B1(int population)
        {
            double currentPopulation = 0;
            var i = 0;

            while (currentPopulation < population)
            {
                currentPopulation = Math.Pow(2, i);
                //rabbits.Add(Math.Pow(2, i));
                //Console.WriteLine($"Time: {i} seconds Rabbits: {currentPopulation}");
                i++;
            }
            //Console.WriteLine($"Population is {currentPopulation} after {i} seconds");
            return currentPopulation;
        }

        public static int SubarraySum(int[] nums, int k)
        {             
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                sum += nums[i];
                if (sum == k)
                {
                    count++;
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == k)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int Loop_Dictionary(int[] arr)
        {
            int counter = 1;
            int[] numArray2 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numArray2[i] = arr[i] + counter;
                counter++; 
            }

            var queue = new Queue<int>();
            foreach (var q in numArray2)
            {
                queue.Enqueue(q + counter);
                counter++;
            }

            var stack = new Stack<int>();
            foreach (var s in queue)
            {
                stack.Push(s + counter);
                counter++;
            }

            var dictionary = new Dictionary<int, int>();
            foreach (var d in stack)
            {
                dictionary.Add(d, d + counter);
                counter++;
            }

            var nums = new List<int>();
            foreach (var n in dictionary.Values)
            {
                nums.Add(n + counter);
                counter++;
            }

            int result = 0;
            foreach (var item in nums)
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


    //if (nums == null || nums.Length == 0)
    //{
    //    return 0;
    //}
}
