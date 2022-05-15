using System;
using System.Windows.Forms;

namespace ReData
{
    public partial class EnterCode : Form
    {
        public EnterCode()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frmMain = (Form1) this.Owner;
            if (textBox1.Text != "")
            {
                frmMain.key = textBox1.Text;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Form1 frmMain = (Form1) this.Owner;
            frmMain._closed = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}