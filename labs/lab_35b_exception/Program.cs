using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace lab_35b_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // potentially dodgy code
                var data01 = File.ReadAllText("thisfiledoesnotexist.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception was thrown and caught here");
                Console.WriteLine("Details are: ");
                // Console.WriteLine(e);
                // Console.WriteLine(e.Data);
                // Console.WriteLine(e.Message);
                Console.WriteLine("You are an amazing user and you are using this program beautifully");
                Console.WriteLine("We couldn't find that file you were looking for though");

                var d = DateTime.Now;
                // log exception
                File.AppendAllText("logoutput.txt", $"Exception at {d} - file not found");

                EventLog.WriteEntry("Application", "Theresa is in Windows", EventLogEntryType.Information,5001,2468);

            }
            finally { }
        }
    }
}
