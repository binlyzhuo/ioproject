using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileStreamApp
{
    public class StreamWriterHelper
    {
        public static void WriteLineText()
        {
            string[] lines = { "First line", "Second line", "Third line" };
            string docPath =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using(StreamWriter outputFile = new StreamWriter("writelines.txt"))
            {
                foreach(string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }

            // append
            using (StreamWriter outputFile = new StreamWriter("WriteLines.txt", true))
            {
                outputFile.WriteLine("Fourth Line");
            }
        }
    }
}
