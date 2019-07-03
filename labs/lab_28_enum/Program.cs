using System;

namespace lab_28_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fruit.banana);
            Console.WriteLine(Fruit.apple);
            Console.WriteLine(Fruit.pear);

            Console.WriteLine((int)Fruit.apple);
            Console.WriteLine((int)Fruit.notfruit);
            Console.WriteLine($"Number of fruit is {(int)Fruit.count}");

            // Use with days of week and months of year
            // Sunday is 0, ... Saturday is 6
            // January is 1, ... Dec is 12
            var d = DateTime.Now;
            Console.WriteLine(d);
            Console.WriteLine(d.Month);  // 7
            Console.WriteLine(d.Day);    // 1    of month ie July 

            Console.WriteLine( (int) d.DayOfWeek);  // 1           0
            Console.WriteLine(d.DayOfWeek);         // monday    sunday
        }
    }

    enum Fruit
    {
        notfruit=-1, banana, apple, pear, count
    }
}
