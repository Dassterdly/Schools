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
    public partial class frmParentAccount : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        public frmParentAccount()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void frmParentAccount_Load(object sender, EventArgs e)
        {

        }

        private void LoadChildren(int uID)
        {
            uID = Convert.ToInt32(uIDlbl.Text);

//            var qchild = from s in db.Students
//                         join sch in db.Schools on s.SchoolCode equals sch.SchoolCode
//                         join f in db.SchoolForms on f.
//                         join sp in db.StudentsParents on s.StudentID equals sp.StudentID
//                         join p in db.Parents on sp.ParentID equals p.ParentID
//                         join sch in db.Schools on s.Student

                
//select new {s.StudentID, s.SFirstName +' ' + s.SLastName as Name, s.DOB, sch.SchoolName, s.AdmissionDat, s.ExpectedGraduationDate,
//f.FormName, s.PriorEducation}; from students as s
//inner join studentsparents as sp on sp.StudentID = s.StudentID
//inner join parents as p on sp.ParentID = p.ParentID
//inner join schools as sch on sch.SchoolCode = s.SchoolCode
//inner join SchoolForms as f on s.FormID = f.FormID
        }
    }
}
