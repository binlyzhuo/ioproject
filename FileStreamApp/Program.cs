using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Specialized;

namespace FileStreamApp
{
    class Program
    {
        //http://www.cnblogs.com/liuxinls/archive/2013/02/15/2912968.html
        //http://www.wxzzz.com/1687.html
        //http://www.wxzzz.com/683.html
        //http://www.wxzzz.com/1607.html
        //http://www.cnblogs.com/Mr_JinRui/archive/2010/07/05/1771184.html
        static void Main(string[] args)
        {
            //Console.WriteLine("Just a test for the stream!!");
            //string filePath = @"d:\2.txt";
            //FileStream fs = new FileStream(filePath,FileMode.OpenOrCreate);
            //int nextByte = fs.ReadByte();
            //Console.WriteLine("Next Byte:"+nextByte);
            //byte[] reader = new byte[8];
            //fs.Close();

            ////StringCollection result;
            //var ds = DriveInfo.GetDrives();
            //foreach(var di in ds)
            //{
            //    Console.WriteLine(di.Name);
            //}

            // read file
            /*
            FileStream file = File.Open(@"e:\stream\1.txt",FileMode.Open);
            byte[] array = new byte[file.Length];
            file.Read(array, 0, array.Length);

            file.Close();

            string str = Encoding.Default.GetString(array);
            Console.WriteLine(str);

            // write file
            FileStream writeFile = new FileStream(@"e:\stream\2.txt",FileMode.Append);
            byte[] arrTxt = Encoding.UTF8.GetBytes("Hello World!你好");
            writeFile.Write(arrTxt, 0, arrTxt.Length);

            // 清空缓冲区
            writeFile.Flush();
            writeFile.Close();
            */
            //

            //FileHelper.WriteBinary();
            //FileHelper.ReadBinary();
            //FileHelper.WriteAppendText();
            //LogHelper.Test();
            //StreamWriterHelper.WriteLineText();
            //StreamWriterHelper.WriteLineAsync();

            //StreamReaderHelper.ReadAllText();

            //StringHelper.ReadChar();
            //StringHelper.WriteChar();

            //StreamReaderHelper.ByteRead();
            //TextReaderHelper.TextReader();
            //FileStreamHelper.ReadFile();

            //FormatProviderHelper.Test();

            StreamWriterTest streamWriterTest = new StreamWriterTest(Encoding.UTF8,"StreamWriter.txt");
            streamWriterTest.WriteSomethingToFile();
            Console.WriteLine("complete~");
            Console.ReadLine();
        }
    }
}
