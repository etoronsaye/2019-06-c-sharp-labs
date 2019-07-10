using System;
using System.Collections;

namespace lab_41_casting
{
    class Program
    {
        static void Main(string[] args)
        {

            // Implicit cast
            // useful when its impossible for data to be lost eg int 1 to double 1.0
            int num01 = 100;
            double d01 = num01;

            // Explicit cast
            // require when data will definitely will be lost eg double 2.314 to int 2 : 0.314
            double d02 = 2.314;
            int num02 = (int)d02;
            Console.WriteLine($"{d02} has become {num02}");

            // Is
            var p = new Parent();
            var c = new Child();
            if (c is Parent)
            {
                Console.WriteLine("Your child is a member of the parent family");
            }
                    // Don't really use this as exception if fail

            if (!(c is AnotherParent))
            {
                Console.WriteLine("C is not related to another parent");
            }

            // cast from one type to another
            var p02 = new Parent();
            var c02 = new Child();

            // As
            var parentOfChild = c02 as Parent;    // safer as it returns null if it fails 
            var parentofChild2 = (Parent)c02;

            // this will not work
            // var AnotherParent = c02 as AnotherParent;









            // Boxing and Unboxing
            var o = new Object(); //root of all objects
            int i = 10;
            // may have structure dealing with multiple objects
            // have to 'cast' from a type to general object 
            int num03 = 100;
            var o3 = num03;   // 'box' integer as an 'object'
            // When finished, cast back to a number
            int num04 = (int)o3;  // get back our integer

            // Arraylist : list of objects of no fixed type
            var mixedlist = new ArrayList();
            mixedlist.Add(10);
            mixedlist.Add("hello");
            mixedlist.Add(DateTime.Now);
            mixedlist.Add(12.4);
            foreach(var item in mixedlist)
            {
                Console.WriteLine($"{item} is a {item.GetType()}");
            }

        }
    }

    class Parent { }

    class Child : Parent { }

    class AnotherParent { }
}
