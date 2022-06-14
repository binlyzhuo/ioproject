using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileStreamApp
{
    public class FileHelper
    {
        public static void WriteBinary()
        {
            string fileName = "Test.data";
            if(File.Exists(fileName))
            {
                Console.WriteLine($"{fileName} exist~");
                return;
            }

            using (FileStream fs = new FileStream(fileName,FileMode.CreateNew))
            {
                using(BinaryWriter w = new BinaryWriter(fs))
                {
                    for(int i=0; i<11; i++)
                    {
                        w.Write(i);
                    }
                }
            }
        }

        public static void ReadBinary()
        {
            string fileName = "Test.data";

            using(FileStream fs = new FileStream(fileName,FileMode.Open,FileAccess.Read))
            {
                using(BinaryReader r = new BinaryReader(fs))
                {
                    for(int i=0;i<11;i++)
                    {
                        Console.WriteLine(r.ReadInt32());
                    }
                }
            }
        }

        public static void WriteAppendText()
        {
            string file = "WriteFile2.txt";
            string text = "First line" + Environment.NewLine;
            File.WriteAllText(file, text);
            string[] lines = { "New line 1", "New line 2" };
            File.AppendAllLines(file, lines);
        }
    }
}
