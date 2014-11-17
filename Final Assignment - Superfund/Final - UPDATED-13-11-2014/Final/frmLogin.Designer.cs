namespace Final
{
    partial class frmLogin
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
            this.userloginGB = new System.Windows.Forms.GroupBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.accesstypeCB = new System.Windows.Forms.ComboBox();
            this.accesstypelbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.userloginGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // userloginGB
            // 
            this.userloginGB.Controls.Add(this.usernameTB);
            this.userloginGB.Controls.Add(this.passwordTB);
            this.userloginGB.Controls.Add(this.accesstypeCB);
            this.userloginGB.Controls.Add(this.accesstypelbl);
            this.userloginGB.Controls.Add(this.passwordlbl);
            this.userloginGB.Controls.Add(this.usernamelbl);
            this.userloginGB.Location = new System.Drawing.Point(65, 34);
            this.userloginGB.Name = "userloginGB";
            this.userloginGB.Size = new System.Drawing.Size(317, 155);
            this.userloginGB.TabIndex = 11;
            this.userloginGB.TabStop = false;
            this.userloginGB.Text = "User Login";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(101, 27);
            this.usernameTB.MaxLength = 30;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(210, 20);
            this.usernameTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(101, 65);
            this.passwordTB.MaxLength = 12;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(210, 20);
            this.passwordTB.TabIndex = 2;
            // 
            // accesstypeCB
            // 
            this.accesstypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accesstypeCB.FormattingEnabled = true;
            this.accesstypeCB.Location = new System.Drawing.Point(101, 108);
            this.accesstypeCB.Name = "accesstypeCB";
            this.accesstypeCB.Size = new System.Drawing.Size(210, 21);
            this.accesstypeCB.TabIndex = 3;
            // 
            // accesstypelbl
            // 
            this.accesstypelbl.AutoSize = true;
            this.accesstypelbl.Location = new System.Drawing.Point(22, 111);
            this.accesstypelbl.Name = "accesstypelbl";
            this.accesstypelbl.Size = new System.Drawing.Size(72, 13);
            this.accesstypelbl.TabIndex = 8;
            this.accesstypelbl.Text = "AccessType: ";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(22, 72);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(59, 13);
            this.passwordlbl.TabIndex = 7;
            this.passwordlbl.Text = "Password: ";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Location = new System.Drawing.Point(20, 34);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(61, 13);
            this.usernamelbl.TabIndex = 6;
            this.usernamelbl.Text = "Username: ";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(262, 195);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 30);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(132, 195);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 30);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 262);
            this.Controls.Add(this.userloginGB);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.loginbtn);
            this.Name = "frmLogin";
            this.Text = "EPIC - Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.userloginGB.ResumeLayout(false);
            this.userloginGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userloginGB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.ComboBox accesstypeCB;
        private System.Windows.Forms.Label accesstypelbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button loginbtn;
    }
}

