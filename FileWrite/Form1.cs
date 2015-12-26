using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //string path = textBoxFilePath.Text;
            //string content = textBoxContent.Text;

            //File.WriteAllText(path,content);
            //MessageBox.Show("操作完成");

            string file = @"D:\2.txt";
            FileStream fs = new FileStream(file,FileMode.OpenOrCreate);
            int nextByte = fs.ReadByte();
            fs.Close();
            MessageBox.Show("操作成功");
        }
    }
}
