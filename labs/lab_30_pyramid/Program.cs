using System;

namespace lab_30_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // pass in an integer
            // a) Output a left justified pyramid
            // b) centre justified pyramid
            /*
             * 
                   *                               *
                   * *                            * *
                   * * *                         * * *
                   * * * *                      * * * *
               
            */
            LeftPyramid(10);
            CentrePyramid(10);

        }



        public static void LeftPyramid(int n)
        {
            for (int i = n; i > 1; i--)
            {
                for(int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }

        public static void CentrePyramid(int n)
        {
            for (int i = n; i > 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("     "+"*");
                }
                Console.WriteLine(" ");
            }
            
        }
    }

}
