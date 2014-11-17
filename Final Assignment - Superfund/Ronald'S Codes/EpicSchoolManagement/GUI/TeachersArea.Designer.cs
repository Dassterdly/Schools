namespace EpicSchoolManagement
{
    partial class TeachersArea
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teacherAreaTabControl = new System.Windows.Forms.TabControl();
            this.TecherTabPage = new System.Windows.Forms.TabPage();
            this.ClassSchdulingTabPage = new System.Windows.Forms.TabPage();
            this.examsTabPage = new System.Windows.Forms.TabPage();
            this.testTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.teacherAreaTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teacherAreaTabControl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // teacherAreaTabControl
            // 
            this.teacherAreaTabControl.Controls.Add(this.TecherTabPage);
            this.teacherAreaTabControl.Controls.Add(this.ClassSchdulingTabPage);
            this.teacherAreaTabControl.Controls.Add(this.examsTabPage);
            this.teacherAreaTabControl.Controls.Add(this.testTabPage);
            this.teacherAreaTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherAreaTabControl.Location = new System.Drawing.Point(3, 16);
            this.teacherAreaTabControl.Name = "teacherAreaTabControl";
            this.teacherAreaTabControl.SelectedIndex = 0;
            this.teacherAreaTabControl.Size = new System.Drawing.Size(661, 324);
            this.teacherAreaTabControl.TabIndex = 0;
            // 
            // TecherTabPage
            // 
            this.TecherTabPage.Location = new System.Drawing.Point(4, 22);
            this.TecherTabPage.Name = "TecherTabPage";
            this.TecherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TecherTabPage.Size = new System.Drawing.Size(653, 298);
            this.TecherTabPage.TabIndex = 0;
            this.TecherTabPage.Text = "Teacher";
            this.TecherTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassSchdulingTabPage
            // 
            this.ClassSchdulingTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassSchdulingTabPage.Name = "ClassSchdulingTabPage";
            this.ClassSchdulingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassSchdulingTabPage.Size = new System.Drawing.Size(653, 298);
            this.ClassSchdulingTabPage.TabIndex = 1;
            this.ClassSchdulingTabPage.Text = "Class Scheduling";
            this.ClassSchdulingTabPage.UseVisualStyleBackColor = true;
            // 
            // examsTabPage
            // 
            this.examsTabPage.Location = new System.Drawing.Point(4, 22);
            this.examsTabPage.Name = "examsTabPage";
            this.examsTabPage.Size = new System.Drawing.Size(653, 298);
            this.examsTabPage.TabIndex = 2;
            this.examsTabPage.Text = "Exams";
            this.examsTabPage.UseVisualStyleBackColor = true;
            // 
            // testTabPage
            // 
            this.testTabPage.Location = new System.Drawing.Point(4, 22);
            this.testTabPage.Name = "testTabPage";
            this.testTabPage.Size = new System.Drawing.Size(653, 298);
            this.testTabPage.TabIndex = 3;
            this.testTabPage.Text = "Test";
            this.testTabPage.UseVisualStyleBackColor = true;
            // 
            // TeachersArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 367);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeachersArea";
            this.Text = "TeachersArea";
            this.groupBox1.ResumeLayout(false);
            this.teacherAreaTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl teacherAreaTabControl;
        private System.Windows.Forms.TabPage TecherTabPage;
        private System.Windows.Forms.TabPage ClassSchdulingTabPage;
        private System.Windows.Forms.TabPage examsTabPage;
        private System.Windows.Forms.TabPage testTabPage;
    }
}