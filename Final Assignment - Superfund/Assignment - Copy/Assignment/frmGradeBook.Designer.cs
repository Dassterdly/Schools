namespace Assignment
{
    partial class frmGradeBook
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EmailButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.StudentDataGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sortbylbl = new System.Windows.Forms.Label();
            this.SchoolTB = new System.Windows.Forms.TextBox();
            this.schoollbl = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sNamelbl = new System.Windows.Forms.Label();
            this.sNameTB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.StudentDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EmailButton);
            this.splitContainer1.Panel1.Controls.Add(this.PrintButton);
            this.splitContainer1.Panel1.Controls.Add(this.StudentDataGroupBox);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(719, 358);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 0;
            // 
            // EmailButton
            // 
            this.EmailButton.Location = new System.Drawing.Point(625, 52);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(75, 34);
            this.EmailButton.TabIndex = 49;
            this.EmailButton.Text = "Email";
            this.EmailButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(625, 12);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 34);
            this.PrintButton.TabIndex = 48;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // StudentDataGroupBox
            // 
            this.StudentDataGroupBox.Controls.Add(this.comboBox2);
            this.StudentDataGroupBox.Controls.Add(this.comboBox1);
            this.StudentDataGroupBox.Controls.Add(this.label2);
            this.StudentDataGroupBox.Controls.Add(this.label1);
            this.StudentDataGroupBox.Controls.Add(this.sortbylbl);
            this.StudentDataGroupBox.Controls.Add(this.SchoolTB);
            this.StudentDataGroupBox.Controls.Add(this.schoollbl);
            this.StudentDataGroupBox.Controls.Add(this.textBox10);
            this.StudentDataGroupBox.Controls.Add(this.label11);
            this.StudentDataGroupBox.Controls.Add(this.sNamelbl);
            this.StudentDataGroupBox.Controls.Add(this.sNameTB);
            this.StudentDataGroupBox.Controls.Add(this.textBox1);
            this.StudentDataGroupBox.Controls.Add(this.idlbl);
            this.StudentDataGroupBox.Location = new System.Drawing.Point(7, 6);
            this.StudentDataGroupBox.Name = "StudentDataGroupBox";
            this.StudentDataGroupBox.Size = new System.Drawing.Size(600, 123);
            this.StudentDataGroupBox.TabIndex = 0;
            this.StudentDataGroupBox.TabStop = false;
            this.StudentDataGroupBox.Text = " Student Details";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(260, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 47;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Term";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Academic Year";
            // 
            // sortbylbl
            // 
            this.sortbylbl.AutoSize = true;
            this.sortbylbl.Location = new System.Drawing.Point(6, 71);
            this.sortbylbl.Name = "sortbylbl";
            this.sortbylbl.Size = new System.Drawing.Size(44, 13);
            this.sortbylbl.TabIndex = 43;
            this.sortbylbl.Text = "Sort By:";
            // 
            // SchoolTB
            // 
            this.SchoolTB.Location = new System.Drawing.Point(345, 11);
            this.SchoolTB.Name = "SchoolTB";
            this.SchoolTB.Size = new System.Drawing.Size(237, 20);
            this.SchoolTB.TabIndex = 42;
            // 
            // schoollbl
            // 
            this.schoollbl.AutoSize = true;
            this.schoollbl.Location = new System.Drawing.Point(299, 18);
            this.schoollbl.Name = "schoollbl";
            this.schoollbl.Size = new System.Drawing.Size(40, 13);
            this.schoollbl.TabIndex = 41;
            this.schoollbl.Text = "School";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(349, 37);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(82, 20);
            this.textBox10.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Form";
            // 
            // sNamelbl
            // 
            this.sNamelbl.AutoSize = true;
            this.sNamelbl.Location = new System.Drawing.Point(6, 44);
            this.sNamelbl.Name = "sNamelbl";
            this.sNamelbl.Size = new System.Drawing.Size(82, 13);
            this.sNamelbl.TabIndex = 31;
            this.sNamelbl.Text = "Student\'s Name";
            // 
            // sNameTB
            // 
            this.sNameTB.Location = new System.Drawing.Point(94, 37);
            this.sNameTB.Name = "sNameTB";
            this.sNameTB.Size = new System.Drawing.Size(178, 20);
            this.sNameTB.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 28;
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(6, 18);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(58, 13);
            this.idlbl.TabIndex = 27;
            this.idlbl.Text = "Student ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmGradeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 358);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmGradeBook";
            this.Text = "Student Grade Book";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.StudentDataGroupBox.ResumeLayout(false);
            this.StudentDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox StudentDataGroupBox;
        private System.Windows.Forms.Label sNamelbl;
        private System.Windows.Forms.TextBox sNameTB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sortbylbl;
        private System.Windows.Forms.TextBox SchoolTB;
        private System.Windows.Forms.Label schoollbl;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}