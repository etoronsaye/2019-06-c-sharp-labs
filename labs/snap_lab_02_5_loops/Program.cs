using System;
using System.Collections;
using System.Collections.Generic;

namespace snap_lab_02_5_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Snap Lab : 10 minutes
               Input 5 numbers and put into an ArrayList
               Create an Array, List, Queue, Stack, Dictionary.
               Move objects from Arraylist to each item and multiply by 4 each move.
               What's the total?
               Time starts */

            ArrayList numbers = new ArrayList();
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);

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
            foreach(var val in dict.Keys)
            {
                total += dict[val];
            }
            Console.WriteLine(total);
        }
    }
}
