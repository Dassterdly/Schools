using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
namespace Final
{
    public partial class frmStudentAccount : Form
    {
        
        SchoolsEntities db = new SchoolsEntities();
        int uID, sID, studID, subcode, mth;
        string cTerm, yr, Term;
        

        public frmStudentAccount()
        {
            InitializeComponent();
        }

        private void frmStudentAccount_Load(object sender, EventArgs e)
        {
            //Term = findCurrentTerm();
            LoadStudentProfile();
            LoadStudentParents();
            fillcombobox();
            LoadStudentClasses(Convert.ToInt32(TermCB.SelectedValue), AcademicPCB.Text);
            hidecols();
            LoadGradeBook();

        }

        private void hidecols()
        {
            studentclassesGV.Columns["ID"].Visible = false;
            studentclassesGV.Columns["SubjectCode"].Visible = false;
        }

        private void LoadStudentProfile()
        {
            uID = Convert.ToInt32(uIDlbl.Text);

            var qprofile = from s in db.Students
                           join sp in db.StudentsParents on s.StudentID equals sp.StudentID
                           join p in db.Parents on sp.ParentID equals p.ParentID
                           where s.UserID == uID
                           select s;

            foreach (var i in qprofile)
            {
                //loading data into student account tab
                studentidTB.Text = i.StudentID.ToString();
                sID = i.StudentID;
                SfirstnameTB.Text = i.FirstName;
                SlastnameTB.Text = i.LastName;
                dobTB.Text = i.DOB.ToShortDateString();
                AdmissionTB.Text = i.AdmissionDate.ToShortDateString();
                expectgradTB.Text = i.ExpectedGraduationDate.ToString();
                SchoolTB.Text = i.School.ToString();
                FormTB.Text = i.SchoolForm.ToString();
                prioreducTB.Text = i.PriorEducation;
                VillageTB.Text = i.Village.ToString();
                ParishTB.Text = i.Parish.ToString();
                HomePHoneTB.Text = i.HomePhone.ToString();
                EmailTB.Text = i.Email;

                //loading data in student classes tab
                SCStudentTB.Text = i.FirstName + " " + i.LastName;
                SCsklTB.Text = i.School.ToString();
                SCFormTB.Text = i.SchoolForm.ToString();

                //load data into GradeBook tab
                GBStudentNameTB.Text = i.FirstName + " " + i.LastName;
                GBSchoolTB.Text = i.School.ToString();
                GBAdmDateTB.Text = i.AdmissionDate.ToShortDateString();
                GBGradDateTB.Text = i.ExpectedGraduationDate.ToString();
                GBFormTB.Text = i.SchoolForm.ToString();

            }
                  
            
        }

        private void LoadStudentParents()
        {
            var pquery = from s in db.Students
                         join sp in db.StudentsParents on s.StudentID equals sp.StudentID
                         join p in db.Parents on sp.ParentID equals p.ParentID
                         where s.UserID == uID
                         select new { FirstName = p.PFirstName, LastName = p.PLastName, Relationship = sp.Relationship };

            studentparentGridView.DataSource = pquery.ToList();
            
            
        }
        
        private void LoadStudentClasses(int term, string year)
        {
            
            if (TermCB.SelectedIndex == -1 &&  AcademicPCB.SelectedIndex == -1)
            {
                var classquery = from s in db.Students
                                 join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                                 join c in db.Classes on sc.ClassID equals c.ClassID
                                 join t in db.Teachers on c.TeacherID equals t.TeacherID
                                 join f in db.SchoolForms on c.FormID equals f.FormID
                                 where s.UserID == uID 

                                 select new
                                 {
                                     ID = s.StudentID,
                                     ClassID = c.ClassID,
                                     Subject = c.Subject,
                                     SubjectCode = c.SubjectCode,
                                     Lecturer = t.FirstName + " " + t.LastName,
                                     Form = f.FormName,
                                     AcademicTerm = c.Term,
                                     AcademicYear = c.AcademicYear
                                 };

                studentclassesGV.DataSource = classquery.OrderByDescending(x => x.AcademicYear).ToList();
            }

            if (TermCB.SelectedIndex != -1 && AcademicPCB.SelectedIndex == -1)
            {
                var classquery = from s in db.Students
                             join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                             join c in db.Classes on sc.ClassID equals c.ClassID
                             join t in db.Teachers on c.TeacherID equals t.TeacherID
                             join f in db.SchoolForms on c.FormID equals f.FormID
                             where (s.UserID == uID && c.TermID == term && c.AcademicYear == year) ||
                             (s.UserID == uID && c.TermID == term || c.AcademicYear == year)
                             

                             select new
                             {
                                 ID = s.StudentID,
                                 ClassID = c.ClassID,
                                 Subject = c.Subject,
                                 SubjectCode = c.SubjectCode,
                                 Lecturer = t.FirstName + " " + t.LastName,
                                 Form = f.FormName,
                                 AcademicTerm = c.Term,
                                 AcademicYear = c.AcademicYear
                             };

            studentclassesGV.DataSource = classquery.OrderByDescending(x=> x.AcademicYear).ToList();
            }

            if (TermCB.SelectedIndex == -1 && AcademicPCB.SelectedIndex != -1)
            {
                var classquery = from s in db.Students
                                 join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                                 join c in db.Classes on sc.ClassID equals c.ClassID
                                 join t in db.Teachers on c.TeacherID equals t.TeacherID
                                 join f in db.SchoolForms on c.FormID equals f.FormID
                                 where (s.UserID == uID && c.TermID == term && c.AcademicYear == year) ||
                                 (s.UserID == uID && c.AcademicYear == year || c.TermID == term)


                                 select new
                                 {
                                     ID = s.StudentID,
                                     ClassID = c.ClassID,
                                     Subject = c.Subject,
                                     SubjectCode = c.SubjectCode,
                                     Lecturer = t.FirstName + " " + t.LastName,
                                     Form = f.FormName,
                                     AcademicTerm = c.Term,
                                     AcademicYear = c.AcademicYear
                                 };

                studentclassesGV.DataSource = classquery.OrderByDescending(x => x.AcademicYear).ToList();
            }

            if (TermCB.SelectedIndex != -1 && AcademicPCB.SelectedIndex != -1)
            {
                var classquery = from s in db.Students
                                 join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                                 join c in db.Classes on sc.ClassID equals c.ClassID
                                 join t in db.Teachers on c.TeacherID equals t.TeacherID
                                 join f in db.SchoolForms on c.FormID equals f.FormID
                                 where (s.UserID == uID && c.TermID == term && c.AcademicYear == year)


                                 select new
                                 {
                                     ID = s.StudentID,
                                     ClassID = c.ClassID,
                                     Subject = c.Subject,
                                     SubjectCode = c.SubjectCode,
                                     Lecturer = t.FirstName + " " + t.LastName,
                                     Form = f.FormName,
                                     AcademicTerm = c.Term,
                                     AcademicYear = c.AcademicYear
                                 };

                studentclassesGV.DataSource = classquery.OrderByDescending(x => x.AcademicYear).ToList();

                hidecols();
            }

        }

        private void StudentClassesTab_Click(object sender, EventArgs e)
        {
            LoadStudentClasses(Convert.ToInt32(TermCB.SelectedValue), AcademicPCB.Text);
        }
        
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            LoadStudentClasses(Convert.ToInt32(TermCB.SelectedValue), AcademicPCB.Text);
        }

        private void fillcombobox()
        {
            TermCB.DataSource = db.Terms.ToList();
            TermCB.DisplayMember = "TermName";
            TermCB.ValueMember = "TermID";
            TermCB.SelectedIndex = -1;
            
            AcademicPCB.DataSource = db.Classes.Select ( x => x.AcademicYear).Distinct().ToList();
            AcademicPCB.DisplayMember = "AcademicYear";
            AcademicPCB.SelectedIndex = -1;

                       
        }
       
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            fillcombobox();

            this.studentclassesGV.DataSource = null;

            var classquery = from s in db.Students
                             join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                             join c in db.Classes on sc.ClassID equals c.ClassID
                             join t in db.Teachers on c.TeacherID equals t.TeacherID
                             join f in db.SchoolForms on c.FormID equals f.FormID
                             //join cs in db.ClassesSchedules on c.ClassID equals cs.ClassID
                             //join d in db.Days on cs.DayID equals d.DayID
                             where s.UserID == uID

                             select new
                             {
                                 ID = s.StudentID,
                                 ClassID = c.ClassID,
                                 Subject = c.Subject,
                                 SubjectCode = c.SubjectCode,
                                 Lecturer = t.FirstName + " " + t.LastName,
                                 Form = f.FormName,
                                 AcademicTerm = c.Term,
                                 AcademicYear = c.AcademicYear
                             };


            this.studentclassesGV.DataSource = classquery.OrderByDescending(x => x.AcademicYear).ToList();
            
        }

        private void LoadGradeBook()
        {
            GradebookListView.GridLines = true;
            GradebookListView.View = View.Details;


            //column Headers
            GradebookListView.Columns.Add("Subject", 100);
            GradebookListView.Columns.Add("Teacher", 100);
            GradebookListView.Columns.Add("Form", 50);
            GradebookListView.Columns.Add("Term", 100);
            //GradebookListView.Columns.Add("Academic Year", 100);
            GradebookListView.Columns.Add("Grade", 100);

            db.Classes.Load();
            db.StudentClasses.Load();

            var AcademicYears = db.Classes.Local.Select(c => c.AcademicYear).Distinct();
            var StudentClasses = db.StudentClasses.Local.Where(sc=> sc.Student.UserID.ToString() == uIDlbl.Text);


            GradebookListView.Items.Clear();
            AcademicYears.ToList().ForEach(x => 
            { 
                var group = GradebookListView.Groups.Add(new ListViewGroup(x));
                StudentClasses.ToList().ForEach(sc =>
                {
                    var lv = GradebookListView.Items.Add(sc.Class.Subject.SubjectName);
                    lv.SubItems.Add(string.Format("{0} {1}", sc.Class.Teacher.FirstName, sc.Class.Teacher.LastName));
                    lv.SubItems.Add(sc.Class.FormID.ToString());
                    lv.SubItems.Add(sc.Class.Term.TermName);
                    lv.SubItems.Add("Pending");
                    lv.Group = GradebookListView.Groups[group];
                });
            });
            



//ListViewGroup group1 = new ListViewGroup("Group 01");
//ListViewGroup group2= new ListViewGroup("Group 02);
//GradebookListView.Groups.AddRange(new ListViewGroup[] { group1, group2 };
//GradebookListView.Items.Add("item text 01", 0, group1);
//GradebookListView.Items.Add("item text 02, 0, group1);
//GradebookListView.Items.Add("item text 03, 0, group1);

//GradebookListView.Items.Add("item text 04, 0, group2);
//GradebookListView.Items.Add("item text 05, 0, group2);
//GradebookListView.Items.Add("item text 06, 0, group2);


        }
                     
        private void PrintBtn_Click(object sender, EventArgs e)
        {

        }

        private void EmailBtn_Click(object sender, EventArgs e)
        {

        }

        private void studentclassesGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studID = Int32.Parse(studentclassesGV.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            subcode = Int32.Parse(studentclassesGV.Rows[e.RowIndex].Cells["SubjectCode"].Value.ToString());

            frmStudentAssessments assessments = new frmStudentAssessments();
            assessments.uIDlbl.Text = studID.ToString();
            assessments.subID.Text = subcode.ToString();
            assessments.Show();
        }

        private string findCurrentTerm()
        {
            DateTime now  = DateTime.Now;

            yr = now.Year.ToString();
            mth = now.Month; 
            

            if (mth < 8)
            {
                cTerm = (from c in db.Classes
                        where c.AcademicYear.Contains(yr+"-")
                        select c.AcademicYear).ToString();

            }
            else
            {
                cTerm = (from c in db.Classes
                         where c.AcademicYear.Contains("-"+yr)
                         select c.AcademicYear).ToString();
            }

            
            return cTerm;
        }

        private void studentclassesGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            studID = Int32.Parse(studentclassesGV.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            subcode = Int32.Parse(studentclassesGV.Rows[e.RowIndex].Cells["SubjectCode"].Value.ToString());

            frmStudentAssessments assessments = new frmStudentAssessments();
            assessments.uIDlbl.Text = studID.ToString();
            assessments.subID.Text = subcode.ToString();
            assessments.Show();
        }
            
           
    } 
}
