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
using System.Runtime.CompilerServices;

namespace ReData
{
    public partial class Form1 : Form
    {
        private string path = string.Empty;
        //public static string 
        public Form1()
        {
            InitializeComponent();
        }

        private void SetNewValuesInmMetaData(string path)
        {
            string logMessage = string.Empty;
            DateTime newDate;
            int valMode = -1;
            if (oldValCreate.Value.CompareTo(newValCreate.Value) != 0)
            {
                newDate = newValCreate.Value;
                oldValCreate.Value = newDate;
                File.SetCreationTime(path, newDate);
                logMessage +="Date of create  was changed!\n";
            }
            if (oldValChange.Value.CompareTo(newValChange.Value) != 0)
            {
                newDate = newValChange.Value;
                oldValChange.Value = newDate;
                File.SetLastWriteTime(path, newDate);
                logMessage += "Date of change  was changed!\n";
            }
            if (oldValOpen.Value.CompareTo(newValOpen.Value) != 0)
            {
                newDate = newValOpen.Value;
                oldValOpen.Value = newDate;
                File.SetLastAccessTime(path, newDate);
                logMessage += "Date of open  was changed!\n";
            }
            //change attributes
            

        }

        private void ShowOldValues(string file)
        {
            var ty = File.Exists(file);
            FileSystemInfo fileSystemInfo = new FileInfo(file);
            fileSystemInfo.Refresh(); 
            //show time of last CCA (CreateChangeAccess)
            var time = fileSystemInfo.CreationTime.Date;
            oldValCreate.Value = time;
            newValCreate.Value = time;
            time = fileSystemInfo.LastWriteTime.Date;
            oldValChange.Value = time;
            newValChange.Value = time;
            time = fileSystemInfo.LastAccessTime.Date;
            oldValOpen.Value = time;
            newValOpen.Value = time;
            // show attributes
            FileAttributes attributes = File.GetAttributes(path);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                textBox1.Text = path;
                ShowOldValues(path);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetNewValuesInmMetaData(path);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}