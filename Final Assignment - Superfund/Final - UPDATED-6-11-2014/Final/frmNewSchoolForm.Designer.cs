namespace Final
{
    partial class frmNewSchoolForm
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
            this.NewParishGB = new System.Windows.Forms.GroupBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.ParishTB = new System.Windows.Forms.TextBox();
            this.SaveSubjbtn = new System.Windows.Forms.Button();
            this.pidTB = new System.Windows.Forms.TextBox();
            this.Parishlbl = new System.Windows.Forms.Label();
            this.parishIDlbl = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ParishLB = new System.Windows.Forms.ListBox();
            this.NewParishGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewParishGB
            // 
            this.NewParishGB.Controls.Add(this.Cancelbtn);
            this.NewParishGB.Controls.Add(this.ParishTB);
            this.NewParishGB.Controls.Add(this.SaveSubjbtn);
            this.NewParishGB.Controls.Add(this.pidTB);
            this.NewParishGB.Controls.Add(this.Parishlbl);
            this.NewParishGB.Controls.Add(this.parishIDlbl);
            this.NewParishGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewParishGB.Location = new System.Drawing.Point(0, 0);
            this.NewParishGB.Name = "NewParishGB";
            this.NewParishGB.Size = new System.Drawing.Size(306, 133);
            this.NewParishGB.TabIndex = 3;
            this.NewParishGB.TabStop = false;
            this.NewParishGB.Text = "New Parish";
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(142, 83);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(65, 30);
            this.Cancelbtn.TabIndex = 12;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // ParishTB
            // 
            this.ParishTB.Location = new System.Drawing.Point(83, 48);
            this.ParishTB.Name = "ParishTB";
            this.ParishTB.Size = new System.Drawing.Size(195, 20);
            this.ParishTB.TabIndex = 11;
            // 
            // SaveSubjbtn
            // 
            this.SaveSubjbtn.Location = new System.Drawing.Point(213, 83);
            this.SaveSubjbtn.Name = "SaveSubjbtn";
            this.SaveSubjbtn.Size = new System.Drawing.Size(65, 30);
            this.SaveSubjbtn.TabIndex = 10;
            this.SaveSubjbtn.Text = "Save";
            this.SaveSubjbtn.UseVisualStyleBackColor = true;
            // 
            // pidTB
            // 
            this.pidTB.Location = new System.Drawing.Point(83, 22);
            this.pidTB.Name = "pidTB";
            this.pidTB.ReadOnly = true;
            this.pidTB.Size = new System.Drawing.Size(100, 20);
            this.pidTB.TabIndex = 3;
            // 
            // Parishlbl
            // 
            this.Parishlbl.AutoSize = true;
            this.Parishlbl.Location = new System.Drawing.Point(34, 51);
            this.Parishlbl.Name = "Parishlbl";
            this.Parishlbl.Size = new System.Drawing.Size(36, 13);
            this.Parishlbl.TabIndex = 1;
            this.Parishlbl.Text = "Parish";
            // 
            // parishIDlbl
            // 
            this.parishIDlbl.AutoSize = true;
            this.parishIDlbl.Location = new System.Drawing.Point(20, 25);
            this.parishIDlbl.Name = "parishIDlbl";
            this.parishIDlbl.Size = new System.Drawing.Size(50, 13);
            this.parishIDlbl.TabIndex = 0;
            this.parishIDlbl.Text = "Parish ID";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ParishLB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NewParishGB);
            this.splitContainer1.Size = new System.Drawing.Size(498, 133);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 2;
            // 
            // ParishLB
            // 
            this.ParishLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParishLB.FormattingEnabled = true;
            this.ParishLB.Location = new System.Drawing.Point(0, 0);
            this.ParishLB.Name = "ParishLB";
            this.ParishLB.Size = new System.Drawing.Size(188, 133);
            this.ParishLB.TabIndex = 0;
            // 
            // frmNewSchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 133);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmNewSchoolForm";
            this.Text = "New School Form";
            this.NewParishGB.ResumeLayout(false);
            this.NewParishGB.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewParishGB;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.TextBox ParishTB;
        private System.Windows.Forms.Button SaveSubjbtn;
        private System.Windows.Forms.TextBox pidTB;
        private System.Windows.Forms.Label Parishlbl;
        private System.Windows.Forms.Label parishIDlbl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox ParishLB;
    }
}