using System;

namespace lab_11_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new Object();
            Console.WriteLine(o);
            Console.WriteLine(o.ToString());

            Object o2 = new
            {
                name = "Bob",
                age = 22
            };

            Console.WriteLine(o2.ToString());
        }
    }
}
