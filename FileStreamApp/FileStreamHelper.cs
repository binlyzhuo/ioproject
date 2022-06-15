using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamApp
{
    public class FileStreamHelper
    {
        public static void ReadFile()
        {
            string file = "WriteFile2.txt";
            char[] charBuffer2 = new char[3];
            using (FileStream stream = File.OpenRead(file))
            {
                using(StreamReader reader = new StreamReader(stream))
                {
                    DisplayResultStringByUsingRead(reader);
                }
            }

            using (FileStream stream = File.OpenRead(file))
            {
                using (StreamReader reader = new StreamReader(stream,Encoding.UTF8,false))
                {
                    DisplayResultStringByUsingReadBlock(reader);
                }
            }

            using(StreamReader reader = new StreamReader(file,Encoding.UTF8,false,123))
            {
                DisplayResultStringByUsingReadLine(reader);
            }

            using(StreamReader reader = File.OpenText(file))
            {
                DisplayResultStringByUsingReadLine(reader);
            }
        }

        private static void DisplayResultStringByUsingReadLine(StreamReader reader)
        {
            int i = 0;
            string resultString = string.Empty;
            while((resultString = reader.ReadLine())!=null)
            {
                Console.WriteLine("使用StreamReader.Read()方法得到Text文件中第{1}行的数据为 : {0}", resultString, i);
                i++;
            }
        }

        public static void DisplayResultStringByUsingReadBlock(StreamReader reader)
        {
            char[]charBuffer = new char[10];
            string result = String.Empty;
            reader.ReadBlock(charBuffer, 0, 10);
            for(int i=0;i<charBuffer.Length; i++)
            {
                result += charBuffer[i];
            }
            Console.WriteLine("使用StreamReader.ReadBlock()方法得到Text文件中前10个数据为 : {0}", result);
        }

        private static void DisplayResultStringByUsingRead(StreamReader reader)
        {
            int readChar = 0;
            string result = string.Empty;

            while((readChar = reader.Read())!=-1)
            {
                result += (char)readChar;
            }

            Console.WriteLine($"使用StreamReader.Read()方法得到的Text文件中的数据为:\n{result}");
        }
    }
}
