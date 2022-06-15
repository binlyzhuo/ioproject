using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamApp
{
    public class FileStreamTest
    {
        public void Create()
        {
            char[] insertContent = "HelloWorld".ToCharArray();
            byte[] byteArrayContent = Encoding.UTF8.GetBytes(insertContent,0,insertContent.Length);

            
            using(FileStream stream = new FileStream("fscreate.txt", FileMode.Create))
            {
                stream.Write(byteArrayContent,0,byteArrayContent.Length);
                stream.Close();
            }
        }

        public void Copy()
        {

        }
    }
}
