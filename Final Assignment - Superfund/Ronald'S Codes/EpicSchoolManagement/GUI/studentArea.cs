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
using System.Text.RegularExpressions;
using System.Threading;

namespace EpicSchoolManagement
{
    public partial class studentArea : System.Windows.Forms.Form
    {
        //SchoolsEntities Db = new SchoolsEntities();
       //public int districtCode;
       // public int schools;
       // public int accessID;
        public int Val = 0; 

        public studentArea()
        {
            
            
            InitializeComponent();

           
            
        }

        

       /// <summary>Hide's three tabs and displays Student tab only when form loads
       /// 
       /// </summary>       
        private void studentArea_Load(object sender, EventArgs e)
        {
            ShowTab1();
            HideTab2();
            HideTab3();
            HideTab4();
            //this.StudentAccTabControl.TabPages.Remove(this.ParentTabPage);
            this.StudentAccTabControl.TabPages.Remove(this.GradeBookTabPage);
            this.StudentAccTabControl.TabPages.Remove(this.ReportTabPage);

        }


        #region TabControls
        
        

        public void HideTab3()
        {
            GradeBookTabPage.Enabled = false;
            GradeBookTabPage.Visible = false;
        }

        public void ShowTab3()
        {
            GradeBookTabPage.Enabled = false;
            GradeBookTabPage.Visible = false;
            this.StudentAccTabControl.TabPages.Add(this.GradeBookTabPage);
        }

        public void HideTab4()
        {
            ReportTabPage.Enabled = false;
            ReportTabPage.Visible = false;
        }
        public void ShowTab4()
        {
            ReportTabPage.Enabled = false;
            ReportTabPage.Visible = false;
            this.StudentAccTabControl.TabPages.Add(this.ReportTabPage);
        }

        public void HideTab1()
        {
           StudentTabPage.Enabled = false;
           StudentTabPage.Visible = false;
           this.StudentAccTabControl.TabPages.Remove(this.StudentTabPage);
        }
        public void HideTab2()
        {
            ParentTabPage.Enabled = false;
            ParentTabPage.Visible = false;
            this.StudentAccTabControl.TabPages.Remove(this.ParentTabPage);
        }

        public void ShowTab1()
        { 
            //this.StudentAccTabControl.TabPages.Add(this.StudentTabPage);
            StudentTabPage.Enabled = true;
            StudentTabPage.Visible = true;
           
        }
        public void ShowTab2()
        {
            ParentTabPage.Enabled = true;
            ParentTabPage.Visible = true;
            this.StudentAccTabControl.TabPages.Add(this.ParentTabPage);
        }


        private void nextBT_Click(object sender, EventArgs e)
        {
            HideTab1();
            ShowTab2();
        }

        #endregion

        #region Save, Edit & Delete Buttons

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        

        private void cancelBT_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }
        #endregion
        

        
        #region Page Navigation Buttons
        private void backToStudentBT_Click(object sender, EventArgs e)
        {
            HideTab2();                                                     //Custom Method Hide Parent Tab
            this.StudentAccTabControl.TabPages.Add(this.StudentTabPage);    //Custom Method Add's Student Tab Control
            ShowTab1();                                                     //Custom Method Shows Student Tab
        }

        
        private void nextToParentBT_Click(object sender, EventArgs e)
        {
            
            ValidateStudentTextValues();
            if (Val == 1)
            {
                //nextToParentBT.Enabled = true;
            HideTab1();                                                     //Custom Method Hide Student Tab
            ShowTab2();
            }

            else if (Val == 0)
            {
                //nextToParentBT.Enabled = false;
                return;
            }
                                                //Validate Student Text Values before moving to parent area
                                                                 ////Custom Method Show's Parent Tab
        }
        #endregion
             
        #region Validate before Save 
        
        ///
       
       
        public  void ValidateStudentTextValues()
        {
            // ensures TextBoxes are not empty
            if (
                sfNameTB.Text == "" ||
                slNameTB.Text == "" ||
                priorEdTB.Text == "" ||
                formTB.Text == ""
                )
            {
                MessageBox.Show("Please ensure all fields are filled", "Error");                   // Empty textbox displays Error popup box
                fNameTB.Focus();                                                                    // set focus to lastNameTextBox
                Val = 0;
                return;
            }
            else
            {
                Val = 1;
            }
           
            

                // if (!Regex.Match(sfNameTB.Text, "^[a-zA-Z''-'\\s]{1,50}$").Success)                      // if first name format invalid show message; Validates a name. Allows up to 40 uppercase and lowercase characters and a few special characters that are common to some names. You can modify this list
                //{                                                                                       // eg.John Doe O'Dell                                                                                               
                //    label7.Visible = true;
                //    MessageBox.Show("Invalid First name");
                //    fNameTB.Focus();
                //    return;
                //}
                //else if (!Regex.Match(slNameTB.Text, "^[a-zA-Z''-'\\s]{1,50}$").Success)   //^([A-Z]|[a-z])+$                     
                //{
                //    label8.Visible = true;
                //    MessageBox.Show("Invalid Last name");
                //    lNameTB.Focus();
                //    return ;
                //}
                //else
                //{
                    
                //    Val = 1; 
                //}
             
            
            

        }

        //Validates All TextBoxe Values and ensures TextBoxes are not empty
        //Method Used To Validate before Save 
        private void ValidateParentTextValues()
        {
            // ensures TextBoxes are not empty
            if (
                fNameTB.Text == "" ||
                lNameTB.Text == "" ||
                relationshipTB.Text == "" ||
                villageTB.Text == "" ||
                parishTB.Text == "" ||
                homeMaskedTB.Text == "" ||
                workMaskedTB.Text == "" ||
                cellMaskedTB.Text == "" ||
                emailTB.Text == ""
                )
            {
                MessageBox.Show("Please ensure all fields are filled", "Error");                   // Empty textbox displays Error popup box
                fNameTB.Focus();                                                                    // set focus to lastNameTextBox
                return;                                                                             // Return to FNameTextBox
            }
            else
            {
                ResetFlags();
                if (!Regex.Match(fNameTB.Text, "^[a-zA-Z''-'\\s]{1,50}$").Success)                      // if first name format invalid show message; Validates a name. Allows up to 40 uppercase and lowercase characters and a few special characters that are common to some names. You can modify this list
                {                                                                                       // eg.John Doe O'Dell                                                                                               
                    label7.Visible = true;
                    MessageBox.Show("Invalid First name");
                    fNameTB.Focus();
                    return;
                }
                if (!Regex.Match(lNameTB.Text, "^[a-zA-Z''-'\\s]{1,50}$").Success)   //^([A-Z]|[a-z])+$                     
                {
                    label8.Visible = true;
                    MessageBox.Show("Invalid Last name");
                    lNameTB.Focus();
                    return;
                }
                if (!Regex.Match(relationshipTB.Text, @"^[a-zA-Z0-9]{1,10}@[a-zA-Z]{1,10}.(com|org)$").Success)                       //Email can start with alphanumeric with minimum 1 character and maximum 10 character. , followed by at the rate (@)                     
                {                                                                                                                   //The domain name after the @ can be alphanumeric with minimum 1 character and maximum 10 character , followed by a “.”
                    label9.Visible = true;                                                                                         //should end with .com or .org
                    MessageBox.Show("Invalid Email Address");
                    relationshipTB.Focus();
                    return;
                }
                if (!Regex.Match(villageTB.Text, @"^[a-zA-Z0-9]{1,10}@[a-zA-Z]{1,10}.(com|org)$").Success)                       //Email can start with alphanumeric with minimum 1 character and maximum 10 character. , followed by at the rate (@)                     
                {                                                                                                                   //The domain name after the @ can be alphanumeric with minimum 1 character and maximum 10 character , followed by a “.”
                    label10.Visible = true;                                                                                         //should end with .com or .org
                    MessageBox.Show("Invalid Email Address");
                    villageTB.Focus();
                    return;
                }
                if (!Regex.Match(parishTB.Text, @"^[a-zA-Z0-9]{1,10}@[a-zA-Z]{1,10}.(com|org)$").Success)                       //Email can start with alphanumeric with minimum 1 character and maximum 10 character. , followed by at the rate (@)                     
                {                                                                                                                   //The domain name after the @ can be alphanumeric with minimum 1 character and maximum 10 character , followed by a “.”
                    label11.Visible = true;                                                                                         //should end with .com or .org
                    MessageBox.Show("Invalid Email Address");
                    parishTB.Focus();
                    return;
                }
                if (!Regex.Match(homeMaskedTB.Text, @"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$").Success)  //Validates a U.S. phone number. It must consist of 3 numeric characters, optionally enclosed in parentheses, followed by a set of 3 numeric characters and then a set of 4 numeric characters.                       
                {                                                                                                                   //(425) 555-0123 425-555-0123 425 555 0123 1-425-555-0123
                    label12.Visible = true;
                    MessageBox.Show("Invalid Phone Number");
                    cellMaskedTB.Focus();
                    return;
                }

                if (!Regex.Match(workMaskedTB.Text, @"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$").Success)  //Validates a U.S. phone number. It must consist of 3 numeric characters, optionally enclosed in parentheses, followed by a set of 3 numeric characters and then a set of 4 numeric characters.                       
                {                                                                                                                   //(425) 555-0123 425-555-0123 425 555 0123 1-425-555-0123
                    label13.Visible = true;
                    MessageBox.Show("Invalid Phone Number");
                    homeMaskedTB.Focus();
                    return;
                }

                if (!Regex.Match(cellMaskedTB.Text, @"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$").Success)  //Validates a U.S. phone number. It must consist of 3 numeric characters, optionally enclosed in parentheses, followed by a set of 3 numeric characters and then a set of 4 numeric characters.                       
                {                                                                                                                   //(425) 555-0123 425-555-0123 425 555 0123 1-425-555-0123
                    
                    MessageBox.Show("Invalid Phone Number");
                    cellMaskedTB.Focus();
                    return;
                }
                if (!Regex.Match(emailTB.Text, @"^[a-zA-Z0-9]{1,10}@[a-zA-Z]{1,10}.(com|org)$").Success)                       //Email can start with alphanumeric with minimum 1 character and maximum 10 character. , followed by at the rate (@)                     
                {                                                                                                                   //The domain name after the @ can be alphanumeric with minimum 1 character and maximum 10 character , followed by a “.”
                                                                                                             //should end with .com or .org
                    MessageBox.Show("Invalid Email Address");
                    emailTB.Focus();
                    return;
                }

                //else 
            }
            // end 1St if 
            
            

            

        }

                
        #endregion

        #region Clears and resets text boxes
        private void ClearTB()
        {
            fNameTB.Clear();
            lNameTB.Clear();
            relationshipTB.Clear();
            villageTB.Clear();
            parishTB.Clear();
            homeMaskedTB.Clear();
            workMaskedTB.Clear();
            cellMaskedTB.Clear();
            emailTB.Clear();
        }

        //Reset Error Flags "*"
        private void ResetFlags()
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            
        }
        #endregion

    }
}
