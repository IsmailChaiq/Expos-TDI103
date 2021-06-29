using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Tracing;
using Shell32;
 

namespace Filesystemwatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fileSystemWatcher1.EnableRaisingEvents = true;
        }
        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            MessageBox.Show(string.Format("File_changed {0} {1}", e.FullPath, e.Name));
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(string.Format("File_created {0} {1}", e.FullPath, e.Name));
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
                Shell Shl = new Shell(); Folder Recycler = Shl.NameSpace(10);
                for (int i = 0; i < Recycler.Items().Count; i++) 
                { 
                    FolderItem FI = Recycler.Items().Item(i);
                    string FileName = Recycler.GetDetailsOf(FI, 0);
                    if (Path.GetExtension(FileName) == "") FileName += Path.GetExtension(FI.Path);
                    string FilePath = Recycler.GetDetailsOf(FI, 1); Console.WriteLine(FilePath); 
                }
                string src = @"C:\$Recycle.Bin\donnee.txt";
                string dest = @"C:\Users\erraf\OneDrive\Bureau\Filesystemwatcher\Filesystemwatcher\Filesystemwatcher\bin\Debug\file2.txt";
                
                try
                {
                    File.Copy(src, dest, true);
                }
                catch (IOException d)
                {
                    MessageBox.Show(d.Message);
                }
                MessageBox.Show(string.Format("File_deleted {0} {1}", e.FullPath, e.Name));
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            MessageBox.Show(string.Format("File_renamed {0} {1}", e.FullPath, e.Name));
        }

        
    }
}
