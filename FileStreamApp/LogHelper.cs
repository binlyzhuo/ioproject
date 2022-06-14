using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileStreamApp
{
    public class LogHelper
    {
        public static void Test()
        {
            string logFile = "log.txt";

            using(StreamWriter w = File.AppendText(logFile))
            {
                Log("test1", w);
                Log("test2", w);
            }

            using (StreamReader r = File.OpenText(logFile))
            {
                DumpLog(r);
            }
        }

        public static void Log(string logMessage,TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }

        public static void DumpLog(StreamReader r)
        {
            string line;
            while((line = r.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
