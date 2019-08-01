using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_59_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                Debug.WriteLine($"Debugging to OUTPUT WINDOW: i is {i}");
                Trace.WriteLine($"Trace to OUTPUT WINDOW in final release mode and debug mode): i is {i}");
                File.AppendAllText("output.txt",$"Logging to text file {DateTime.Now} i has value {i}");
                var output = $"Logging to text file {DateTime.Now} i has value {i}";

                if (!Directory.Exists("C:\\Log"))
                {
                    Directory.CreateDirectory("C:\\Log");
                }
                // log to C:\Log folder
                File.AppendAllText("C:\\Log\\" + "output.txt", output + Environment.NewLine);
                // log to My Documents\Log folder
                    //File.AppendAllText("C:\\Users\\eoronsaye\\Documents\\Log\\" + "output.txt", output + Environment.NewLine);
                // ANY USER?? Special folders
                    // File.AppendAllText(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Log\\output.txt", output + Environment.NewLine);
                // @ LITERAL STRING NOTATION AS WELLL
                    File.AppendAllText(@"C:\\Users\eoronsaye\Documents\Log\" + "output.txt", output + Environment.NewLine);
                // can also log to Windows Application Event Log
                EventLog.WriteEntry("Application", "output", EventLogEntryType.Information, 5678, 123);
            }
            EventLog.WriteEntry("Application", "Your system has been hacked", EventLogEntryType.Information, 5678, 123);
            for(int j = 0; j < 10; j++)
            {
                Console.WriteLine($"J has value{j}");
            }
            Console.ReadLine();
            // 1 ==> Debug which is F5
            // 2 ==> not debug mode which is Control F5 => still shows all output
            // 3 ==> not debug PLUS Build => Configuration => Release then only shows TRACE OUTPUT
            // TODO SOMEWORK HERE
            // ToDo Some Work Here
            // Debugging
            /*
             * Control F5 = No BReakpoint
             * F5 ==> Breakpoint
             * F10 ==> next line 
             * F11 ==> next line but it calls Method, go deeper
             */
        }
    }
}
