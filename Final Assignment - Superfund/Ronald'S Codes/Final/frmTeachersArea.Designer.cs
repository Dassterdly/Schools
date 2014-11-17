namespace Final
{
    partial class teachersArea
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
            this.teachersAreatabControl = new System.Windows.Forms.TabControl();
            this.studentTP = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.assignmentsTP = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.studentsTP = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.classesRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gradeBooksTP = new System.Windows.Forms.TabPage();
            this.classesTP = new System.Windows.Forms.TabPage();
            this.classesTabControl = new System.Windows.Forms.TabControl();
            this.newClassTP = new System.Windows.Forms.TabPage();
            this.classSchdulesTP = new System.Windows.Forms.TabPage();
            this.reportsTP = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.teachersAreatabControl.SuspendLayout();
            this.studentTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.assignmentsTP.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.studentsTP.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.classesTP.SuspendLayout();
            this.classesTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // teachersAreatabControl
            // 
            this.teachersAreatabControl.Controls.Add(this.studentTP);
            this.teachersAreatabControl.Controls.Add(this.classesTP);
            this.teachersAreatabControl.Controls.Add(this.reportsTP);
            this.teachersAreatabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teachersAreatabControl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersAreatabControl.Location = new System.Drawing.Point(0, 0);
            this.teachersAreatabControl.Name = "teachersAreatabControl";
            this.teachersAreatabControl.SelectedIndex = 0;
            this.teachersAreatabControl.Size = new System.Drawing.Size(1017, 588);
            this.teachersAreatabControl.TabIndex = 0;
            // 
            // studentTP
            // 
            this.studentTP.BackColor = System.Drawing.Color.MediumTurquoise;
            this.studentTP.Controls.Add(this.splitContainer1);
            this.studentTP.Location = new System.Drawing.Point(4, 27);
            this.studentTP.Name = "studentTP";
            this.studentTP.Padding = new System.Windows.Forms.Padding(3);
            this.studentTP.Size = new System.Drawing.Size(1009, 557);
            this.studentTP.TabIndex = 0;
            this.studentTP.Text = "Students";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1003, 551);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.searchTB);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchTB
            // 
            this.searchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchTB.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(49, 23);
            this.searchTB.Margin = new System.Windows.Forms.Padding(2);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(534, 28);
            this.searchTB.TabIndex = 17;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            this.searchTB.MouseHover += new System.EventHandler(this.searchTB_MouseHover);
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl2.Controls.Add(this.assignmentsTP);
            this.tabControl2.Controls.Add(this.studentsTP);
            this.tabControl2.Controls.Add(this.gradeBooksTP);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1003, 468);
            this.tabControl2.TabIndex = 0;
            // 
            // assignmentsTP
            // 
            this.assignmentsTP.BackColor = System.Drawing.Color.SteelBlue;
            this.assignmentsTP.Controls.Add(this.groupBox3);
            this.assignmentsTP.Controls.Add(this.button1);
            this.assignmentsTP.Location = new System.Drawing.Point(28, 4);
            this.assignmentsTP.Name = "assignmentsTP";
            this.assignmentsTP.Padding = new System.Windows.Forms.Padding(3);
            this.assignmentsTP.Size = new System.Drawing.Size(971, 460);
            this.assignmentsTP.TabIndex = 0;
            this.assignmentsTP.Text = "Assignments";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(26, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 336);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Students";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(302, 312);
            this.dataGridView2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(258, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Student";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // studentsTP
            // 
            this.studentsTP.BackColor = System.Drawing.Color.SteelBlue;
            this.studentsTP.Controls.Add(this.groupBox4);
            this.studentsTP.Controls.Add(this.groupBox2);
            this.studentsTP.Controls.Add(this.comboBox1);
            this.studentsTP.Location = new System.Drawing.Point(28, 4);
            this.studentsTP.Name = "studentsTP";
            this.studentsTP.Padding = new System.Windows.Forms.Padding(3);
            this.studentsTP.Size = new System.Drawing.Size(971, 460);
            this.studentsTP.TabIndex = 1;
            this.studentsTP.Text = "Students";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.studentRB);
            this.groupBox4.Controls.Add(this.classesRB);
            this.groupBox4.Location = new System.Drawing.Point(6, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(747, 53);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(206, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(105, 22);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // studentRB
            // 
            this.studentRB.AutoSize = true;
            this.studentRB.Location = new System.Drawing.Point(26, 19);
            this.studentRB.Name = "studentRB";
            this.studentRB.Size = new System.Drawing.Size(72, 22);
            this.studentRB.TabIndex = 4;
            this.studentRB.TabStop = true;
            this.studentRB.Text = "student";
            this.studentRB.UseVisualStyleBackColor = true;
            // 
            // classesRB
            // 
            this.classesRB.AutoSize = true;
            this.classesRB.Location = new System.Drawing.Point(120, 19);
            this.classesRB.Name = "classesRB";
            this.classesRB.Size = new System.Drawing.Size(70, 22);
            this.classesRB.TabIndex = 5;
            this.classesRB.TabStop = true;
            this.classesRB.Text = "Classes";
            this.classesRB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(26, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 373);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(503, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 2;
            // 
            // gradeBooksTP
            // 
            this.gradeBooksTP.BackColor = System.Drawing.Color.SteelBlue;
            this.gradeBooksTP.Location = new System.Drawing.Point(28, 4);
            this.gradeBooksTP.Name = "gradeBooksTP";
            this.gradeBooksTP.Size = new System.Drawing.Size(759, 460);
            this.gradeBooksTP.TabIndex = 2;
            this.gradeBooksTP.Text = "Grade Books";
            // 
            // classesTP
            // 
            this.classesTP.BackColor = System.Drawing.Color.SteelBlue;
            this.classesTP.Controls.Add(this.classesTabControl);
            this.classesTP.Location = new System.Drawing.Point(4, 27);
            this.classesTP.Name = "classesTP";
            this.classesTP.Padding = new System.Windows.Forms.Padding(3);
            this.classesTP.Size = new System.Drawing.Size(797, 557);
            this.classesTP.TabIndex = 1;
            this.classesTP.Text = "Classes";
            // 
            // classesTabControl
            // 
            this.classesTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.classesTabControl.Controls.Add(this.newClassTP);
            this.classesTabControl.Controls.Add(this.classSchdulesTP);
            this.classesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classesTabControl.Location = new System.Drawing.Point(3, 3);
            this.classesTabControl.Multiline = true;
            this.classesTabControl.Name = "classesTabControl";
            this.classesTabControl.SelectedIndex = 0;
            this.classesTabControl.Size = new System.Drawing.Size(791, 551);
            this.classesTabControl.TabIndex = 0;
            // 
            // newClassTP
            // 
            this.newClassTP.BackColor = System.Drawing.Color.SteelBlue;
            this.newClassTP.Location = new System.Drawing.Point(28, 4);
            this.newClassTP.Name = "newClassTP";
            this.newClassTP.Padding = new System.Windows.Forms.Padding(3);
            this.newClassTP.Size = new System.Drawing.Size(759, 543);
            this.newClassTP.TabIndex = 0;
            this.newClassTP.Text = "New Class";
            // 
            // classSchdulesTP
            // 
            this.classSchdulesTP.BackColor = System.Drawing.Color.SteelBlue;
            this.classSchdulesTP.Location = new System.Drawing.Point(28, 4);
            this.classSchdulesTP.Name = "classSchdulesTP";
            this.classSchdulesTP.Padding = new System.Windows.Forms.Padding(3);
            this.classSchdulesTP.Size = new System.Drawing.Size(759, 543);
            this.classSchdulesTP.TabIndex = 1;
            this.classSchdulesTP.Text = "Class Schdules";
            // 
            // reportsTP
            // 
            this.reportsTP.BackColor = System.Drawing.Color.SteelBlue;
            this.reportsTP.Location = new System.Drawing.Point(4, 27);
            this.reportsTP.Name = "reportsTP";
            this.reportsTP.Size = new System.Drawing.Size(797, 557);
            this.reportsTP.TabIndex = 2;
            this.reportsTP.Text = "Reports";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(720, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 25);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Visible = false;
            // 
            // teachersArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1017, 588);
            this.Controls.Add(this.teachersAreatabControl);
            this.Name = "teachersArea";
            this.Text = "Teacher\'s Area";
            this.Load += new System.EventHandler(this.teachersArea_Load);
            this.teachersAreatabControl.ResumeLayout(false);
            this.studentTP.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.assignmentsTP.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.studentsTP.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.classesTP.ResumeLayout(false);
            this.classesTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl teachersAreatabControl;
        private System.Windows.Forms.TabPage studentTP;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage classesTP;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage assignmentsTP;
        private System.Windows.Forms.TabPage studentsTP;
        private System.Windows.Forms.TabPage gradeBooksTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl classesTabControl;
        private System.Windows.Forms.TabPage newClassTP;
        private System.Windows.Forms.TabPage classSchdulesTP;
        private System.Windows.Forms.TabPage reportsTP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton classesRB;
        private System.Windows.Forms.RadioButton studentRB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}