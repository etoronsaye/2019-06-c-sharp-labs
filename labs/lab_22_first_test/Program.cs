using System;

namespace lab_22_first_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class LabWork
    {
        public int CubeNumbers(int x, int y, int z)
        {
            return (x*y*z);
        }
        public static int CubeNumbersStatic(int x, int y, int z)
        {
            return (x * y * z);
        }

        public static int GetLengthOfArray(int [] myArray)
        {
            return myArray.Length;
        }

        public static int SumTotalOfArrayTest(int[] array)
        {
            int sumOfArray = 0;
            foreach(int x in array)
            {
                sumOfArray += x;
            }
            return sumOfArray;
        }
    }
}
