using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamApp
{
    public class StreamWriterTest
    {
        private Encoding _encoding;
        private IFormatProvider _provider;
        private string _textFilePath;

        public StreamWriterTest(Encoding encoding, string textFilePath, IFormatProvider provider)
        {
            _encoding = encoding;
            _provider = provider;
            _textFilePath = textFilePath;
        }

        public StreamWriterTest(Encoding encoding, string textFilePath) : this(encoding, textFilePath, null)
        {

        }

        public void WriteSomethingToFile()
        {
            using (FileStream fs = File.OpenWrite(_textFilePath))
            {
                using (StreamWriter writer = new StreamWriter(fs, this._encoding))
                {
                    this.WriteSomthingToFile(writer);
                }
            }


            using(StreamWriter writer = new StreamWriter(_textFilePath,true,this._encoding,20))
            {
                this.WriteSomthingToFile(writer);
            }

        }

        public void WriteSomthingToFile(StreamWriter writer)
        {
            string[] writeMethodOverloadType =
                                               {
                                                  "1.Write(bool);",
                                                  "2.Write(char);",
                                                  "3.Write(Char[])",
                                                  "4.Write(Decimal)",
                                                  "5.Write(Double)",
                                                  "6.Write(Int32)",
                                                  "7.Write(Int64)",
                                                  "8.Write(Object)",
                                                  "9.Write(Char[])",
                                                  "10.Write(Single)",
                                                  "11.Write(Char[])",
                                                  "12.Write(String)",
                                                  "13Write(UInt32)",
                                                  "14.Write(string format,obj)",
                                                  "15.Write(Char[])"
                                               };

            writer.AutoFlush = true;
            writer.WriteLine($"这个StreamWriter使用了{writer.Encoding.HeaderName}编码");
            writeMethodOverloadType.ToList().ForEach(name => writer.WriteLine(name));
            writer.Close();
        }
    }
}
