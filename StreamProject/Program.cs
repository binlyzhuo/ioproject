using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreamProject
{
    class Program
    {
        //http://www.cnblogs.com/JimmyZheng/archive/2012/03/17/2402814.html
        static void Main(string[] args)
        {

            byte[] buffer = null;

            string testString = "Stream!Hello world";
            int strLen = testString.Length;
            Console.WriteLine("string lenth:{0}",strLen);
            char[] readCharArray = null;
            byte[] readBuffer = null;
            string readString = string.Empty;

            using (MemoryStream stream = new MemoryStream())
            {
                Console.WriteLine("初始字符串:{0}",testString);
                if(stream.CanWrite)
                {
                    Console.WriteLine("stream can write");
                    buffer = Encoding.Default.GetBytes(testString);
                    int bufferCount = Encoding.Default.GetByteCount(testString);

                    //写入
                    stream.Write(buffer,0,3);

                    //

                    Console.WriteLine("现在Stream.Postion在第{0}位置",stream.Position+1);

                    long newPostionInStream = stream.CanSeek ? stream.Seek(3,SeekOrigin.Current):0;

                    Console.WriteLine("重新定位后Stream.Postion在第{0}位置",newPostionInStream+1);

                    if(newPostionInStream<buffer.Length)
                    {
                        stream.Write(buffer,(int)newPostionInStream,buffer.Length-(int)newPostionInStream);
                    }

                    stream.Position = 0;
                    readBuffer = new byte[stream.Length];

                    int count = stream.CanRead ? stream.Read(readBuffer,0,readBuffer.Length):0;

                    int charCount = Encoding.Default.GetCharCount(readBuffer,0,count);

                    readCharArray = new char[charCount];

                    Encoding.Default.GetDecoder().GetChars(readBuffer,0,count,readCharArray,0);
                    for(int i=0;i<readCharArray.Length;i++)
                    {
                        readString += readCharArray[i];
                    }
                    Console.WriteLine("读取的字符串为:{0}",readString);
                }

                stream.Close();
            }

            Console.WriteLine("IO PRoject");
            Console.ReadLine();
        }
    }
}
