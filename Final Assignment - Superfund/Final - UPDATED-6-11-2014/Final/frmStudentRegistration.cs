using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Final
{
    public partial class frmStudentRegistration : Form
    {
        public const string pattern = @"^\w[a-z,A-Z]+$";
        public const string spattern = @"^[A-Za-z0-9\s\.\'\,]+$";
        public const string epattern = @"^(([\w\.\d\-]+)@(\w\D+))$";
        public const string ppattern = @"^((?:\+\d{1})?\d{3}?-?\d{3}-\d{4})$";

        int ID;
        string result;

        SchoolsEntities db = new SchoolsEntities();
        int sID, pID, spID, suID;
        string dftpass ="password";
        string acctyp;
        
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            Loadfrm();
            
        }

        private void Loadfrm()
        {
            formCB.DataSource = db.SchoolForms.Distinct().ToList();
            formCB.DisplayMember = "FormName";
            formCB.ValueMember = "FormID";
            formCB.SelectedIndex = -1;

            sID = db.Students.Max(m => m.StudentID) + 1;
            StudentIDTB.ReadOnly = true;
            StudentIDTB.Text = sID.ToString();

            parentdetailGB.Visible = false;

            relationshipCB.DataSource = db.StudentsParents.Select(x => x.Relationship).Distinct().ToList();
            relationshipCB.DisplayMember = "Relationship";
            relationshipCB.SelectedIndex = -1;

            VillageCB.DataSource = db.Villages.Distinct().ToList();
            VillageCB.DisplayMember = "VillageName";
            VillageCB.ValueMember = "VillageID";
            VillageCB.SelectedIndex = -1;

            ParishCB.DataSource = db.Parishes.Distinct().ToList();
            ParishCB.DisplayMember = "ParishName";
            ParishCB.ValueMember = "ParishID";
            ParishCB.SelectedIndex = -1;

            schoolsCB.DataSource = db.Schools.Distinct().ToList();
            schoolsCB.DisplayMember = "SchoolName";
            schoolsCB.ValueMember = "SchoolCode";
            schoolsCB.SelectedIndex = -1;

        }

        private void addparentbtn_Click(object sender, EventArgs e)
        {
            addparentbtn.Enabled = false; 

            parentdetailGB.Visible = true;
            pID = db.Parents.Max(m => m.ParentID) + 1;
            pidTB.Text = pID.ToString();
            pidTB.ReadOnly = true;

            spID = db.StudentsParents.Max(m => m.StudentParentsID) + 1;
        }
        
        private void generatepLogin(int ID, string fn, string ln, DateTime dob, string email, string pass, string at)
        {       
            User newUser = new User
            {
                UserID = ID,
                FirstName = fn,
                LastName = ln,
                Username = fn.ToLower() + "." + ln.ToLower() + "." + dob.Day + dob.Month,
                Password = pass,
                AccessType = at,
                Email = email
            };

            db.Users.Add(newUser);
            //db.SaveChanges();

            MessageBox.Show("New Login Details:" + "\n\n" + "Username: " + newUser.Username + "\n" + "Password:  " + newUser.Password);
        }
        
        private void saveparent()
        {
            
            Parent newParent = new Parent
            {
                ParentID = Convert.ToInt32(pidTB.Text),
                PFirstName = pfirstnameTB.Text,
                MiddleInitial = MITB.Text,
                PLastName = plastnameTB.Text,
                HomePhone = shomepTB.Text,
                CellPhone = pcellTB.Text,
                WorkPhone = pworkTB.Text,
                DOB = Convert.ToDateTime(pDOBdatepicker.Text),
                Email = pemailTB.Text,
                UserID = db.Users.Max(m => m.UserID) + 1
            };

            db.Parents.Add(newParent);
            //db.SaveChanges();

            StudentsParent sparent = new StudentsParent
            {

               StudentParentsID = spID,
               ParentID = Convert.ToInt32(pidTB.Text),
               StudentID = Convert.ToInt32(StudentIDTB.Text),
               Relationship = relationshipCB.Text
            };

            db.StudentsParents.Add(sparent);
            //db.SaveChanges();


        }

        private void savestudent()
        {
            Student newStudent = new Student
            {
                StudentID = sID,
                FirstName = sfirstnameTB.Text,
                LastName = slastnameTB.Text,
                DOB = Convert.ToDateTime(dobdatepicker.Text),
                HomePhone = shomepTB.Text,
                AdmissionDate = Convert.ToDateTime(admissiondatetimepicker.Text),
                ExpectedGraduationDate = Convert.ToDateTime(gradedatetimepicker.Text),
                FormID = Convert.ToInt32(formCB.SelectedValue),
                SchoolCode = Convert.ToInt32(schoolsCB.SelectedValue),
                VillageID = Convert.ToInt32(VillageCB.SelectedValue),
                ParishID = Convert.ToInt32(ParishCB.SelectedValue),
                PriorEducation = prioreduTB.Text,
                Email = semailTB.Text,
                UserID = db.Users.Max(m=> m.UserID)+1

            };
            db.Students.Add(newStudent);
            //db.SaveChanges();
          }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            suID = db.Users.Max(m=>m.UserID)+1;

            savestudent();

            acctyp = "Student";
            generatepLogin(suID,sfirstnameTB.Text, slastnameTB.Text, Convert.ToDateTime(dobdatepicker.Text), semailTB.Text, dftpass, acctyp);

        }

        private void addprecBtn_Click(object sender, EventArgs e)
        {
            
            saveparent();

            acctyp = "Parent";
            generatepLogin(pID,pfirstnameTB.Text, plastnameTB.Text, Convert.ToDateTime(pDOBdatepicker.Text), pemailTB.Text, dftpass, acctyp);
        
        }

        private void NewSubbtn_Click(object sender, EventArgs e)
        {
            frmNewSubject newSub = new frmNewSubject();
            newSub.Show();
        }

        private void newParishbtn_Click(object sender, EventArgs e)
        {
            frmNewParish newPar = new frmNewParish();
            newPar.Show();
        }

        private void SaveEntry()
        {
            try
            {




            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Be Saved, {0}" + ex);
            }
            finally
            {
               // RebindGrid();
            }





        }

        private void ValidData()
        {
            MessageBox.Show("Please enter Valid Data");
        }

        private int ValidateID(string id)
        {
            bool passid;
            if ((passid = Int32.TryParse(id, out ID)) == true)
            {
                ID = Convert.ToInt32(id);
            }
            else
            {
                ValidData();
            }

            return ID;

    
        }

        public string ValidateName(string input)
        {

            if (input != null)
            {

                if (Regex.IsMatch(input, pattern) == true)
                {
                    result = input;
                }
                else
                {
                    ValidData();
                }
            }
            else
            {
                ValidData();
                
            }
            return result;
        }

        public string ValidateEmail(string input)
        {
            if (input != null)
            {

                if (Regex.IsMatch(input, epattern) == true)
                {
                    result = input;
                }
                else
                {
                    ValidData();
                    semailTB.Clear();
                    semailTB.Focus();
                }
            }
            else
            {
                semailTB.Clear();
                semailTB.Focus();
            }
            return result;
        }

        public string ValidatePhone(string input)
        {
            if (input != null)
            {

                if (Regex.IsMatch(input, ppattern) == true)
                {
                    result = input;
                }
                else
                {
                    ValidData();
                }
            }
            else
            {
                ValidData();
            }
            return result;
        }

        private void Saved()
        {
            StudentIDTB.ReadOnly = true;
            sfirstnameTB.ReadOnly = true;
            MITB.ReadOnly = true;
            slastnameTB.ReadOnly = true;
            




        }
    
    }
}
