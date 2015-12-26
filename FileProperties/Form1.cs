using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FileProperties
{
    public partial class Form1 : Form
    {
        private string currentFolderPath;
        public Form1()
        {
            InitializeComponent();

            //this.listBoxFiles.Select += listBoxFiles_Selected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = textBoxInput.Text;
                DirectoryInfo theFolder = new DirectoryInfo(folderPath);
                if(theFolder.Exists)
                {
                    DisplayFolderList(theFolder.FullName);
                    return;
                }
                FileInfo theFile = new FileInfo(folderPath);
                if(theFile.Exists)
                {
                    DisplayFolderList(theFile.Directory.FullName);
                    int index = listBoxFiles.Items.IndexOf(theFile.Name);
                    listBoxFiles.SetSelected(index,true);
                    return;

                }

                throw new FileNotFoundException("there is not file or folder with:"+textBoxInput.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearAllFiles()
        {
            listBoxFolders.Items.Clear();
            listBoxFiles.Items.Clear();
            textBoxFolder.Text = "";
            textBoxFileName.Text = "";
            textBoxCreateTime.Text = "";
            textBoxAccessTime.Text = "";
            textBoxModifyTime.Text = "";
            textBoxFileSize.Text = "";
        }

        protected void DisplayFileInfo(string fileFullName)
        {
            FileInfo theFile = new FileInfo(fileFullName);
            if(!theFile.Exists)
            {
                throw new FileNotFoundException("File not found:"+fileFullName);
            }

            textBoxFileName.Text = theFile.Name;
            textBoxCreateTime.Text = theFile.CreationTime.ToLongTimeString();
            textBoxAccessTime.Text = theFile.LastAccessTime.ToLongTimeString();
            textBoxModifyTime.Text = theFile.LastWriteTime.ToLongTimeString();
            textBoxFileSize.Text = theFile.Length.ToString() + "bytes";
        }

        protected void DisplayFolderList(string folderFullName)
        {
            DirectoryInfo theFolder = new DirectoryInfo(folderFullName);
            if(!theFolder.Exists)
            {
                throw new DirectoryNotFoundException("Folder not found:"+folderFullName);
            }

            ClearAllFiles();
            textBoxFolder.Text = theFolder.FullName;
            currentFolderPath = theFolder.FullName;

            foreach(DirectoryInfo nextFolder in theFolder.GetDirectories())
            {
                listBoxFolders.Items.Add(nextFolder.Name);
            }

            foreach(FileInfo nextFile in theFolder.GetFiles())
            {
                listBoxFiles.Items.Add(nextFile.Name);
            }
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxFiles_Selected(object sender, EventArgs e)
        {
            try
            {
                string selectedString = listBoxFolders.SelectedItem.ToString();
                string fullPathName = Path.Combine(currentFolderPath, selectedString);
                DisplayFileInfo(fullPathName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
