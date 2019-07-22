using System;
using System.Collections.Generic;

namespace snap_lab_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create counter and everytime one is 'moved' we incremeent the counter.
            // Move 10 integers 1. to array 2. to queue 3. to stack 4. to dictionary 5. to list
            // Every move we  a) increment counter b) add value of counter to number wwe are moving
            // REturn sum of finall list

            int counter = 1;
            int[] numArray = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] numArray2 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numArray2[i] = numArray[i] + counter;
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
            foreach(var d in stack)
            {
                dictionary.Add(d, d + counter);
                counter++;
            }

            var nums = new List<int>();
            foreach (var n in dictionary.Values)
            {
                nums.Add(n+counter);
                counter++;
            }

            int result = 0;
            foreach (var item in nums)
            {
                result += item;
            }
            Console.WriteLine(result);


        }
    }
}
