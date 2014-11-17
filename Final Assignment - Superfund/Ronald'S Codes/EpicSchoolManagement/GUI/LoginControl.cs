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
    public partial class LoginControl : Form
    {
        SchoolsEntities Db = new SchoolsEntities();

        public int userID;
        public String accessType;
        public String school;
        public String password;
        //public int districtCode;

        public LoginControl()
        {
            InitializeComponent();
            
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            userNameTB.Focus();
            ToolTips();
            this.TopMost = true;
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
            //Db.Users.Join.Db.Students;  
            
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
                if (userNameTB.Text == "" || passwordTB.Text =="")
                {
                    MessageBox.Show("one or more fields are empty. \nPlease enter the correct details in all fields.", "Login Failed");
                    userNameTB.Focus();
                    cancelBT.Visible = true;
                    forgetPasswordLLb.Visible = true;
                    return;
                }
                else
                {

                    cancelBT.Visible = false;
                    forgetPasswordLLb.Visible = false;
                //accessID = //Convert.ToInt32(accessTypeCB.SelectedValue); //Gets access Type ID from Combobox
                //schools = Convert.ToInt32(schoolsCB.SelectedValue);     //Gets School Code from Combobox

                var LoginUser = Db.Users.FirstOrDefault(u => u.Username == userNameTB.Text && u.Password == passwordTB.Text);
                if (LoginUser != null)
                {                    
                    GetAccessType();
                    GetUserID();
                    //GetSchool();
                    password = passwordTB.Text;
                    this.Hide();                                                                            //Hides Login form
                    MainMenuMDIParent main = new MainMenuMDIParent(userID, accessType, school, password);             //Holds int values                        
                    main.RefTofrmLoginForm = this;                                                          //use to remember the info in this form before going to the next form
                    main.loginNametoolStripStatusLB.Text = userNameTB.Text;                                 //Passes User Login Name to Main Menu                           
                    main.Show();                                                                            //Shows Main Menu  
                                                                                                                                                      
                }

                else if (LoginUser == null)
                {
                    MessageBox.Show("You have entered  one or more fields incorrectly. \nPlease enter the correct details.", "Login Failed");
                    cancelBT.Visible = true;
                    forgetPasswordLLb.Visible = true;
                    return;
                }
                else
                    MessageBox.Show("You have entered an User Name or Password that doesn't exists. \nPlease try again and enter the correct details.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        

       

        //private void CheckTextBoxEmpty()
        //{
        //    if (userNameTB.Text.Trim() == "" || passwordTB.Text.Trim() =="")
        //    {
        //        MessageBox.Show("one or more fields are empty. \nPlease enter the correct details in all fields.", "Login Failed");
        //        userNameTB.Focus();
        //        return;
        //    }
        //}
        
        private string GetAccessType()
        {            
            var user  = Db.Users.SingleOrDefault(u => u.Username == userNameTB.Text);
            accessType = user.AccessType;
            return accessType;                 
            
        } 
        
        private int GetUserID()
        {
            var user = Db.Users.SingleOrDefault(u => u.Username == userNameTB.Text);
            userID = user.UserID;
            return userID;      
        }
        public int SchoolCode;
        private string GetSchool()
        {
            
            var schCode = Db.Students.SingleOrDefault(s => s.UserID == userID);
            SchoolCode = schCode.UserID;

            //var Sch = Db.Schools.SingleOrDefault(s => s.SchoolName == SchoolCode);
            //school = schCode.UserID;
            return school;  
            
        }

        //private int GetSchool(int UserID, int SchoolID)
        //{
        //    User user = Db.Users.SingleOrDefault(u => u.Username == userNameTB.Text);
        //    SchoolID = user.UserID;
        //    return SchoolID;
        //}

        private void forgetPasswordLLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetPassword FP = new forgetPassword();
            FP.Show();
        } 



    }
}
