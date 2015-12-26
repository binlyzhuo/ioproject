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
        static void Main(string[] args)
        {
            Console.WriteLine("Just a test for the stream!!");
            string filePath = @"d:\2.txt";
            FileStream fs = new FileStream(filePath,FileMode.OpenOrCreate);
            int nextByte = fs.ReadByte();
            Console.WriteLine("Next Byte:"+nextByte);
            byte[] reader = new byte[8];
            fs.Close();

            //StringCollection result;
            var ds = DriveInfo.GetDrives();
            foreach(var di in ds)
            {
                Console.WriteLine(di.Name);
            }
            Console.ReadLine();
        }
    }
}
