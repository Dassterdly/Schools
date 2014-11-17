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
    public partial class frmStudentAssessments : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int id, scode;

        public frmStudentAssessments()
        {
            InitializeComponent();
        }

        private void frmStudentAssessments_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(uIDlbl.Text);
            scode = Convert.ToInt32(subID.Text);
            loadassessments();
            
        }

        private void loadassessments()
        {

            var classquery = from s in db.Students
                             join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                             join a in db.Assessments on sc.StudentClassesID equals a.StudentClassesID                           
                             join c in db.Classes on sc.ClassID equals c.ClassID
                             join t in db.Teachers on c.TeacherID equals t.TeacherID
                             join f in db.SchoolForms on c.FormID equals f.FormID
                             join trm in db.Terms on c.TermID equals  trm.TermID
                             join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                             
                             where sc.StudentID == id && c.SubjectCode == scode

                             select new
                             {
                                   AcademicTerm = c.AcademicYear,
                                 Term = trm.TermName,
                                 Subject = sub.SubjectName,
                                 AssessmentDate = a.Date,
                                 Score = a.Score
                             };


            this.studassGV.DataSource = classquery.OrderByDescending(x => x.AssessmentDate).ToList();



        }
    }
}
