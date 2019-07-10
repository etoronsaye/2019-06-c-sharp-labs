using System;

namespace lab_40_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for - over fixed number of iterations

            // foreach - over an array/collection

            // while - over a condition before a loop, may never entereg loop while records exist to be read from a database

            // dowhile - over a condition checked after loop, always enters at least once

            // break - useful when looking for one item only and loop until item is found

            string[] items = new string[] { "first", "second", "third" };
            foreach(var item in items)
            {
                if(item == "second")
                {
                    break; // EXIT FOREACH STRUCTURE COMPLETELY
                }
                Console.WriteLine("items before break point - " + item); // first only
            }

            // continue - 

            foreach (var item in items)
            {
                if (item == "second")
                {
                    continue; // FINISH LOOP AND START ON NEXT LOOP
                }
                Console.WriteLine("itemsnot including continue " + item); // first and third
            }

            // throw - 
            // CREATE loop but manually throw exception and exit loop if certain condition is reached

            // return -
            // use return to save lots of if.. else conditions and nesting 
            var output = DoThis(10);

            int DoThis(int inputnumber)
            {
                if(inputnumber == 5)
                {
                    // do this
                    return -100;
                }

                if (inputnumber == 10)
                {
                    // do this
                    return  -150;
                }

                return -1000;   
            }
            Console.WriteLine(output);
        }
    }
}
