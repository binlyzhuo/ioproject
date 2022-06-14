using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamApp
{
    public class StreamReaderHelper
    {
        public static void ReadAllText()
        {
            string file = "WriteFile2.txt";
            try
            {
                using (var sr = new StreamReader(file))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("the file could not be read!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
