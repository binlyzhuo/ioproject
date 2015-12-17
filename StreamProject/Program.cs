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
            char[] readCharArray = null;
            byte[] readBuffer = null;
            string readString = string.Empty;

            using (MemoryStream stream = new MemoryStream())
            {

            }

            Console.WriteLine("IO PRoject");
            Console.ReadLine();
        }
    }
}
