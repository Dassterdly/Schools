using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class frmStudentAccount : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int uID, sID; 
        

        public frmStudentAccount()
        {
            InitializeComponent();
        }

        private void frmStudentAccount_Load(object sender, EventArgs e)
        {
            LoadStudentProfile();
            LoadStudentParents();
            fillcombobox();
            LoadStudentClasses(Convert.ToInt32(TermCB.SelectedValue), AcademicPCB.Text);
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
                studentidTB.Text = i.StudentID.ToString();
                sID = i.StudentID;
                SfirstnameTB.Text = i.SFirstName;
                SlastnameTB.Text = i.SLastName;
                dobTB.Text = i.DOB.ToShortDateString();
                AdmissionTB.Text = i.AdmissionDat.ToShortDateString();
                expectgradTB.Text = i.ExpectedGraduationDate.ToString();
                SchoolTB.Text = i.SchoolCode.ToString();
                FormTB.Text = i.SchoolForm.ToString();
                prioreducTB.Text = i.PriorEducation;

                VillageTB.Text = i.Village.ToString();
                ParishTB.Text = i.Parish.ToString();
                HomePHoneTB.Text = i.HomePhone.ToString();
                EmailTB.Text = i.Email;

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
            
            //HideCols();
            //studentparentGridView.DataSource = db.StudentsParents.Select(x => x).Where(x => x.StudentID == sID).ToList();
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
                                 //join cs in db.ClassesSchedules on c.ClassID equals cs.ClassID
                                 //join d in db.Days on cs.DayID equals d.DayID
                                 where s.UserID == uID

                                 select new
                                 {
                                     ClassID = c.ClassID,
                                     Subject = c.Subject,
                                     Lecturer = t.TFirstName + " " + t.TLastName,
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
                             //join cs in db.ClassesSchedules on c.ClassID equals cs.ClassID
                             //join d in db.Days on cs.DayID equals d.DayID
                             where (s.UserID == uID && c.TermID == term && c.AcademicYear == year) ||
                             (s.UserID == uID && c.TermID == term || c.AcademicYear == year)
                             

                             select new
                             {
                                 ClassID = c.ClassID,
                                 Subject = c.Subject,
                                 Lecturer = t.TFirstName + " " + t.TLastName,
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
                                 //join cs in db.ClassesSchedules on c.ClassID equals cs.ClassID
                                 //join d in db.Days on cs.DayID equals d.DayID
                                 where (s.UserID == uID && c.TermID == term && c.AcademicYear == year) ||
                                 (s.UserID == uID && c.AcademicYear == year || c.TermID == term)


                                 select new
                                 {
                                     ClassID = c.ClassID,
                                     Subject = c.Subject,
                                     Lecturer = t.TFirstName + " " + t.TLastName,
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
                                 //join cs in db.ClassesSchedules on c.ClassID equals cs.ClassID
                                 //join d in db.Days on cs.DayID equals d.DayID
                                 where (s.UserID == uID && c.TermID == term && c.AcademicYear == year)


                                 select new
                                 {
                                     ClassID = c.ClassID,
                                     Subject = c.Subject,
                                     Lecturer = t.TFirstName + " " + t.TLastName,
                                     Form = f.FormName,
                                     AcademicTerm = c.Term,
                                     AcademicYear = c.AcademicYear
                                 };

                studentclassesGV.DataSource = classquery.OrderByDescending(x => x.AcademicYear).ToList();
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
                                 ClassID = c.ClassID,
                                 Subject = c.Subject,
                                 Lecturer = t.TFirstName + " " + t.TLastName,
                                 Form = f.FormName,
                                 AcademicTerm = c.Term,
                                 AcademicYear = c.AcademicYear
                             };

            
            this.studentclassesGV.DataSource = classquery.ToList();
            
        }

            
    } 
}
