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
            catch (IOException ex)
            {
                Console.WriteLine("the file could not be read!");
                Console.WriteLine(ex.Message);
            }
        }

        public static void ByteRead()
        {
            byte[] buffer = null;
            string testString = "Stream!Hello world";
            char[] readCharArray = null;
            byte[] readBuffer = null;
            string readString = string.Empty;

            using (MemoryStream stream = new MemoryStream())
            {
                Console.WriteLine($"初始字符串:{testString}");
                if (stream.CanWrite)
                {
                    buffer = Encoding.UTF8.GetBytes(testString);
                    stream.Write(buffer, 0, 3);
                    Console.WriteLine($"现在Stream.Position在第{stream.Position + 1}位置");
                    long newPositionInStream = stream.CanSeek ? stream.Seek(3, SeekOrigin.Current) : 0;
                    Console.WriteLine($"重新定位后Stream.Position在第{stream.Position + 1}位置");

                    if (newPositionInStream < buffer.Length)
                    {
                        stream.Write(buffer, (int)newPositionInStream, buffer.Length - (int)newPositionInStream);
                    }

                    stream.Position = 0;

                    readBuffer = new byte[stream.Length];

                    int count = stream.CanRead?stream.Read(readBuffer, 0, readBuffer.Length) : 0;
                    int charCount = Encoding.UTF8.GetCharCount(readBuffer,0,count);
                    readCharArray = new char[charCount];
                    Encoding.UTF8.GetDecoder().GetChars(readBuffer, 0, count, readCharArray,0);

                    for(int i=0;i<readCharArray.Length;i++)
                    {
                        readString += readCharArray[i];
                    }

                    Console.WriteLine($"读取的字符串:{readString}");
                }

                stream.Close();
            }
        }
    }
}
