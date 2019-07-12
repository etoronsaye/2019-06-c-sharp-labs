using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace lab_50_async
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            // Create a big text file
            // USe 'streamwriter' to write a string as a stream to a file
            /*using(var writer = new StreamWriter("data.dat"))
            {
                writer.WriteLine($"{counter,-5} new line {DateTime.Now}");
                writer.WriteLine($"{counter,-5} new line {DateTime.Now}");
                writer.WriteLine($"{counter,-5} new line {DateTime.Now}");
                for(int i = 0; i < 10_000_000; i++)
                {
                    writer.WriteLine($"{i,-5} new line {DateTime.Now}");
                }
            }*/
            ReadSync();
            ReadDataAsync();
            while (true)
            {
                System.Threading.Thread.Sleep(100);
                Console.WriteLine("main loop working!");
            }
        }

        static void ReadSync()
        {
            var s = new Stopwatch();
            s.Start();
            // using can encapsualte a method whuch is reaching outside of the clean C# runtime
            // Reading a file from Windows/Databse SQL read
            // include a 'close()' method in it 

            // STRING BUILDER can be used to EASILY CONSTRUCT A LONG STRING from
            // lots of little input
            var stringbuilder = new StringBuilder();
            //string longstring = "";
            using (var reader = new StreamReader("data.dat"))
            {
                while (!reader.EndOfStream)
                {
                    stringbuilder.Append(reader.ReadLine());
                    //longstring += reader.ReadLine().ToString();
                }
            }
            s.Stop();
            Console.WriteLine($"Reading 10,000,000 lines took {s.ElapsedMilliseconds}");
            System.Threading.Thread.Sleep(1000);
            //Console.WriteLine(stringbuilder);
        }

        async static void ReadDataAsync()
        {
            var s = new Stopwatch();
            s.Start();
            var stringbuilder = new StringBuilder();
            string line;
            using(var reader = new StreamReader("data.dat"))
            {
                while (!reader.EndOfStream)
                {
                    line = await reader.ReadLineAsync();
                    if(line == null)
                    {
                        break;
                    }
                    stringbuilder.Append(line);
                }
            }
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);
        }
    }
}
