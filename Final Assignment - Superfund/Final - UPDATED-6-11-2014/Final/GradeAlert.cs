using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class GradeAlert
    {
        SchoolsEntities db = new SchoolsEntities();
        Assessment assessment = new Assessment();
        StudentClass finalgrade = new StudentClass();

        public delegate void GradesAlert(object sender, EventArgs e);

        public event GradesAlert LowGrade;
        public event GradesAlert MissingAssignment;
        public event GradesAlert Failing;
        public event GradesAlert GradesUpdate;

        public void ClassAssignment(int id, double score)
        {
            var assignments = from a in db.Assessments
                              join sc in db.StudentClasses on a.StudentClassesID equals sc.StudentClassesID
                              join s in db.Students on sc.StudentID equals s.StudentID
                              join c in db.Classes on sc.ClassID equals c.ClassID
                              join t in db.Terms on c.TermID equals t.TermID
                              join f in db.SchoolForms on c.FormID equals f.FormID
                              join l in db.Teachers on c.TeacherID equals l.TeacherID
                              join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                              join sk in db.Schools on c.SchoolCode equals sk.SchoolCode
                              where sc.StudentID ==id
                              select a;
           
        }

        

    }
}
