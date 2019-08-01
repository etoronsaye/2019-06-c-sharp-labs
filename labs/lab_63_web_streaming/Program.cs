using System;
using System.Net;
using System.Diagnostics;

namespace lab_63_web_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            // read a web page
            Uri bbcNews01 = new Uri("https://www.bbc.co.uk/sport");
            // URI Uniform resource IDENTIFIER  - more general pointer
            // URL Uniform resource LOCATOR     - more specific

            Console.WriteLine(bbcNews01.Host);
            Console.WriteLine(bbcNews01.Port);
            Console.WriteLine(bbcNews01.AbsolutePath);

            var s = new Stopwatch();
            s.Start();
            GetWebPageSync();
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);

            var t = new Stopwatch();
            t.Start();
            GetWebPageAsync();
            t.Stop();
            Console.WriteLine(t.ElapsedMilliseconds);
        }
        static void GetWebPageSync()
        {
            // download this file
            var downloadWebPage01 = new WebClient { Proxy = null };
            var albarahi = new Uri("http://www.albahari.com/nutshell/code.aspx");
            downloadWebPage01.DownloadFile(albarahi, "albahari.html");
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "albahari.html");
        }
        async static void GetWebPageAsync()
        {
            // download this file
            var downloadWebPage01 = new WebClient { Proxy = null };
            var albarahi = new Uri("http://www.albahari.com/nutshell/code.aspx");
            await downloadWebPage01.DownloadFileTaskAsync(albarahi, "albahari.html");
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "albahari.html");
        }

        // NOTE : WEBCLIENT
        // NOTE : HTTPWEBREQUESTS/RESPONSE GIVE MORE DETAIL/ PREFERRED TO USE
    }
}
