using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EpicSchoolManagement.DataLayer;

namespace EpicSchoolManagement
{
    public partial class frmlogin : System.Windows.Forms.Form
    {
        SchoolsEntities Db = new SchoolsEntities();

        public int accessID;
        public int schools;
        public int districtCode;
               

        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {       
            usernameTB.Focus();
            ToolTips();
            CBDataSources();
        }


 /// <summary>Check if TextBoxes Empty Shows error flag
/// 
/// </summary>
        private void CheckTextBoxEmpty()
        {
            if (usernameTB.Text == "" && passwordTB.Text == "")
            {
                label5.Show();
                label6.Show();
                MessageBox.Show("Please Enter all Fields. \n", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (usernameTB.Text == "")
            {
                label6.Hide();
                label5.Show();
                MessageBox.Show("Please Enter Valid User Name. \n", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (passwordTB.Text == "")
            {
                label5.Hide();
                label6.Show();
                MessageBox.Show("Please Enter Valid Password. \n", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (usernameTB.Text != "" && passwordTB.Text != "")
            {
                label5.Hide();
                label6.Hide();
            }
        }
     

/// <summary> Show Tool Tips When click on text boxes
///
/// </summary>                   
        private void ToolTips()
        {
            //Initialize tool tip message when mouse hover's over textboxs
            ToolTip TP = new ToolTip();
            TP.ShowAlways = true;
            TP.SetToolTip(usernameTB, "Please Enter User Name");
            TP.SetToolTip(passwordTB, "Please Enter User Password");
            TP.SetToolTip(accessTypeCB, "Please Select Appropriate Access Type");
            TP.SetToolTip(schoolsCB, "Please Select Appropriate School");
        } 
      
     
/// <summary>Data sources for combo boxes
/// 
/// </summary>
        private void CBDataSources()                                    
        {
            this.accessTypeCB.DataSource = Db.UserRoles.ToList();
            this.accessTypeCB.DisplayMember = "AccessType";
            this.accessTypeCB.ValueMember = "AccessID";

            this.schoolsCB.DataSource = Db.Schools.ToList();
            this.schoolsCB.DisplayMember = "SchoolName";
            this.schoolsCB.ValueMember = "SchoolCode";

        }

        private void cancelBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTextBoxEmpty();

                accessID = Convert.ToInt32(accessTypeCB.SelectedValue); //Gets access Type ID from Combobox
                schools = Convert.ToInt32(schoolsCB.SelectedValue);     //Gets School Code from Combobox

                var LoginUser = Db.Users.FirstOrDefault(u => u.Username == usernameTB.Text && u.Password == passwordTB.Text && u.AccessID == accessID && u.SchoolCode == schools);
                if (LoginUser != null)
                {
                    this.Hide();                                                                            //Hides Login form
                    MainMenuMDIParent main = new MainMenuMDIParent(districtCode, schools, accessID);        //Holds int values                        
                    main.RefTofrmLoginForm = this;                                                          //use to remember the info in this form before going to the next form
                    main.loginNametoolStripStatusLB.Text = usernameTB.Text;                                //Passes User Login Name to Main Menu                           
                    main.Show();                                                                            //Shows Main Menu  

                                                                        
                       
                    //Ws.MdiParent = this;                                                                    //set parent form for the child window
                    //count++;                                                                                //increment the child form count
                    //Ws.Text = "Child - " + count.ToString();                                                //set the title of the child window.
                    //Ws.Show();                                                                              //Display the child windowShows Welcome Screen inside of Main Menu                                                                           
                }

                else if (LoginUser == null)
                {
                    MessageBox.Show("You have entered  one or more fields incorrectly. \nPlease enter the correct details.", "Login Failed");
                }
                else
                    MessageBox.Show("You have entered an username that doesn't exists. \nPlease try again and enter the correct details.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forgetPasswordLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetPassword FP = new forgetPassword();
            FP.Show();
        }

        private void passwordTB_Enter(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //if (e.KeyValue == 13)
            //{
            //   // LoginButton_Click(object sender, EventArgs e);  
            //}
        }

        
    }
}
