namespace Final
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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.sklbl = new System.Windows.Forms.Label();
            this.ClassSchedulingTab = new System.Windows.Forms.TabControl();
            this.ScheduleClassTab = new System.Windows.Forms.TabPage();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ClassdayGB = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.endCB = new System.Windows.Forms.ComboBox();
            this.startCB = new System.Windows.Forms.ComboBox();
            this.Daylbl = new System.Windows.Forms.Label();
            this.DaySelectionCB = new System.Windows.Forms.ComboBox();
            this.AddTimeBtn = new System.Windows.Forms.Button();
            this.Startlbl = new System.Windows.Forms.Label();
            this.Endlbl = new System.Windows.Forms.Label();
            this.CSGridView = new System.Windows.Forms.DataGridView();
            this.ClassscheduleGB = new System.Windows.Forms.GroupBox();
            this.nClassidLbl = new System.Windows.Forms.Button();
            this.newFormbtn = new System.Windows.Forms.Button();
            this.NewTeacherbtn = new System.Windows.Forms.Button();
            this.NewSubbtn = new System.Windows.Forms.Button();
            this.FormCB = new System.Windows.Forms.ComboBox();
            this.frmlbl = new System.Windows.Forms.Label();
            this.TermCB = new System.Windows.Forms.ComboBox();
            this.trmlbl = new System.Windows.Forms.Label();
            this.acadyrCB = new System.Windows.Forms.ComboBox();
            this.acadyrlbl = new System.Windows.Forms.Label();
            this.lecCB = new System.Windows.Forms.ComboBox();
            this.newsubjCB = new System.Windows.Forms.ComboBox();
            this.classIDTB = new System.Windows.Forms.TextBox();
            this.Teacherlbl = new System.Windows.Forms.Label();
            this.Subjectlbl = new System.Windows.Forms.Label();
            this.classidlbl = new System.Windows.Forms.Label();
            this.ClassListTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clFormCB = new System.Windows.Forms.ComboBox();
            this.clFormlbl = new System.Windows.Forms.Label();
            this.clTermCB = new System.Windows.Forms.ComboBox();
            this.clTermlbl = new System.Windows.Forms.Label();
            this.clYrCB = new System.Windows.Forms.ComboBox();
            this.clacadyrlbl = new System.Windows.Forms.Label();
            this.clTeachCB = new System.Windows.Forms.ComboBox();
            this.clSubCB = new System.Windows.Forms.ComboBox();
            this.clTeacherlbl = new System.Windows.Forms.Label();
            this.clSubjectlbl = new System.Windows.Forms.Label();
            this.schoolclasslistGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.ClassSchedulingTab.SuspendLayout();
            this.ScheduleClassTab.SuspendLayout();
            this.ClassdayGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CSGridView)).BeginInit();
            this.ClassscheduleGB.SuspendLayout();
            this.ClassListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolclasslistGV)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.sklbl);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ClassSchedulingTab);
            this.splitContainer3.Size = new System.Drawing.Size(776, 472);
            this.splitContainer3.SplitterDistance = 153;
            this.splitContainer3.TabIndex = 8;
            // 
            // sklbl
            // 
            this.sklbl.AutoSize = true;
            this.sklbl.Location = new System.Drawing.Point(94, 432);
            this.sklbl.Name = "sklbl";
            this.sklbl.Size = new System.Drawing.Size(55, 13);
            this.sklbl.TabIndex = 8;
            this.sklbl.Text = "19901000";
            this.sklbl.Visible = false;
            // 
            // ClassSchedulingTab
            // 
            this.ClassSchedulingTab.Controls.Add(this.ScheduleClassTab);
            this.ClassSchedulingTab.Controls.Add(this.ClassListTab);
            this.ClassSchedulingTab.Location = new System.Drawing.Point(3, 3);
            this.ClassSchedulingTab.Name = "ClassSchedulingTab";
            this.ClassSchedulingTab.SelectedIndex = 0;
            this.ClassSchedulingTab.Size = new System.Drawing.Size(606, 446);
            this.ClassSchedulingTab.TabIndex = 2;
            // 
            // ScheduleClassTab
            // 
            this.ScheduleClassTab.Controls.Add(this.Clearbtn);
            this.ScheduleClassTab.Controls.Add(this.SaveBtn);
            this.ScheduleClassTab.Controls.Add(this.CancelBtn);
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
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(370, 134);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 29);
            this.Clearbtn.TabIndex = 12;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(140, 135);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 29);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(261, 134);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 29);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ClassdayGB
            // 
            this.ClassdayGB.Controls.Add(this.splitContainer1);
            this.ClassdayGB.Location = new System.Drawing.Point(42, 170);
            this.ClassdayGB.Name = "ClassdayGB";
            this.ClassdayGB.Size = new System.Drawing.Size(507, 198);
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
            this.splitContainer1.Panel1.Controls.Add(this.endCB);
            this.splitContainer1.Panel1.Controls.Add(this.startCB);
            this.splitContainer1.Panel1.Controls.Add(this.Daylbl);
            this.splitContainer1.Panel1.Controls.Add(this.DaySelectionCB);
            this.splitContainer1.Panel1.Controls.Add(this.AddTimeBtn);
            this.splitContainer1.Panel1.Controls.Add(this.Startlbl);
            this.splitContainer1.Panel1.Controls.Add(this.Endlbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CSGridView);
            this.splitContainer1.Size = new System.Drawing.Size(501, 179);
            this.splitContainer1.SplitterDistance = 86;
            this.splitContainer1.TabIndex = 0;
            // 
            // endCB
            // 
            this.endCB.FormattingEnabled = true;
            this.endCB.Items.AddRange(new object[] {
            "8:00",
            "8:15",
            "8:30",
            "8:45",
            "9:00",
            "9:15",
            "9:30",
            "9:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "1:00",
            "1:15",
            "1:30",
            "1:45",
            "2:00",
            "2:15",
            "2:30",
            "2:45",
            "3:00"});
            this.endCB.Location = new System.Drawing.Point(279, 48);
            this.endCB.Name = "endCB";
            this.endCB.Size = new System.Drawing.Size(84, 21);
            this.endCB.TabIndex = 12;
            // 
            // startCB
            // 
            this.startCB.FormattingEnabled = true;
            this.startCB.Items.AddRange(new object[] {
            "8:00",
            "8:15",
            "8:30",
            "8:45",
            "9:00",
            "9:15",
            "9:30",
            "9:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "1:00",
            "1:15",
            "1:30",
            "1:45",
            "2:00",
            "2:15",
            "2:30",
            "2:45",
            "3:00"});
            this.startCB.Location = new System.Drawing.Point(279, 19);
            this.startCB.Name = "startCB";
            this.startCB.Size = new System.Drawing.Size(84, 21);
            this.startCB.TabIndex = 11;
            // 
            // Daylbl
            // 
            this.Daylbl.AutoSize = true;
            this.Daylbl.Location = new System.Drawing.Point(37, 23);
            this.Daylbl.Name = "Daylbl";
            this.Daylbl.Size = new System.Drawing.Size(26, 13);
            this.Daylbl.TabIndex = 9;
            this.Daylbl.Text = "Day";
            // 
            // DaySelectionCB
            // 
            this.DaySelectionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DaySelectionCB.FormattingEnabled = true;
            this.DaySelectionCB.Location = new System.Drawing.Point(72, 20);
            this.DaySelectionCB.Name = "DaySelectionCB";
            this.DaySelectionCB.Size = new System.Drawing.Size(121, 21);
            this.DaySelectionCB.TabIndex = 10;
            // 
            // AddTimeBtn
            // 
            this.AddTimeBtn.Location = new System.Drawing.Point(378, 17);
            this.AddTimeBtn.Name = "AddTimeBtn";
            this.AddTimeBtn.Size = new System.Drawing.Size(94, 25);
            this.AddTimeBtn.TabIndex = 9;
            this.AddTimeBtn.Text = "Add Time Slot";
            this.AddTimeBtn.UseVisualStyleBackColor = true;
            this.AddTimeBtn.Click += new System.EventHandler(this.AddTimeBtn_Click);
            // 
            // Startlbl
            // 
            this.Startlbl.AutoSize = true;
            this.Startlbl.Location = new System.Drawing.Point(207, 23);
            this.Startlbl.Name = "Startlbl";
            this.Startlbl.Size = new System.Drawing.Size(55, 13);
            this.Startlbl.TabIndex = 7;
            this.Startlbl.Text = "Start Time";
            // 
            // Endlbl
            // 
            this.Endlbl.AutoSize = true;
            this.Endlbl.Location = new System.Drawing.Point(210, 48);
            this.Endlbl.Name = "Endlbl";
            this.Endlbl.Size = new System.Drawing.Size(52, 13);
            this.Endlbl.TabIndex = 6;
            this.Endlbl.Text = "End Time";
            // 
            // CSGridView
            // 
            this.CSGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CSGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CSGridView.Location = new System.Drawing.Point(0, 0);
            this.CSGridView.Name = "CSGridView";
            this.CSGridView.Size = new System.Drawing.Size(501, 89);
            this.CSGridView.TabIndex = 0;
            // 
            // ClassscheduleGB
            // 
            this.ClassscheduleGB.Controls.Add(this.nClassidLbl);
            this.ClassscheduleGB.Controls.Add(this.newFormbtn);
            this.ClassscheduleGB.Controls.Add(this.NewTeacherbtn);
            this.ClassscheduleGB.Controls.Add(this.NewSubbtn);
            this.ClassscheduleGB.Controls.Add(this.FormCB);
            this.ClassscheduleGB.Controls.Add(this.frmlbl);
            this.ClassscheduleGB.Controls.Add(this.TermCB);
            this.ClassscheduleGB.Controls.Add(this.trmlbl);
            this.ClassscheduleGB.Controls.Add(this.acadyrCB);
            this.ClassscheduleGB.Controls.Add(this.acadyrlbl);
            this.ClassscheduleGB.Controls.Add(this.lecCB);
            this.ClassscheduleGB.Controls.Add(this.newsubjCB);
            this.ClassscheduleGB.Controls.Add(this.classIDTB);
            this.ClassscheduleGB.Controls.Add(this.Teacherlbl);
            this.ClassscheduleGB.Controls.Add(this.Subjectlbl);
            this.ClassscheduleGB.Controls.Add(this.classidlbl);
            this.ClassscheduleGB.Location = new System.Drawing.Point(20, 19);
            this.ClassscheduleGB.Name = "ClassscheduleGB";
            this.ClassscheduleGB.Size = new System.Drawing.Size(546, 111);
            this.ClassscheduleGB.TabIndex = 0;
            this.ClassscheduleGB.TabStop = false;
            this.ClassscheduleGB.Text = "Class Scheduling";
            // 
            // nClassidLbl
            // 
            this.nClassidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nClassidLbl.Location = new System.Drawing.Point(182, 15);
            this.nClassidLbl.Name = "nClassidLbl";
            this.nClassidLbl.Size = new System.Drawing.Size(25, 21);
            this.nClassidLbl.TabIndex = 17;
            this.nClassidLbl.Text = ">>";
            this.nClassidLbl.UseVisualStyleBackColor = true;
            this.nClassidLbl.Click += new System.EventHandler(this.nClassidLbl_Click);
            // 
            // newFormbtn
            // 
            this.newFormbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFormbtn.Location = new System.Drawing.Point(474, 72);
            this.newFormbtn.Name = "newFormbtn";
            this.newFormbtn.Size = new System.Drawing.Size(28, 21);
            this.newFormbtn.TabIndex = 16;
            this.newFormbtn.Text = ">>";
            this.newFormbtn.UseVisualStyleBackColor = true;
            // 
            // NewTeacherbtn
            // 
            this.NewTeacherbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeacherbtn.Location = new System.Drawing.Point(231, 69);
            this.NewTeacherbtn.Name = "NewTeacherbtn";
            this.NewTeacherbtn.Size = new System.Drawing.Size(27, 21);
            this.NewTeacherbtn.TabIndex = 15;
            this.NewTeacherbtn.Text = ">>";
            this.NewTeacherbtn.UseVisualStyleBackColor = true;
            // 
            // NewSubbtn
            // 
            this.NewSubbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSubbtn.Location = new System.Drawing.Point(231, 42);
            this.NewSubbtn.Name = "NewSubbtn";
            this.NewSubbtn.Size = new System.Drawing.Size(27, 21);
            this.NewSubbtn.TabIndex = 10;
            this.NewSubbtn.Text = ">>";
            this.NewSubbtn.UseVisualStyleBackColor = true;
            this.NewSubbtn.Click += new System.EventHandler(this.NewSubbtn_Click);
            // 
            // FormCB
            // 
            this.FormCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormCB.FormattingEnabled = true;
            this.FormCB.Location = new System.Drawing.Point(342, 73);
            this.FormCB.Name = "FormCB";
            this.FormCB.Size = new System.Drawing.Size(126, 21);
            this.FormCB.TabIndex = 14;
            // 
            // frmlbl
            // 
            this.frmlbl.AutoSize = true;
            this.frmlbl.Location = new System.Drawing.Point(305, 76);
            this.frmlbl.Name = "frmlbl";
            this.frmlbl.Size = new System.Drawing.Size(30, 13);
            this.frmlbl.TabIndex = 13;
            this.frmlbl.Text = "Form";
            // 
            // TermCB
            // 
            this.TermCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TermCB.FormattingEnabled = true;
            this.TermCB.Location = new System.Drawing.Point(342, 46);
            this.TermCB.Name = "TermCB";
            this.TermCB.Size = new System.Drawing.Size(126, 21);
            this.TermCB.TabIndex = 12;
            // 
            // trmlbl
            // 
            this.trmlbl.AutoSize = true;
            this.trmlbl.Location = new System.Drawing.Point(305, 49);
            this.trmlbl.Name = "trmlbl";
            this.trmlbl.Size = new System.Drawing.Size(31, 13);
            this.trmlbl.TabIndex = 11;
            this.trmlbl.Text = "Term";
            // 
            // acadyrCB
            // 
            this.acadyrCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acadyrCB.FormattingEnabled = true;
            this.acadyrCB.Location = new System.Drawing.Point(342, 19);
            this.acadyrCB.Name = "acadyrCB";
            this.acadyrCB.Size = new System.Drawing.Size(126, 21);
            this.acadyrCB.TabIndex = 10;
            // 
            // acadyrlbl
            // 
            this.acadyrlbl.AutoSize = true;
            this.acadyrlbl.Location = new System.Drawing.Point(257, 23);
            this.acadyrlbl.Name = "acadyrlbl";
            this.acadyrlbl.Size = new System.Drawing.Size(79, 13);
            this.acadyrlbl.TabIndex = 9;
            this.acadyrlbl.Text = "Academic Year";
            // 
            // lecCB
            // 
            this.lecCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lecCB.FormattingEnabled = true;
            this.lecCB.Location = new System.Drawing.Point(75, 69);
            this.lecCB.Name = "lecCB";
            this.lecCB.Size = new System.Drawing.Size(150, 21);
            this.lecCB.TabIndex = 5;
            // 
            // newsubjCB
            // 
            this.newsubjCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newsubjCB.FormattingEnabled = true;
            this.newsubjCB.Location = new System.Drawing.Point(76, 42);
            this.newsubjCB.Name = "newsubjCB";
            this.newsubjCB.Size = new System.Drawing.Size(149, 21);
            this.newsubjCB.TabIndex = 4;
            // 
            // classIDTB
            // 
            this.classIDTB.Location = new System.Drawing.Point(76, 16);
            this.classIDTB.Name = "classIDTB";
            this.classIDTB.ReadOnly = true;
            this.classIDTB.Size = new System.Drawing.Size(100, 20);
            this.classIDTB.TabIndex = 3;
            // 
            // Teacherlbl
            // 
            this.Teacherlbl.AutoSize = true;
            this.Teacherlbl.Location = new System.Drawing.Point(19, 72);
            this.Teacherlbl.Name = "Teacherlbl";
            this.Teacherlbl.Size = new System.Drawing.Size(46, 13);
            this.Teacherlbl.TabIndex = 2;
            this.Teacherlbl.Text = "Lecturer";
            // 
            // Subjectlbl
            // 
            this.Subjectlbl.AutoSize = true;
            this.Subjectlbl.Location = new System.Drawing.Point(20, 45);
            this.Subjectlbl.Name = "Subjectlbl";
            this.Subjectlbl.Size = new System.Drawing.Size(43, 13);
            this.Subjectlbl.TabIndex = 1;
            this.Subjectlbl.Text = "Subject";
            // 
            // classidlbl
            // 
            this.classidlbl.AutoSize = true;
            this.classidlbl.Location = new System.Drawing.Point(20, 19);
            this.classidlbl.Name = "classidlbl";
            this.classidlbl.Size = new System.Drawing.Size(46, 13);
            this.classidlbl.TabIndex = 0;
            this.classidlbl.Text = "Class ID";
            // 
            // ClassListTab
            // 
            this.ClassListTab.Controls.Add(this.splitContainer2);
            this.ClassListTab.Location = new System.Drawing.Point(4, 22);
            this.ClassListTab.Name = "ClassListTab";
            this.ClassListTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClassListTab.Size = new System.Drawing.Size(598, 420);
            this.ClassListTab.TabIndex = 1;
            this.ClassListTab.Text = "Class List";
            this.ClassListTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.schoolclasslistGV);
            this.splitContainer2.Size = new System.Drawing.Size(592, 414);
            this.splitContainer2.SplitterDistance = 137;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clFormCB);
            this.groupBox1.Controls.Add(this.clFormlbl);
            this.groupBox1.Controls.Add(this.clTermCB);
            this.groupBox1.Controls.Add(this.clTermlbl);
            this.groupBox1.Controls.Add(this.clYrCB);
            this.groupBox1.Controls.Add(this.clacadyrlbl);
            this.groupBox1.Controls.Add(this.clTeachCB);
            this.groupBox1.Controls.Add(this.clSubCB);
            this.groupBox1.Controls.Add(this.clTeacherlbl);
            this.groupBox1.Controls.Add(this.clSubjectlbl);
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By:";
            // 
            // clFormCB
            // 
            this.clFormCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clFormCB.FormattingEnabled = true;
            this.clFormCB.Location = new System.Drawing.Point(356, 73);
            this.clFormCB.Name = "clFormCB";
            this.clFormCB.Size = new System.Drawing.Size(126, 21);
            this.clFormCB.TabIndex = 14;
            // 
            // clFormlbl
            // 
            this.clFormlbl.AutoSize = true;
            this.clFormlbl.Location = new System.Drawing.Point(319, 76);
            this.clFormlbl.Name = "clFormlbl";
            this.clFormlbl.Size = new System.Drawing.Size(30, 13);
            this.clFormlbl.TabIndex = 13;
            this.clFormlbl.Text = "Form";
            // 
            // clTermCB
            // 
            this.clTermCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clTermCB.FormattingEnabled = true;
            this.clTermCB.Location = new System.Drawing.Point(356, 46);
            this.clTermCB.Name = "clTermCB";
            this.clTermCB.Size = new System.Drawing.Size(126, 21);
            this.clTermCB.TabIndex = 12;
            // 
            // clTermlbl
            // 
            this.clTermlbl.AutoSize = true;
            this.clTermlbl.Location = new System.Drawing.Point(319, 49);
            this.clTermlbl.Name = "clTermlbl";
            this.clTermlbl.Size = new System.Drawing.Size(31, 13);
            this.clTermlbl.TabIndex = 11;
            this.clTermlbl.Text = "Term";
            // 
            // clYrCB
            // 
            this.clYrCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clYrCB.FormattingEnabled = true;
            this.clYrCB.Location = new System.Drawing.Point(356, 19);
            this.clYrCB.Name = "clYrCB";
            this.clYrCB.Size = new System.Drawing.Size(126, 21);
            this.clYrCB.TabIndex = 10;
            // 
            // clacadyrlbl
            // 
            this.clacadyrlbl.AutoSize = true;
            this.clacadyrlbl.Location = new System.Drawing.Point(271, 23);
            this.clacadyrlbl.Name = "clacadyrlbl";
            this.clacadyrlbl.Size = new System.Drawing.Size(79, 13);
            this.clacadyrlbl.TabIndex = 9;
            this.clacadyrlbl.Text = "Academic Year";
            // 
            // clTeachCB
            // 
            this.clTeachCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clTeachCB.FormattingEnabled = true;
            this.clTeachCB.Location = new System.Drawing.Point(79, 50);
            this.clTeachCB.Name = "clTeachCB";
            this.clTeachCB.Size = new System.Drawing.Size(150, 21);
            this.clTeachCB.TabIndex = 5;
            // 
            // clSubCB
            // 
            this.clSubCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clSubCB.FormattingEnabled = true;
            this.clSubCB.Location = new System.Drawing.Point(80, 23);
            this.clSubCB.Name = "clSubCB";
            this.clSubCB.Size = new System.Drawing.Size(149, 21);
            this.clSubCB.TabIndex = 4;
            // 
            // clTeacherlbl
            // 
            this.clTeacherlbl.AutoSize = true;
            this.clTeacherlbl.Location = new System.Drawing.Point(23, 53);
            this.clTeacherlbl.Name = "clTeacherlbl";
            this.clTeacherlbl.Size = new System.Drawing.Size(46, 13);
            this.clTeacherlbl.TabIndex = 2;
            this.clTeacherlbl.Text = "Lecturer";
            // 
            // clSubjectlbl
            // 
            this.clSubjectlbl.AutoSize = true;
            this.clSubjectlbl.Location = new System.Drawing.Point(24, 26);
            this.clSubjectlbl.Name = "clSubjectlbl";
            this.clSubjectlbl.Size = new System.Drawing.Size(43, 13);
            this.clSubjectlbl.TabIndex = 1;
            this.clSubjectlbl.Text = "Subject";
            // 
            // schoolclasslistGV
            // 
            this.schoolclasslistGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schoolclasslistGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schoolclasslistGV.Location = new System.Drawing.Point(0, 0);
            this.schoolclasslistGV.Name = "schoolclasslistGV";
            this.schoolclasslistGV.Size = new System.Drawing.Size(592, 273);
            this.schoolclasslistGV.TabIndex = 0;
            // 
            // frmClassScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 472);
            this.Controls.Add(this.splitContainer3);
            this.Name = "frmClassScheduling";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.frmClassScheduling_Load);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ClassSchedulingTab.ResumeLayout(false);
            this.ScheduleClassTab.ResumeLayout(false);
            this.ClassdayGB.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CSGridView)).EndInit();
            this.ClassscheduleGB.ResumeLayout(false);
            this.ClassscheduleGB.PerformLayout();
            this.ClassListTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolclasslistGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label sklbl;
        private System.Windows.Forms.TabControl ClassSchedulingTab;
        private System.Windows.Forms.TabPage ScheduleClassTab;
        private System.Windows.Forms.GroupBox ClassdayGB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox endCB;
        private System.Windows.Forms.ComboBox startCB;
        private System.Windows.Forms.Label Daylbl;
        private System.Windows.Forms.ComboBox DaySelectionCB;
        private System.Windows.Forms.Button AddTimeBtn;
        private System.Windows.Forms.Label Startlbl;
        private System.Windows.Forms.Label Endlbl;
        private System.Windows.Forms.DataGridView CSGridView;
        private System.Windows.Forms.GroupBox ClassscheduleGB;
        private System.Windows.Forms.ComboBox lecCB;
        private System.Windows.Forms.ComboBox newsubjCB;
        private System.Windows.Forms.TextBox classIDTB;
        private System.Windows.Forms.Label Teacherlbl;
        private System.Windows.Forms.Label Subjectlbl;
        private System.Windows.Forms.Label classidlbl;
        private System.Windows.Forms.TabPage ClassListTab;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView schoolclasslistGV;
        private System.Windows.Forms.ComboBox TermCB;
        private System.Windows.Forms.Label trmlbl;
        private System.Windows.Forms.ComboBox acadyrCB;
        private System.Windows.Forms.Label acadyrlbl;
        private System.Windows.Forms.ComboBox FormCB;
        private System.Windows.Forms.Label frmlbl;
        private System.Windows.Forms.Button NewSubbtn;
        private System.Windows.Forms.Button newFormbtn;
        private System.Windows.Forms.Button NewTeacherbtn;
        private System.Windows.Forms.Button nClassidLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox clFormCB;
        private System.Windows.Forms.Label clFormlbl;
        private System.Windows.Forms.ComboBox clTermCB;
        private System.Windows.Forms.Label clTermlbl;
        private System.Windows.Forms.ComboBox clYrCB;
        private System.Windows.Forms.Label clacadyrlbl;
        private System.Windows.Forms.ComboBox clTeachCB;
        private System.Windows.Forms.ComboBox clSubCB;
        private System.Windows.Forms.Label clTeacherlbl;
        private System.Windows.Forms.Label clSubjectlbl;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;



    }
}