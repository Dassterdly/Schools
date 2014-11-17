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

namespace Final
{
    public partial class frmStudentAccount : Form
    {
        
        SchoolsEntities db = new SchoolsEntities();
        int uID, sID, studID, subcode; 
        

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
                SfirstnameTB.Text = i.SFirstName;
                SlastnameTB.Text = i.SLastName;
                dobTB.Text = i.DOB.ToShortDateString();
                AdmissionTB.Text = i.AdmissionDat.ToShortDateString();
                expectgradTB.Text = i.ExpectedGraduationDate.ToString();
                SchoolTB.Text = i.School.ToString();
                FormTB.Text = i.SchoolForm.ToString();
                prioreducTB.Text = i.PriorEducation;
                VillageTB.Text = i.Village.ToString();
                ParishTB.Text = i.Parish.ToString();
                HomePHoneTB.Text = i.HomePhone.ToString();
                EmailTB.Text = i.Email;

                //loading data in student classes tab
                SCStudentTB.Text = i.SFirstName + " " + i.SLastName;
                SCsklTB.Text = i.School.ToString();
                SCFormTB.Text = i.SchoolForm.ToString();

                //load data into GradeBook tab
                GBStudentNameTB.Text = i.SFirstName + " " + i.SLastName;
                GBSchoolTB.Text = i.School.ToString();
                GBAdmDateTB.Text = i.AdmissionDat.ToShortDateString();
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
                             where (s.UserID == uID && c.TermID == term && c.AcademicYear == year) ||
                             (s.UserID == uID && c.TermID == term || c.AcademicYear == year)
                             

                             select new
                             {
                                 ID = s.StudentID,
                                 ClassID = c.ClassID,
                                 Subject = c.Subject,
                                 SubjectCode = c.SubjectCode,
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
                                 where (s.UserID == uID && c.TermID == term && c.AcademicYear == year) ||
                                 (s.UserID == uID && c.AcademicYear == year || c.TermID == term)


                                 select new
                                 {
                                     ID = s.StudentID,
                                     ClassID = c.ClassID,
                                     Subject = c.Subject,
                                     SubjectCode = c.SubjectCode,
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
                                 where (s.UserID == uID && c.TermID == term && c.AcademicYear == year)


                                 select new
                                 {
                                     ID = s.StudentID,
                                     ClassID = c.ClassID,
                                     Subject = c.Subject,
                                     SubjectCode = c.SubjectCode,
                                     Lecturer = t.TFirstName + " " + t.TLastName,
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
                                 Lecturer = t.TFirstName + " " + t.TLastName,
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
            GradebookListView.Columns.Add("Academic Year", 100);
            GradebookListView.Columns.Add("Grade", 100);

            SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString);
            con.Open();
            SqlCommand data = new SqlCommand("select sub.SubjectName, t.TFirstname + ' '+ t.TLastname as Lecturer, f.Formname, trm.TermName, c.AcademicYear, sc.Grade from users as u inner join students as s on u.UserID= s.UserID inner join StudentClasses as sc on s.StudentID  = sc.StudentID inner join Classes as c on sc.ClassID = c.ClassID inner join teachers as t on c.TeacherID = t.TeacherID inner join Subjects as sub on c.SubjectCode = sub.SubjectCode inner join SchoolForms as f on c.FormID = f.FormID inner join terms as trm on c.TermID = trm.TermID where u.UserID ='" + uIDlbl.Text + "' order by c.AcademicYear DESC", con);
            SqlCommand group = new SqlCommand("Select DISTINCT AcademicYear from Classes", con);
            SqlDataReader reader = data.ExecuteReader();




            GradebookListView.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetString(0));
                lv.SubItems.Add(reader.GetString(1));
                lv.SubItems.Add(reader.GetString(2));
                lv.SubItems.Add(reader.GetString(3));
                lv.SubItems.Add(reader.GetString(4));
                //lv.SubItems.Add(reader.GetString(5));

                GradebookListView.Items.Add(lv);


            }

            reader.Close();
            con.Close();

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
           
    } 
}
