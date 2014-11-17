namespace Assignment
{
    partial class frmClassScheduling
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ScheduleClassTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ClassscheduleGB = new System.Windows.Forms.GroupBox();
            this.classidlbl = new System.Windows.Forms.Label();
            this.Subjectlbl = new System.Windows.Forms.Label();
            this.Lecturerlbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ClassdayGB = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mondayRB = new System.Windows.Forms.RadioButton();
            this.FridayRB = new System.Windows.Forms.RadioButton();
            this.ThursdayRB = new System.Windows.Forms.RadioButton();
            this.wednesdayRB = new System.Windows.Forms.RadioButton();
            this.tuesdayRB = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ScheduleClassTab.SuspendLayout();
            this.ClassscheduleGB.SuspendLayout();
            this.ClassdayGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ScheduleClassTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(606, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // ScheduleClassTab
            // 
            this.ScheduleClassTab.Controls.Add(this.ClassdayGB);
            this.ScheduleClassTab.Controls.Add(this.ClassscheduleGB);
            this.ScheduleClassTab.Location = new System.Drawing.Point(4, 22);
            this.ScheduleClassTab.Name = "ScheduleClassTab";
            this.ScheduleClassTab.Padding = new System.Windows.Forms.Padding(3);
            this.ScheduleClassTab.Size = new System.Drawing.Size(598, 420);
            this.ScheduleClassTab.TabIndex = 0;
            this.ScheduleClassTab.Text = "Schedule Class";
            this.ScheduleClassTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(598, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ClassscheduleGB
            // 
            this.ClassscheduleGB.Controls.Add(this.button2);
            this.ClassscheduleGB.Controls.Add(this.comboBox2);
            this.ClassscheduleGB.Controls.Add(this.button1);
            this.ClassscheduleGB.Controls.Add(this.comboBox1);
            this.ClassscheduleGB.Controls.Add(this.textBox1);
            this.ClassscheduleGB.Controls.Add(this.Lecturerlbl);
            this.ClassscheduleGB.Controls.Add(this.Subjectlbl);
            this.ClassscheduleGB.Controls.Add(this.classidlbl);
            this.ClassscheduleGB.Location = new System.Drawing.Point(54, 19);
            this.ClassscheduleGB.Name = "ClassscheduleGB";
            this.ClassscheduleGB.Size = new System.Drawing.Size(489, 139);
            this.ClassscheduleGB.TabIndex = 0;
            this.ClassscheduleGB.TabStop = false;
            this.ClassscheduleGB.Text = "Class Scheduling";
            // 
            // classidlbl
            // 
            this.classidlbl.AutoSize = true;
            this.classidlbl.Location = new System.Drawing.Point(40, 37);
            this.classidlbl.Name = "classidlbl";
            this.classidlbl.Size = new System.Drawing.Size(46, 13);
            this.classidlbl.TabIndex = 0;
            this.classidlbl.Text = "Class ID";
            // 
            // Subjectlbl
            // 
            this.Subjectlbl.AutoSize = true;
            this.Subjectlbl.Location = new System.Drawing.Point(40, 63);
            this.Subjectlbl.Name = "Subjectlbl";
            this.Subjectlbl.Size = new System.Drawing.Size(43, 13);
            this.Subjectlbl.TabIndex = 1;
            this.Subjectlbl.Text = "Subject";
            // 
            // Lecturerlbl
            // 
            this.Lecturerlbl.AutoSize = true;
            this.Lecturerlbl.Location = new System.Drawing.Point(40, 93);
            this.Lecturerlbl.Name = "Lecturerlbl";
            this.Lecturerlbl.Size = new System.Drawing.Size(46, 13);
            this.Lecturerlbl.TabIndex = 2;
            this.Lecturerlbl.Text = "Lecturer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(96, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // ClassdayGB
            // 
            this.ClassdayGB.Controls.Add(this.splitContainer1);
            this.ClassdayGB.Location = new System.Drawing.Point(54, 164);
            this.ClassdayGB.Name = "ClassdayGB";
            this.ClassdayGB.Size = new System.Drawing.Size(489, 198);
            this.ClassdayGB.TabIndex = 6;
            this.ClassdayGB.TabStop = false;
            this.ClassdayGB.Text = "Class Days";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tuesdayRB);
            this.splitContainer1.Panel1.Controls.Add(this.wednesdayRB);
            this.splitContainer1.Panel1.Controls.Add(this.ThursdayRB);
            this.splitContainer1.Panel1.Controls.Add(this.FridayRB);
            this.splitContainer1.Panel1.Controls.Add(this.mondayRB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(483, 179);
            this.splitContainer1.SplitterDistance = 86;
            this.splitContainer1.TabIndex = 0;
            // 
            // mondayRB
            // 
            this.mondayRB.AutoSize = true;
            this.mondayRB.Location = new System.Drawing.Point(14, 9);
            this.mondayRB.Name = "mondayRB";
            this.mondayRB.Size = new System.Drawing.Size(63, 17);
            this.mondayRB.TabIndex = 0;
            this.mondayRB.TabStop = true;
            this.mondayRB.Text = "Monday";
            this.mondayRB.UseVisualStyleBackColor = true;
            // 
            // FridayRB
            // 
            this.FridayRB.AutoSize = true;
            this.FridayRB.Location = new System.Drawing.Point(125, 36);
            this.FridayRB.Name = "FridayRB";
            this.FridayRB.Size = new System.Drawing.Size(53, 17);
            this.FridayRB.TabIndex = 1;
            this.FridayRB.TabStop = true;
            this.FridayRB.Text = "Friday";
            this.FridayRB.UseVisualStyleBackColor = true;
            // 
            // ThursdayRB
            // 
            this.ThursdayRB.AutoSize = true;
            this.ThursdayRB.Location = new System.Drawing.Point(125, 13);
            this.ThursdayRB.Name = "ThursdayRB";
            this.ThursdayRB.Size = new System.Drawing.Size(69, 17);
            this.ThursdayRB.TabIndex = 2;
            this.ThursdayRB.TabStop = true;
            this.ThursdayRB.Text = "Thursday";
            this.ThursdayRB.UseVisualStyleBackColor = true;
            // 
            // wednesdayRB
            // 
            this.wednesdayRB.AutoSize = true;
            this.wednesdayRB.Location = new System.Drawing.Point(14, 60);
            this.wednesdayRB.Name = "wednesdayRB";
            this.wednesdayRB.Size = new System.Drawing.Size(82, 17);
            this.wednesdayRB.TabIndex = 3;
            this.wednesdayRB.TabStop = true;
            this.wednesdayRB.Text = "Wednesday";
            this.wednesdayRB.UseVisualStyleBackColor = true;
            // 
            // tuesdayRB
            // 
            this.tuesdayRB.AutoSize = true;
            this.tuesdayRB.Location = new System.Drawing.Point(14, 34);
            this.tuesdayRB.Name = "tuesdayRB";
            this.tuesdayRB.Size = new System.Drawing.Size(66, 17);
            this.tuesdayRB.TabIndex = 4;
            this.tuesdayRB.TabStop = true;
            this.tuesdayRB.Text = "Tuesday";
            this.tuesdayRB.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 89);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "End Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start Time";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(306, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(306, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 25);
            this.button3.TabIndex = 9;
            this.button3.Text = "Add Time Slot";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmClassScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 414);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmClassScheduling";
            this.Text = "Class Scheduling";
            this.tabControl1.ResumeLayout(false);
            this.ScheduleClassTab.ResumeLayout(false);
            this.ClassscheduleGB.ResumeLayout(false);
            this.ClassscheduleGB.PerformLayout();
            this.ClassdayGB.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ScheduleClassTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox ClassdayGB;
        private System.Windows.Forms.GroupBox ClassscheduleGB;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lecturerlbl;
        private System.Windows.Forms.Label Subjectlbl;
        private System.Windows.Forms.Label classidlbl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton tuesdayRB;
        private System.Windows.Forms.RadioButton wednesdayRB;
        private System.Windows.Forms.RadioButton ThursdayRB;
        private System.Windows.Forms.RadioButton FridayRB;
        private System.Windows.Forms.RadioButton mondayRB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}