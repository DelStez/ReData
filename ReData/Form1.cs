using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace ReData
{
    public partial class Form1 : Form
    {
        private string _pathOfFile = string.Empty;
        public string key = String.Empty;
        internal bool _closed = false;
        //public static string 
        public Form1()
        {
            InitializeComponent();
            EnterCode entered = new EnterCode();
            entered.Owner = this;
            entered.ShowDialog();
            if (!_closed)
            {
                if (key != "")
                {
                    byte[] str = Encoding.UTF8.GetBytes(key);
                    if (shellSecurity.ShellSecurityCipher(str) == false)
                    {
                        //trash
                        int key = 0;
                        byte[] subkey = new byte[8];
                        for (int k = 0; k < subkey.Length; k++)
                        {
                            if ( key==0 && subkey.Length > k++)
                            {
                                key++;
                            }
                            else
                            {
                                OpenConfig(subkey);
                                break;
                            }
                        }
                        _closed = true;
                    }
                }
                else
                {
                    _closed = true;
                }
            }
        }

        private int OpenConfig(byte[] subkey)
        {
            if (subkey.Length > 0)
            {
                return -1;
            }

            return 256;
        }

        private void SetNewValuesInmMetaData(string path)
        {
            DateTime newDate;
            if (oldValCreate.Value.CompareTo(newValCreate.Value) != 0)
            {
                newDate = newValCreate.Value;
                oldValCreate.Value = newDate;
                File.SetCreationTime(path, newDate);
            }
            if (oldValChange.Value.CompareTo(newValChange.Value) != 0)
            {
                newDate = newValChange.Value;
                oldValChange.Value = newDate;
                File.SetLastWriteTime(path, newDate);
            }
            if (oldValOpen.Value.CompareTo(newValOpen.Value) != 0)
            {
                newDate = newValOpen.Value;
                oldValOpen.Value = newDate;
                File.SetLastAccessTime(path, newDate);
            }
            /*
            change attributes
                                        ^     ^
            attention: spaghetti code (= U w U =)
            */
            FileAttributes attributes = File.GetAttributes(path);
            if (checkBox1.Checked)
            {
                if ((attributes & FileAttributes.ReadOnly) != FileAttributes.ReadOnly)
                {
                    File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.ReadOnly );
                }
            }
            else
            {
                if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    attributes = RemoveAttributesFile(attributes, FileAttributes.ReadOnly);
                    File.SetAttributes(path, attributes );
                }
                File.SetAttributes(path, attributes);
            }
            if (checkBox1.Checked)
            {
                if ((attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden );
                }
            }
            else
            {
                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    attributes = RemoveAttributesFile(attributes, FileAttributes.Hidden);
                    File.SetAttributes(path, attributes );
                }
            }
            //MessageBox.Show(@"Something change, check it :3");
        }

        private FileAttributes RemoveAttributesFile( FileAttributes attributes,
            FileAttributes attributesSet)
        {
            return attributes & ~attributesSet;
        }

        private void ShowOldValues(string file)
        {
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
            FileAttributes attributes = File.GetAttributes(_pathOfFile);
            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                checkBox1.Checked = true;
            if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                checkBox2.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _pathOfFile = openFileDialog1.FileName;
                pathBox.Text = _pathOfFile;
                ShowOldValues(_pathOfFile);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetNewValuesInmMetaData(_pathOfFile);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_closed)
            {
                this.Close();
            }
        }
    }
}