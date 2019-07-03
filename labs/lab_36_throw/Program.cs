using System;

namespace lab_36_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("Something terrible has happened");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }

            try
            {
                // Main code for whole comapny
                try
                {
                    // code for department
                    try
                    {
                        // my code : exception HERE ********
                        throw new ArithmeticException("Hey your arithmetic is lousy");
                    }
                    catch { // dont handle here
                        throw; // up to next level
                    }
                }
                catch (Exception e){ // yes handle here
                    Console.WriteLine(e.Message);
                }
            }
            catch
            {
                // company-wide exceptions
            }
        }
    }
}
