using System;
using System.Diagnostics;

namespace lab_27_date_time_stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Times
            var time01 = DateTime.Now;
            Console.WriteLine(time01);
            Console.WriteLine(time01.ToLongTimeString());
            //Console.WriteLine(time01.ToString("yyyymmm");

            // add units of time
            Console.WriteLine(time01.AddDays(2));
            Console.WriteLine(time01.AddSeconds(2));
            Console.WriteLine(time01.AddMilliseconds(2000000));
            Console.WriteLine(time01.AddTicks(200000000000));

            // measure time
            // lets count 1 million and measure the time
            Console.WriteLine("\n\nStarting stopwatch\n\n");
            var s = new Stopwatch();
            s.Start();
            var count = 0;
            for (long i = 0; i < 35_000_000_000; i++)
            {
                count++;
            }
            string sentence = "Food is life, pasta is bae, italy";
            string[] words = sentence.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }
            
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine(s.ElapsedTicks);
        }
    }
}
