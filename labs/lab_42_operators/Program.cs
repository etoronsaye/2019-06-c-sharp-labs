using System;
using System.Linq;   // TALK TO DATABASES

namespace lab_42_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // x++
            int x01 = 10;
            int y01 = x01++;    // y = 10       x = 11
                    // y=x     then increment x

            // ++x
            int x02 = 10;
            int y02 = ++x02;  // adds one    y=11       x=11
                              // increment x then y=x
                              // safe rule is only to use x++; on one line with nothing else
            Console.WriteLine(y01);
            Console.WriteLine(x01);
            Console.WriteLine(y02);
            Console.WriteLine(x02);

            Console.WriteLine(!true);   //false
            //...
            //x++;
            //...

            // Binary
                //modulus
            Console.WriteLine(100 % 8);   // 4  (remainder) 8x12=96 r 4
                // whole number division
            Console.WriteLine(100/8);   // 12

            // && AND : high if and only if BOTH INPUTS HIGH
            Console.WriteLine(1 & 1);   // 1
            Console.WriteLine(1 & 0);   // 0
            Console.WriteLine(0 & 1);   // 0
            Console.WriteLine(0 & 0);   // 0

            // | OR : output is high if one input is high
            Console.WriteLine(1 | 1);   // 1
            Console.WriteLine(1 | 0);   // 1
            Console.WriteLine(0 | 1);   // 1
            Console.WriteLine(0 | 0);   // 0

            // ^ XOR : output is high if exactly one input is high
            Console.WriteLine(1 ^ 1);   // 0
            Console.WriteLine(1 ^ 0);   // 1
            Console.WriteLine(0 ^ 1);   // 1
            Console.WriteLine(0 ^ 0);   // 0

            // && and || save time if right hand side takes time to evaluate
            // short-circuit operator : can NEVER BE TRUE SO DON'T BOTHER EVALUATION RHS
            Console.WriteLine(false && DoThisLongOperation());

            // BIT SHIFT (helps you to understand computers)
            // 1010 IN BINARY = 10 IN DECIMAL
            // 1101 IN BINARY = 13 IN DECIMAL
            // 1010 to 10100  =  10 TO 20
            // 10100 to 101000 = 20 TO 40
            // 1010 to 101 : 10 IN DECIMAL to 5
            // 101 to 10 = 5 TO 2 (DANGEROUS TRUNCATION)

            Console.WriteLine(8>>2); // move 2 places smaller 8..4..2
            Console.WriteLine(8<<2); // move 2 places bigger 8..16..32

            // Ternary Operator => : ?
            // var output = (condition) ? "if true" : "if false"
            int num04 = 100;
            int num05 = 1000;
            if (num04 > num05)
            {
                //do this
            }
            else
            {
                //do that
            }

            var output = (num04 > num05) ? "high" : "low";
            Console.WriteLine(output);

            // can be confusing so use only if super confident

            // LAMBDA OPERATOR
            int[] myArray = { 1, 2, 3, 4, 5 , 6 };
            // CREATE clone array but only vlaues of a condition 
            var outputArray01 = myArray.Where(item => item > 2);
            foreach(var item in outputArray01)
            {
                Console.WriteLine(item);
            }
            int?[] myArray2 = { null, 2, 3, null, 5, 6, null };
            
        }  

        // abcdefghijklmnopqrstubwxyz
        // abcdefhjikl;mnopqrstuvwxtz

        static bool DoThisLongOperation()
        {
            for(int i = 0; i < 1_000_000_000; i++)
            {
                Console.WriteLine(i);
            }
            return false;
        }

        
    }      
}          
