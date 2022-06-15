using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamApp
{
    public class TextReaderHelper
    {
        public static void TextReader()
        {
            string text = "abc\nabc";
            using(TextReader reader = new StringReader(text))
            {
                while(reader.Peek() != -1)
                {
                    Console.WriteLine($"Peek={(char)reader.Peek()}");
                    Console.WriteLine($"Read={(char)reader.Read()}");
                }

                reader.Close();
            }

            using(TextReader reader = new StringReader(text))
            {
                char[] arr = new char[3];
                reader.Read(arr, 0, 3);
                Console.WriteLine(arr);
                reader.Close();
            }

            using (TextReader reader = new StringReader(text))
            {
                string readLine = reader.ReadLine();
                Console.WriteLine(readLine);
                reader.Close();
            }

            using (TextReader reader = new StringReader(text))
            {
                Console.WriteLine("readall");
                string readAll = reader.ReadToEnd();
                Console.WriteLine(readAll);
                reader.Close();
            }
        }
    }
}
