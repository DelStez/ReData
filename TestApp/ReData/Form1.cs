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


        private void SetNewCreationData(DateTime dateTime, string path)
        {
            dateTimePicker2.Value = dateTime;
            File.SetCreationTime(path, dateTime);
            MessageBox.Show("Date was changed!");
        }

        private void ShowOldTime(string file)
        {
            var ty = File.Exists(file);
            FileSystemInfo fileSystemInfo = new FileInfo(file);
            fileSystemInfo.Refresh(); 
            var creationTime = fileSystemInfo.CreationTime.Date;
            dateTimePicker2.Value = creationTime;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                textBox1.Text = path;
                ShowOldTime(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime newDate = dateTimePicker1.Value;
            SetNewCreationData(newDate, path);
        }
    }
}