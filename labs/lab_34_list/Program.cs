using System;
using System.Collections.Generic;
using System.Collections;

namespace lab_34_list
{
    class Program
    {
        static List<int> list01 = new List<int>();
        static List<string> list02 = new List<string>();
        static void Main(string[] args)
        {
            // arrays are fixed
            var array01 = new int[10];   // size fixed
            // 2d array
            var Grid2D = new int[10, 10];
            var Cube3D = new int[5, 5, 5];
            var Grid4d = new int[10, 10, 10, 10];
            // the above arrays are all fixed in size 100%
            // it's possible to create an array of arrays where each array can be a different size
            // Jagged Array
            int[][] JaggedArray01 = new int[3][];
            // first arrary size 10
            JaggedArray01[0] = new int[10];
            // second array size 100
            JaggedArray01[0] = new int[100];
            JaggedArray01[0] = new int[1000];

            // int[][] JaggedArray02 = new int[3][];
            // Console.WriteLine(JaggedArray02[0][1]);

            // private scope inside method
            List<short> shortList = new List<short>();

            list01.Add(10); // index 0
            list01.Add(20); // index 1
            list01.Insert(0, 100);  // index 0, push others along
            foreach(var item in list01)
            {
                Console.WriteLine($"{item}");
            }

            list01.RemoveAt(0);
            Console.WriteLine("\n\nRemove index 0 \n\n");
            foreach (var item in list01)
            {
                Console.WriteLine($"{item}");
            }

            // list of strings x3
            // insert new item at index 1 and view result
            list02.Add("Fee");
            list02.Add("Fo");
            list02.Add("Fum");
            list02.Insert(1, "Fi");
            foreach (var item in list02)
            {
                Console.WriteLine($"{item}");
            }

            // FOREACH BLOCK : USE QUITE OFTEN

            Console.WriteLine("\n\nDictionar\n\n");
            var dictionary01 = new Dictionary<int, string>();
            var dictionary02 = new Dictionary<int, int>();
            var dictionary03 = new Dictionary<string, int>();
            dictionary01.Add(10, "hi");
            dictionary01.Add(20, "there");
            dictionary01.Add(30, "spartans");
            dictionary01.Add(40, "spartans2");
            dictionary01.TryAdd(40, "some value");

            // ITERATE => loop over dictionary
            foreach (var key in dictionary01.Keys)
            {
                Console.WriteLine($"Key: {key, -20} Value: {dictionary01[key]}");
            }

            // QUEUE
            var queue = new Queue<int>();
            queue.Enqueue(10);  // add first iten
            queue.Enqueue(20);  // second
            queue.Enqueue(30);  // third

            //......................................30.............20........10......BUS STOP

            var itemWhichJustGotOnBus = queue.Dequeue();    // first item gets on bus

            //......................................30.............20........BUS STOP

            Console.WriteLine($"item which just got on the bus is {itemWhichJustGotOnBus}");
            Console.WriteLine($"Queue contains number 50? {queue.Contains(50)}");
            Console.WriteLine($"Queue contains number 20? {queue.Contains(20)}");
            Console.WriteLine($"Check out who is next/first in line: {queue.Peek()}");

            // iterate => print foreach loop 
            foreach(var per in queue)
            {
                Console.WriteLine(per);
            }

            // STACK
            Console.WriteLine("\n\nStack\n");
            var stack = new Stack<string>();
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");
            stack.Push("fourth");   // LIFO : last to arrive 

            foreach (var item in stack) { Console.WriteLine(item); }
            Console.WriteLine($"Contains \"second\"? {stack.Contains("second")}");//contains
            Console.WriteLine($"Peek: {stack.Peek()}");//peek
            Console.WriteLine("\n\n Remove one item 'pop' off top");
            stack.Pop();
            foreach (var item in stack) { Console.WriteLine(item); }
            Console.WriteLine($"Peek: {stack.Peek()}");//peek

            // snap code till lunch
            // take numbers as an array 10 20 30 40
            int[] arr = new int[] { 10, 20, 30, 40 };
            // create list, multiply by 10
            var list03 = new List<int>();
            foreach (var item in arr)
            {
                list03.Add(item*10);
            }
            // create que, add 1
            var queue01 = new Queue<int>();
            foreach(var q in list03)
            {
                queue01.Enqueue(q + 1);
            }
            // create stack, add 2
            var stack01 = new Stack<int>();
            foreach(var s in queue01)
            {
                stack01.Push(s + 2);
            }
            // whats the sum
            int result = 0;
            foreach(var item in stack01)
            {
                result += item;
            }
            Console.WriteLine(result);
            // dont do a test just code


            Console.WriteLine("\n\nArrayList\n\n");
            var objectList = new ArrayList();
            objectList.Add(10);
            objectList.AddRange(new int[] { 10, 20, 30, 40 });
            objectList.Add("hi there");
            objectList.Add(true);
            objectList.Add(DateTime.Now);

            foreach(var item in objectList)
            {
                Console.WriteLine($"{item.GetType(),-20}{item}");
            }


        }
         
        void DoThis()
        {
            list01.Add(10);
            list02.Add("hi");
            // shortList => invisible
        }
    }
}
