/*
************************************************************************************************************************************
*** Created                                                                                                                      ***
*** By Ronald Marcelle -						                                                                                 ***
*** http://www.ronaldmarcelle@gmail.com                                                                                          ***
*** 13/10/2014                                                                                                                   ***
*** Last Modified ++++++++++++++++                                                                                               ***
************************************************************************************************************************************
*/

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
using System.Threading;
using System.Diagnostics;

namespace EpicSchoolManagement
{
    public partial class MainMenuMDIParent : System.Windows.Forms.Form 
    {
        private int childFormNumber = 0;

        public System.Windows.Forms.Form RefTofrmLoginForm { get; set; }

        SchoolsEntities Db = new SchoolsEntities();
        WelcomeScreen Wel = new WelcomeScreen();
        studentArea Sta = new studentArea();
        ActivityMonitor.IdelTimer iTimer = new ActivityMonitor.IdelTimer();
        
        //frmParentProfile PF = new frmParentProfile(); 

        LoginControl Log = new LoginControl();

        public int userID;
        public String accessType;
        public String school;
        public String password;
        public const int TIME1 = 5;
        public const int secondIncrement = 1;


        public MainMenuMDIParent(int userID, String accessType, String school, string password)
        {       
            //Thread t = new Thread(new ThreadStart(frmloading));
            //t.Start();
            //Thread.Sleep(6000); 
        
            InitializeComponent();                             

            LoadWelcomeScr();                                           //Loads Welcome Screen

            AddTempUser(userID,  accessType, school, password);

            if (accessType == "Administrator")                            //"SystemAdministrator"
            {
                registrationToolStripMenuItem.Visible = true;
                studentToolStripMenuItem.Visible = true;
                parentToolStripMenuItem.Visible = true;
                principalToolStripMenuItem.Visible = true;
                teacherToolStripMenuItem.Visible = true;
                administratorsToolStripMenuItem.Visible = true;


            }
            else if (accessType == "District Administrator")                     //"DistrictAdministrator"
            {
                registrationToolStripMenuItem.Visible = true;
                studentToolStripMenuItem.Visible = true;
                parentToolStripMenuItem.Visible = true;
                principalToolStripMenuItem.Visible = true;
                teacherToolStripMenuItem.Visible = true;
                administratorsToolStripMenuItem.Visible = false;
            }
            else if (accessType == "Principal")                      //"Principal"
            {
                registrationToolStripMenuItem.Visible = false;
                studentToolStripMenuItem.Visible = true;
                parentToolStripMenuItem.Visible = true;
                principalToolStripMenuItem.Visible = true;
                administratorsToolStripMenuItem.Visible = false;
                
            }
            else if (accessType == "Administrative Staff")                       //"Administrative Staff"
            {
                registrationToolStripMenuItem.Visible = true;
                studentToolStripMenuItem.Visible = true;
                parentToolStripMenuItem.Visible = true;
                principalToolStripMenuItem.Visible = false;
                teacherToolStripMenuItem.Visible = true;
                administratorsToolStripMenuItem.Visible = false;
            }
            else if (accessType == "Teacher")                          //"teacher"
            {
                registrationToolStripMenuItem.Visible = false;
                studentToolStripMenuItem.Visible = true;
                parentToolStripMenuItem.Visible = false;
                principalToolStripMenuItem.Visible = false;
                teacherToolStripMenuItem.Visible = true;
                administratorsToolStripMenuItem.Visible = false;
            }
            else if (accessType == "Parent")                          //"parent"
            {
                registrationToolStripMenuItem.Visible = false;
                studentToolStripMenuItem.Visible = true;
                parentToolStripMenuItem.Visible = true;
                principalToolStripMenuItem.Visible = false;
                teacherToolStripMenuItem.Visible = false;
                administratorsToolStripMenuItem.Visible = false;
            }
            else if (accessType == "Student")                          //"student"
            {
                registrationToolStripMenuItem.Visible = false;
                studentToolStripMenuItem.Visible = true;
                parentToolStripMenuItem.Visible = false;
                principalToolStripMenuItem.Visible = false;
                teacherToolStripMenuItem.Visible = false;
                administratorsToolStripMenuItem.Visible = false;
            }
            else if (accessType == "Guest")                          //"Guest"
            {
                registrationToolStripMenuItem.Visible = false;
                studentToolStripMenuItem.Visible = false;
                parentToolStripMenuItem.Visible = false;
                principalToolStripMenuItem.Visible = false;
                teacherToolStripMenuItem.Visible = false;
                administratorsToolStripMenuItem.Visible = false;
            }

            //t.Abort();

        }

        private void frmloading()
        {
            Application.Run(new frmLoading());
        }

        private void MainMenuMDIParent_Load(object sender, EventArgs e)
        {
            //Passes User Login Name to Welcome Screen
            Wel.loginNameLB.Text = loginNametoolStripStatusLB.Text;
            
         
        }




        private void AddTempUser(int UserID, String AccessType, String schools, string password)
        {
            //Create a login user based on the user's entries
            Tempuser newTempuserToAdd = new Tempuser();
            newTempuserToAdd.TmpuserID = 1;
            newTempuserToAdd.UserID = userID;
            newTempuserToAdd.Password = password;
            newTempuserToAdd.Accesstype = accessType;
            newTempuserToAdd.School = school;

            //store the newly login user in TempUserDB
            TempUserDB.Tempusers.Add(newTempuserToAdd);
                        
        }
        #region Idail Monitor

        //private void countdownTimer_Tick(object sender, EventArgs e)
        //{
        //    countdownTimer.Interval = 1000 * secondIncrement;
        //    countdownTimer.Enabled = true;
        //    countdownTimer.Start();
        //    countdownTimerLB.Visible = true;
        //    countdownTimerLB.Text = countdownTimer.ToString();
        //}
        //private void timerStart()
        //{
        //   countdownTimer.Interval = 1000 * secondIncrement;
        //   countdownTimer.Enabled = true;
        //   countdownTimer.Start();
        //   countdownTimerLB.Visible = true;
        //   countdownTimerLB.Text = countdownTimer.ToString();
        //}
        #endregion

        #region Windows Menu             

        private void ShowNewForm(object sender, EventArgs e)
        {
            System.Windows.Forms.Form childForm = new System.Windows.Forms.Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

       
        #endregion
        
        #region Statusbar Controls 

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        #endregion                       

        #region Registration ToolStrip Menu Items

        /// <summary>Student Area
        /// Loads Student area form as child form in MDI parent form
        /// Enables buttons to be enabled in order to save and navigate in form
        /// </summary>
        private void RegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sta.MdiParent = this;
            Sta.Text = "New Student Registration";                                                     
            Sta.Show();
            Sta.backToStudentBT.Visible = true;
            Sta.nextToParentBT.Visible = true;
            Sta.saveAllBT.Visible = true;
        }

        private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersArea TA = new TeachersArea();
            TA.Show();
        }

        private void newPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        


        #endregion

        #region Help ToolStrip Menu Item
        
        
        private void contactSystemAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
                          
            SendMail.SendEmail mail = new SendMail.SendEmail();
            mail.MdiParent = this;
            mail.Text = "Contact System Administrator" + childFormNumber++;
            mail.sendToTB.Text = "epic_school_management_sysadmin@gamil.com";
            mail.Show();
            
         }

        #endregion
        
        #region Exit Tool Strip Menu Items
                
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            this.Hide();
            Log.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }


        #endregion

        #region Tools Tool Strip Menu Item
        
        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void setDateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("timedate.cpl");
            Process.Start(System.Environment.SystemDirectory + @"\TimeDate.cpl");
        }


        private void configureMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMail.MailConfig con = new SendMail.MailConfig();
            var UserPrivllage = TempUserDB.Tempusers.FirstOrDefault(u => u.Accesstype == "Administrator" && u.School == "");
            if (UserPrivllage != null)
            {
                con.MdiParent = this;
                con.Text = "Contact System Administrator - " + childFormNumber++;
                con.Show();
            }
            else
            {
                MessageBox.Show("Access Denied");
            }
        }

        #endregion
        
        #region Welcome Screen Show/Hide

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (WelcomHideShowtoolStripMenuItem.Checked != true)
            {
                Wel.Hide();
            }
            else if (WelcomHideShowtoolStripMenuItem.Checked == true)
            {
                Wel.Show();
            }
            
        }
        /// <summary>Method used to load welcome Screen when parent is loaded
        /// 
        /// </summary>
        private void LoadWelcomeScr()
        {
            Thread t = new Thread(new ThreadStart(WelcomeScreen));
            t.Start();
            Thread.Sleep(3000);
            //t.Abort();
            
        }

        private void WelcomeScreen()
        {
            //Application.Run(new WelcomeScreen());
            Wel.MdiParent = this;
            Wel.Text = "Epic School Management"; // +childFormNumber++;                                                      
            Wel.Show();
        }
        #endregion

        #region Administrators Tool Strip Menu Items		 
	
        private void newDistrictAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administratorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrativeStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void districtAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void systemAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        #endregion

        private void screenSaverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Enabled = false;
            //this.Hide();
            ScreenSaver svr = new ScreenSaver();
            svr.Show();
            
        }

        private Point mouseLocation;

        private void MainMenuMDIParent_MouseMove(object sender, MouseEventArgs e)
        {
            ActivityMonitor.IdelTimer iTimer = new ActivityMonitor.IdelTimer();
            if (!mouseLocation.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocation.X - e.X) > 5 || Math.Abs(mouseLocation.Y - e.Y) > 5)

                    ResetIdelTimer();
            }

            // Update current mouse location
            mouseLocation = e.Location; 
        }

        private void ResetIdelTimer()
        {
            ActivityMonitor.IdelTimer iTimer = new ActivityMonitor.IdelTimer();
            iTimer.countdownTimer.Stop();
            iTimer.Hide();
            Cursor.Show();
        }

        private void MainMenuMDIParent_MouseClick(object sender, MouseEventArgs e)
        {
            ResetIdelTimer();
        }

        private void MainMenuMDIParent_KeyPress(object sender, KeyPressEventArgs e)
        {
            ResetIdelTimer();
        }

        private void testTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityMonitor.IdelTimer iTimer = new ActivityMonitor.IdelTimer();
            
            iTimer.Show();
            
        }

        private void studentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Sta.Text == 1)
            //{
                
            //}         
            Sta.MdiParent = this;
            Sta.Text = "New Student Profile - " + childFormNumber++;
            Sta.backToStudentBT.Visible = true;
            Sta.nextToParentBT.Visible = true;
            Sta.saveAllBT.Visible = false;
            Sta.Show();
        }

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectClassToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        

        
        
        
    }
}
