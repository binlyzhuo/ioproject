namespace FileProperties
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxFolders = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFileSize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCreateTime = new System.Windows.Forms.TextBox();
            this.ModifyTime = new System.Windows.Forms.Label();
            this.textBoxModifyTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAccessTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the folder and click the display";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(13, 29);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(315, 21);
            this.textBoxInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Content of folder";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(13, 73);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(315, 21);
            this.textBoxFolder.TabIndex = 4;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(335, 73);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 12;
            this.listBoxFiles.Location = new System.Drawing.Point(13, 116);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(217, 208);
            this.listBoxFiles.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Files";
            // 
            // listBoxFolders
            // 
            this.listBoxFolders.FormattingEnabled = true;
            this.listBoxFolders.ItemHeight = 12;
            this.listBoxFolders.Location = new System.Drawing.Point(256, 116);
            this.listBoxFolders.Name = "listBoxFolders";
            this.listBoxFolders.Size = new System.Drawing.Size(209, 208);
            this.listBoxFolders.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Folders";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Detail of selected file";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "FileName";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(73, 347);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(392, 21);
            this.textBoxFileName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "FileSize";
            // 
            // textBoxFileSize
            // 
            this.textBoxFileSize.Location = new System.Drawing.Point(73, 376);
            this.textBoxFileSize.Name = "textBoxFileSize";
            this.textBoxFileSize.Size = new System.Drawing.Size(157, 21);
            this.textBoxFileSize.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "CreateTime";
            // 
            // textBoxCreateTime
            // 
            this.textBoxCreateTime.Location = new System.Drawing.Point(327, 375);
            this.textBoxCreateTime.Name = "textBoxCreateTime";
            this.textBoxCreateTime.Size = new System.Drawing.Size(138, 21);
            this.textBoxCreateTime.TabIndex = 16;
            // 
            // ModifyTime
            // 
            this.ModifyTime.AutoSize = true;
            this.ModifyTime.Location = new System.Drawing.Point(13, 402);
            this.ModifyTime.Name = "ModifyTime";
            this.ModifyTime.Size = new System.Drawing.Size(95, 12);
            this.ModifyTime.TabIndex = 17;
            this.ModifyTime.Text = "Last ModifyTime";
            // 
            // textBoxModifyTime
            // 
            this.textBoxModifyTime.Location = new System.Drawing.Point(12, 426);
            this.textBoxModifyTime.Name = "textBoxModifyTime";
            this.textBoxModifyTime.Size = new System.Drawing.Size(133, 21);
            this.textBoxModifyTime.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "Last Access Time";
            // 
            // textBoxAccessTime
            // 
            this.textBoxAccessTime.Location = new System.Drawing.Point(256, 427);
            this.textBoxAccessTime.Name = "textBoxAccessTime";
            this.textBoxAccessTime.Size = new System.Drawing.Size(209, 21);
            this.textBoxAccessTime.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 476);
            this.Controls.Add(this.textBoxAccessTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxModifyTime);
            this.Controls.Add(this.ModifyTime);
            this.Controls.Add(this.textBoxCreateTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxFileSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxFolders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FileProperties Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxFolders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFileSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCreateTime;
        private System.Windows.Forms.Label ModifyTime;
        private System.Windows.Forms.TextBox textBoxModifyTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAccessTime;
    }
}

