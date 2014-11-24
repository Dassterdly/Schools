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
using System.Net;
using System.Net.Mail;

namespace Final
{
    public partial class frmStudentAccount : Form
    {
        
        SchoolsEntities db = new SchoolsEntities();
        int uID, sID, studID, subcode, mth;
        string result, yr, Term;
        

        public frmStudentAccount()
        {
            InitializeComponent();
        }

        private void frmStudentAccount_Load(object sender, EventArgs e)
        {
           Term =  findCurrentTerm(DateTime.Now);
            LoadStudentProfile();
            LoadStudentParents();
            fillcombobox();
            LoadStudentClasses(Convert.ToInt32(TermCB.SelectedValue), AcademicPCB.Text);
            studentclassesGV.Columns["ID"].Visible = false;
            studentclassesGV.Columns["SubjectCode"].Visible = false;
            LoadGradeBook();

        }

        private void hidecols()
        {
            studentclassesGV.Columns["ID"].Visible = false;
            studentclassesGV.Columns["SubjectCode"].Visible = false;
            studentclassesGV.Columns["Form"].Visible = false;
            studentclassesGV.Columns["AcademicTerm"].Visible = false;
            studentclassesGV.Columns["AcademicYear"].Visible = false;
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
                         select new { FirstName = p.FirstName, LastName = p.LastName, Relationship = sp.Relationship };

            studentparentGridView.DataSource = pquery.ToList();
            
            
        }
        
        private void LoadStudentClasses(int term, string year)
        {
            
            if (TermCB.SelectedIndex == -1 &&  AcademicPCB.SelectedIndex == -1)
            {
                var classquery = from s in db.Students
                                 join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                                 where s.UserID == uID 
                                 select new
                                 {
                                     ID = s.StudentID,
                                     Subject = sc.Class.Subject,
                                     SubjectCode = sc.Class.SubjectCode,
                                     Lecturer = sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName,
                                     Form = sc.Class.SchoolForm,
                                     AcademicTerm = sc.Class.Term,
                                     AcademicYear = sc.Class.AcademicYear
                                 };

                
                studentclassesGV.DataSource = classquery.OrderByDescending(x => x.AcademicYear).ToList();
                
            }

            if (TermCB.SelectedIndex != -1 && AcademicPCB.SelectedIndex == -1)
            {
                var classquery = from s in db.Students
                                 join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                                 where (s.UserID == uID && sc.Class.TermID == term && sc.Class.AcademicYear == year) ||
                             (s.UserID == uID && sc.Class.TermID == term || sc.Class.AcademicYear == year)
                             

                             select new
                             {
                                 ID = s.StudentID,
                                 Subject = sc.Class.Subject,
                                 SubjectCode = sc.Class.SubjectCode,
                                 Lecturer = sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName,
                                 Form = sc.Class.SchoolForm,
                                 AcademicTerm = sc.Class.Term,
                                 AcademicYear = sc.Class.AcademicYear
                             };

            studentclassesGV.DataSource = classquery.OrderByDescending(x=> x.AcademicYear).ToList();
            }

            if (TermCB.SelectedIndex == -1 && AcademicPCB.SelectedIndex != -1)
            {
                var classquery = from s in db.Students
                                 join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                                 where (s.UserID == uID && sc.Class.TermID == term && sc.Class.AcademicYear == year) ||
                                 (s.UserID == uID && sc.Class.AcademicYear == year || sc.Class.TermID == term)


                                 select new
                                 {
                                     ID = s.StudentID,
                                     Subject = sc.Class.Subject,
                                     SubjectCode = sc.Class.SubjectCode,
                                     Lecturer = sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName,
                                     Form = sc.Class.SchoolForm,
                                     AcademicTerm = sc.Class.Term,
                                     AcademicYear = sc.Class.AcademicYear
                                 };

                studentclassesGV.DataSource = classquery.OrderByDescending(x => x.AcademicYear).ToList();
            }

            if (TermCB.SelectedIndex != -1 && AcademicPCB.SelectedIndex != -1)
            {
                var classquery = from s in db.Students
                                 join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                                 where (s.UserID == uID && sc.Class.TermID == term && sc.Class.AcademicYear == year)
                                 select new
                                 {

                                 ID = s.StudentID,
                                 Subject = sc.Class.Subject,
                                 SubjectCode = sc.Class.SubjectCode,
                                 Lecturer = sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName,
                                 Form = sc.Class.SchoolForm,
                                 AcademicTerm = sc.Class.Term,
                                 AcademicYear = sc.Class.AcademicYear
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
                             where s.UserID == uID
                             select new
                             {
                                 ID = s.StudentID,
                                 Subject = sc.Class.Subject,
                                 SubjectCode = sc.Class.SubjectCode,
                                 Lecturer = sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName,
                                 Form = sc.Class.SchoolForm,
                                 AcademicTerm = sc.Class.Term,
                                 AcademicYear = sc.Class.AcademicYear
                             };


            studentclassesGV.DataSource = classquery.OrderByDescending(x => x.AcademicYear).ToList();
                    
            
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
                    lv.SubItems.Add("Pending...");
                    //lv.SubItems.Add(sc.Grade !=null ? sc.Grade : "Pending");
                    lv.Group = GradebookListView.Groups[group];
                });
            });
            
        }
                     
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            printReport();
        }

        private void EmailBtn_Click(object sender, EventArgs e)
        {
            sendEmail();
        }

        private void printReport()
        {
           




        }
        private void studentclassesGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studID = Convert.ToInt32(studentidTB.Text);
            subcode = Int32.Parse(studentclassesGV.Rows[e.RowIndex].Cells["ClassID"].Value.ToString());

            frmStudentAssessments assessments = new frmStudentAssessments();
            assessments.uIDlbl.Text = studID.ToString();
            assessments.subID.Text = subcode.ToString();
            assessments.Show();
            

        }

        private string findCurrentTerm(DateTime now)
        {
            
            now  = DateTime.Now;

            yr = now.Year.ToString();
            mth = now.Month; 
            string filter;
            
            if (mth > 8)
            {
               filter = yr+'-';
               result = db.Classes.Where(x=> x.AcademicYear.Contains(filter)).ToString();
                    
                    //from c in db.Classes
                    //    where c.AcademicYear.Contains(yr+"-")
                    //    select c.AcademicYear;

            }
            else
            {
                filter = '-' + yr;
               result = (from c in db.Classes
                         where c.AcademicYear.Contains(filter)
                         select c.AcademicYear).ToString();
            }

            
            return result;
        }

       

        private void sendEmail()
        {
            try
            {
                var email = db.Users.Where(u=> u.UserID == Convert.ToInt32(uIDlbl.Text)).Select(e=> e.Email).ToString();
                MailMessage mail = new MailMessage();
                SmtpClient Server = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("xora.nedd@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Student's Grades";
                mail.Body = "Dear Parent," + " \n\n" + "Please see attachment for your child/childrens' progress report for the current semester.";

                Server.Port = 587;
                Server.Credentials = new System.Net.NetworkCredential("Usernamer", "password");
                Server.EnableSsl = true;

                Server.Send(mail);
                MessageBox.Show("Message Successfully Sent");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot be Sent" + ex);
            }




        }

        private void studentclassesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            PrintReportfromDGV.Print_DataGridView(studentclassesGV);
        }
            
           
    } 
}
