using System;

namespace lab_23_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Grow : INSTANCE METHOD
            var child = new X();
            child.Grow();
            // Return Data : STATIC METHOD
            X.ReturnFixedData();
            // remeber STATIC MATHS CLASS WHICH RETURNS PI, LOGx ETC
            Console.WriteLine(Math.PI);
            // can put methods here

      
            DoThis();
            DoThis();
            DoThis();

            DoThat();
            DoThat();
            DoThat();

            DoingLots(100, "hi", true);
            DoingLots(c: false, b: "there", a: 10_000_000);
            //var b = 0b1010_0101;
            //var hex = 0xFFDD_21FE;

            void DoThis() { Console.WriteLine("I am doing something"); }

            DoingSomeOtherWork(new DateTime(2019,06,27));  // set date but others defualt
            DoingSomeOtherWork(new DateTime(2019, 06, 27),'a',1.3F,100.222);  // set date but others defualt
        }
        // can put methods here
        static void DoThat() { Console.WriteLine("I am doing something else"); }

        static void DoingLots(int a, string b, bool c)
        {
            Console.WriteLine($"Doing lots {a} {b} {c}");
        }
        static void DoingSomeOtherWork( DateTime date, char c = 'z', float f = 1.2F, double d=100.329)
        {
            Console.WriteLine($"{date}, {c}, {d}, {f}");
            string newday = date.ToShortDateString();
            Console.WriteLine($"{newday}, {c}, {d}, {f}");
            newday = date.ToLongDateString();
            Console.WriteLine($"{newday}, {c}, {d}, {f}");
            newday = date.AddDays(3).ToLongDateString();
            Console.WriteLine($"{newday}, {c}, {d}, {f}");
            string weekday = date.DayOfWeek.ToString();
            Console.WriteLine($"{weekday}, {c}, {d}, {f}");
        }
    }
    class X
    {
        public int Age;
        // can put INSTANCE methods here
        public void Grow()
        {
            Age++;
        }

        //STATIC METHOD: useful for fixed data : STATIC=stock warehouse (WHOLE
        public static string ReturnFixedData()
        {
            return "Here is some fixed data";
        }
    }
}
