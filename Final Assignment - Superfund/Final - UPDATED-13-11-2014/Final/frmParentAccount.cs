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
        int uID, studID;
        

        public frmParentAccount()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void frmParentAccount_Load(object sender, EventArgs e)
        {
            uID = Convert.ToInt32(uIDlbl.Text);
            LoadParentacc(uID);
            LoadChildren(uID);

        }

        private void LoadChildren(int uID)
        {
            var qchild = from p in db.Parents
                         join sp in db.StudentsParents on p.ParentID equals sp.ParentID
                         join s in db.Students on sp.StudentID equals s.StudentID
                         join sch in db.Schools on s.SchoolCode equals sch.SchoolCode
                         where p.UserID == uID && p.ParentID == sp.ParentID
                         select new { FirstName = s.FirstName, LastName = s.LastName, School = sch.SchoolName, Admission = s.AdmissionDate, Graduation = s.ExpectedGraduationDate, Userid = s.UserID };
                         
            ChildGridView.DataSource = qchild.ToList();
        }

        private void LoadParentacc(int uID)
        {

            var qprofile = from p in db.Parents
                           join sp in db.StudentsParents on p.ParentID equals sp.ParentID
                           join s in db.Students on sp.StudentID equals s.StudentID
                           where p.UserID == uID && p.ParentID==sp.ParentID
                           select new {p.ParentID, p.FirstName, p.LastName, 
                                        s.Village,s.VillageID, s.Parish, s.ParishID, p.HomePhone, p.Email,
                                        p.CellPhone, p.WorkPhone};

            foreach (var i in qprofile)
            {
                //loading data into parent account tab
                ParentIDTB.Text = i.ParentID.ToString();
                PFirsnameTB.Text = i.FirstName;
                PLastnameTB.Text = i.LastName;
                PVillageTB.Text = i.Village.ToString();
                PParishTB.Text = i.Parish.ToString();
                PHomeTB.Text = i.HomePhone.ToString();
                PWorkTB.Text = i.WorkPhone.ToString();
                PCellTB.Text = i.CellPhone.ToString();
                PEmailTB.Text = i.Email.ToString();
                
            }

        }

        private void ChildGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studID = Int32.Parse(ChildGridView.Rows[e.RowIndex].Cells["Userid"].Value.ToString());
            //selstud = db.Students.Where(s => s.StudentID == studID).ToList().Single();

            frmStudentAccount studentfrm = new frmStudentAccount();
            studentfrm.uIDlbl.Text = studID.ToString();
            studentfrm.Show();
        }

        private void ChildGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studID = Int32.Parse(ChildGridView.Rows[e.RowIndex].Cells["Userid"].Value.ToString());
            
            frmStudentAccount studentfrm = new frmStudentAccount();
            studentfrm.uIDlbl.Text = studID.ToString();
            studentfrm.ParentsGB.Visible = false;
            studentfrm.Show();
        }
    }
}
