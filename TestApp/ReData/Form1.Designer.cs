namespace ReData
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.oldValOpen = new System.Windows.Forms.DateTimePicker();
            this.newValOpen = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.oldValChange = new System.Windows.Forms.DateTimePicker();
            this.newValChange = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oldValCreate = new System.Windows.Forms.DateTimePicker();
            this.newValCreate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(476, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.oldValOpen);
            this.groupBox1.Controls.Add(this.newValOpen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.oldValChange);
            this.groupBox1.Controls.Add(this.newValChange);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.oldValCreate);
            this.groupBox1.Controls.Add(this.newValCreate);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 278);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.Coral;
            this.label12.Location = new System.Drawing.Point(8, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(244, 14);
            this.label12.TabIndex = 22;
            this.label12.Text = "Аttributes";
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(8, 175);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(248, 24);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Hide";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(8, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(248, 24);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Only read";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(267, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "Date of open";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(267, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "New";
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Coral;
            this.label10.Location = new System.Drawing.Point(267, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 14);
            this.label10.TabIndex = 15;
            this.label10.Text = "Old";
            // 
            // oldValOpen
            // 
            this.oldValOpen.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.oldValOpen.CalendarForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (219)))), ((int) (((byte) (98)))), ((int) (((byte) (17)))));
            this.oldValOpen.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.oldValOpen.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.oldValOpen.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.oldValOpen.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.oldValOpen.Location = new System.Drawing.Point(267, 179);
            this.oldValOpen.Name = "oldValOpen";
            this.oldValOpen.Size = new System.Drawing.Size(245, 20);
            this.oldValOpen.TabIndex = 14;
            // 
            // newValOpen
            // 
            this.newValOpen.Location = new System.Drawing.Point(267, 219);
            this.newValOpen.Name = "newValOpen";
            this.newValOpen.Size = new System.Drawing.Size(245, 20);
            this.newValOpen.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(267, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date of change";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date of create";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(267, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "New";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(267, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Old";
            // 
            // oldValChange
            // 
            this.oldValChange.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.oldValChange.CalendarForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (219)))), ((int) (((byte) (98)))), ((int) (((byte) (17)))));
            this.oldValChange.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.oldValChange.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.oldValChange.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.oldValChange.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.oldValChange.Location = new System.Drawing.Point(267, 60);
            this.oldValChange.Name = "oldValChange";
            this.oldValChange.Size = new System.Drawing.Size(245, 20);
            this.oldValChange.TabIndex = 8;
            // 
            // newValChange
            // 
            this.newValChange.Location = new System.Drawing.Point(267, 100);
            this.newValChange.Name = "newValChange";
            this.newValChange.Size = new System.Drawing.Size(245, 20);
            this.newValChange.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "New";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Old";
            // 
            // oldValCreate
            // 
            this.oldValCreate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.oldValCreate.CalendarForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (219)))), ((int) (((byte) (98)))), ((int) (((byte) (17)))));
            this.oldValCreate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.oldValCreate.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.oldValCreate.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.oldValCreate.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.oldValCreate.Location = new System.Drawing.Point(7, 60);
            this.oldValCreate.Name = "oldValCreate";
            this.oldValCreate.Size = new System.Drawing.Size(245, 20);
            this.oldValCreate.TabIndex = 4;
            // 
            // newValCreate
            // 
            this.newValCreate.Location = new System.Drawing.Point(7, 100);
            this.newValCreate.Name = "newValCreate";
            this.newValCreate.Size = new System.Drawing.Size(245, 20);
            this.newValCreate.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(533, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Use";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.textBox1.Location = new System.Drawing.Point(144, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "text";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Path to file ...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (69)))), ((int) (((byte) (65)))));
            this.ClientSize = new System.Drawing.Size(557, 326);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ReData";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker oldValChange;
        private System.Windows.Forms.DateTimePicker newValChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker oldValOpen;
        private System.Windows.Forms.DateTimePicker newValOpen;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.DateTimePicker newValCreate;
        private System.Windows.Forms.DateTimePicker oldValCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}