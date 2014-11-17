using EpicSchoolManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicSchoolManagement
{
    public partial class reLogin : Form
    {
         SchoolsEntities Db = new SchoolsEntities();
         public int UserID;
         public String AccessType;
         public String School;
         
        public reLogin()
        {
            InitializeComponent();
            this.Enabled = true;
            GetPassword();
            GetUserName();
        }

        private String GetPassword()
        {
               
            User user  = Db.Users.SingleOrDefault(u => u.Username == userNameTB.Text);
            Password = user.Password;
            return Password;                 
            
        }

        private String GetUserName()
        {
            User user = Db.Users.SingleOrDefault(u => u.Username == userNameTB.Text);
            Username = user.Username;            
            return Username;            
        }

        private void reLogin_Load(object sender, EventArgs e)
        {
        
        }

        

        /// <summary> Show Tool Tips When click on text boxes
        ///
        /// </summary>                   
        private void ToolTips()
        {
            //Initialize tool tip message when mouse hover's over textboxs
            ToolTip TP = new ToolTip();
            TP.ShowAlways = true;
            TP.SetToolTip(userNameTB, "Please Enter User Name");
            TP.SetToolTip(passwordTB, "Please Enter User Password");
       }

        private void cancelBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void LoginBT_Click(object sender, EventArgs e)
        {
            try
            {
                //CheckTextBoxEmpty();
                if (userNameTB.Text == "" || passwordTB.Text == "")
                {
                    MessageBox.Show("one or more fields are empty. \nPlease enter the correct details in all fields.", "Login Failed");
                    userNameTB.Focus();
                    return;
                }
                if (userNameTB.Text == "username" && passwordTB.Text == "password")
                {
                   this.Hide();
                }
                else
                {
                    //MainMenuMDIParent main = new MainMenuMDIParent();
                    //main
                     
                    
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginBT_MouseClick(object sender, MouseEventArgs e)
        {

        }



       

        public string Username { get; set; }

        public string Password { get; set; }
    }
}