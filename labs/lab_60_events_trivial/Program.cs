using System;

namespace lab_60_events_trivial
{
    class Program
    {
        // delegate (Restriction on method types)
        public delegate int Delegate01(string x);
        //event
        public static event Delegate01 Event01;
        static void Main(string[] args)
        {
            // 1. Declared event
            // 2. Declared restriction on method types (delegate)
            // 3. Add a method
            Event01 += Method01; // no brackets, so placeholder created but method not called
            Event01 += Method02;
            Event01("hello world special event");
        }
        static int Method01(string input)
        {
            Console.WriteLine("hey are you printing something?");
            Console.WriteLine(input);
            return input.Length;
        }
        static int Method02(string input)
        {
            Console.WriteLine("hey are you 2 printing something?");
            Console.WriteLine(input);
            return input.Length;
        }
    }
}
