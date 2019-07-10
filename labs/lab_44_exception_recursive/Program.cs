using System;
using System.IO;

namespace lab_44_exception_recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crash();
            // null refernce
            string x = null;
            try
            {
                File.ReadAllText("youwontfindme.txt");
                Console.WriteLine(x.Length);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("null reference");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("file not found");
            }
            catch(Exception e)
            {
                Console.WriteLine("general exception");
            }
        }

        static void Crash()
        {
            double answer = 0;
            for (double i = 0; i < 1_000_000_000; i++)
            {
                
                i++;
                answer = i * i;
                Console.WriteLine(answer);
            }  
        }
    }
}
