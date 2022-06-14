using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamApp
{
    public class StringHelper
    {
        public static void ReadChar()
        {
            string str = "Some number of characters";
            char[] b = new char[str.Length];
            using (StringReader sr = new StringReader(str))
            {
                sr.Read(b, 0, 13);
                Console.WriteLine(b);

                sr.Read(b, 5, str.Length - 13);
                Console.WriteLine(b);
            }
        }

        public static void WriteChar()
        {
            StringBuilder sb = new StringBuilder("Start with a string and add from ");
            char[] b = { 'c', 'h', 'a', 'r', '.', ' ', 'B', 'u', 't', ' ', 'n', 'o', 't', ' ', 'a', 'l', 'l' };

            using (StringWriter sw = new StringWriter(sb))
            {
                // Write five characters from the array into the StringBuilder.
                sw.Write(b, 0, 5);
                Console.WriteLine(sb);
            }
        }
    }
}
