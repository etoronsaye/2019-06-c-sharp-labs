using System;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace lab_62_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();
            // stream to WRITE A FILE
            using (var writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < 10000; i++)
                {
                    writer.WriteLine($"Line {i} - adding some text {DateTime.Now} : elapsed time {s.ElapsedTicks}");
                }
                writer.Close();
            }
            //s.Stop();    
            // see if string builder a bit faster??
            var t = new Stopwatch();
            t.Start();
            var stringbuilder = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                stringbuilder.Append($"Line {i} - adding some text {DateTime.Now} : elapsed time {t.ElapsedTicks} \n");
            }
            using(var writer = new StreamWriter("output2.txt"))
            {
                writer.WriteLine(stringbuilder);
            }
            s.Stop();

            var u = new Stopwatch();
            //var v = new Stopwatch();
            u.Start();
            //v.Start();
            string nextline;
            var stringbuilder2 = new StringBuilder();
            using(var reader = new StreamReader("output.txt"))
            {
                // two operations 1) read next line and assign into string next line 2) check has not returned null
                while ((nextline = reader.ReadLine()) != null)
                {
                    stringbuilder2.AppendLine(nextline);
                }
            }
            Console.WriteLine($"Read file to memory: {u.ElapsedMilliseconds}");
            Console.ReadLine();
            Console.WriteLine(stringbuilder2);
            //Console.WriteLine(u.ElapsedTicks);
            Console.WriteLine($"output file to console: {u.ElapsedMilliseconds}");
            u.Stop();


            // stream reader async - see lab 50

            // last example - streaming to memory used eg in encryption
            // use a pointer which is a reference to an adress inmemory
            // read data from pointer

            using (var memorystream = new MemoryStream())
            {
                var buffer = new byte[100];
                buffer[0] = (int)'h';
                buffer[1] = (int)'e';
                buffer[2] = (int)'l';
                buffer[3] = (int)'l';
                buffer[4] = (int)'o';
                // write data to memory
                memorystream.Write(buffer);
                memorystream.Flush();   // actively push remaining data to memory

                // get meaningful data back?
                // reset pointer to 0
                memorystream.Position = 0;
                var reader = new StreamReader(memorystream);
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
