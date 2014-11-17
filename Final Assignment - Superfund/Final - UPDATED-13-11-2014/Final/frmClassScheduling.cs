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
    public partial class frmClassScheduling : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int cID, skcode, csID;

        ClassesSchedule newclasstime = new ClassesSchedule();
        Class newclass;
       
        public frmClassScheduling()
        {
            InitializeComponent();
        }

        private void frmClassScheduling_Load(object sender, EventArgs e)
        {
            skcode = Convert.ToInt32(sklbl.Text);
            ClassdayGB.Visible = false;
            LoadCB();
            LoadGrid();
        }
        private void LoadGrid()
        {
            
            var query = (from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        join t in db.Teachers on c.TeacherID equals t.TeacherID
                        join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                        join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                        join trm in db.Terms on c.TermID equals trm.TermID
                        join f in db.SchoolForms on c.FormID equals f.FormID
                        where t.SchoolCode == skcode
                        select new
                        {
                            ID = s.StudentID,
                            Name = s.FirstName + " " + s.LastName,
                            Form = s.SchoolForm,
                            Term = c.Term,
                            Year = c.AcademicYear


                        }).Distinct();
            SKLclasslistGV.DataSource = query.ToList();

        }
        private void LoadCB()
        {
            
            newsubjCB.DataSource = db.Subjects.ToList();
            newsubjCB.DisplayMember = "SubjectName";
            newsubjCB.ValueMember = "SubjectCode";
            newsubjCB.SelectedIndex = -1;

            var query = from t in db.Teachers
                        join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                        where t.SchoolCode == skcode
                        select new 
                        { 
                            ID = t.TeacherID,
                            Name = t.FirstName + " " + t.LastName 
                        };
            lecCB.DataSource = query.ToList();
            lecCB.DisplayMember ="Name";
            lecCB.ValueMember = "ID";
            lecCB.SelectedIndex = -1;

            DaySelectionCB.DataSource = db.Days.ToList();
            DaySelectionCB.DisplayMember = "DayName";
            DaySelectionCB.ValueMember = "DayID";
            DaySelectionCB.SelectedIndex = -1;

            acadyrCB.DataSource = db.Classes.Select(y=> y.AcademicYear).Distinct().ToList();
            acadyrCB.DisplayMember = "AcademicYear";
            acadyrCB.SelectedIndex = -1;

            TermCB.DataSource = db.Terms.ToList();
            TermCB.DisplayMember = "TermName";
            TermCB.ValueMember = "TermID";
            TermCB.SelectedIndex = -1;

            FormCB.DataSource = db.SchoolForms.ToList();
            FormCB.DisplayMember = "FormName";
            FormCB.ValueMember = "FormID";
            FormCB.SelectedIndex = -1;
            
        }

        private void AddTimeBtn_Click(object sender, EventArgs e)
        {
            try
            {
            csID = db.ClassesSchedules.Max(x => x.ClassScheduleID) + 1;
            
            newclasstime =  new ClassesSchedule()
                {
                    ClassScheduleID = csID,
                    ClassID = Convert.ToInt32(classIDTB.Text),
                    DayID = Convert.ToInt32(DaySelectionCB.SelectedValue),
                    StartTime = startCB.Text,
                    EndTime = endCB.Text,
                 };
           
            db.ClassesSchedules.Add(newclasstime);
            db.SaveChanges();

            MessageBox.Show("Classes successfully saved");
            UpdateGrid();
            hidecols();
             }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR - Cannot be Saved:" + "\n\n\n" + ex);
            }

        }

        private void hidecols()
        {
            CSGridView.Columns["Class"].Visible = false;
        }

        private void saveClass()
        {
            try
            {
                newclass = new Class()
                {
                    ClassID = Convert.ToInt32(classIDTB.Text),
                    SchoolCode = Convert.ToInt32(sklbl.Text),
                    SubjectCode = Convert.ToInt32(newsubjCB.SelectedValue),
                    TeacherID = Convert.ToInt32(lecCB.SelectedValue),
                    FormID = Convert.ToInt32(FormCB.SelectedValue),
                    TermID = Convert.ToInt32(TermCB.SelectedValue),
                    AcademicYear = acadyrCB.Text
                };
                db.Classes.Add(newclass);
                db.SaveChanges();

                MessageBox.Show("Saved!");

                ClassdayGB.Visible = true;
                readyOnly();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR - Cannot be Saved:" + "\n\n\n" + ex);
            }

        }

        private void UpdateGrid()
        {
            CSGridView.DataSource = new BindingList<ClassesSchedule>(newclass.ClassesSchedules.ToList());
        }

        private void nClassidLbl_Click(object sender, EventArgs e)
        {
            cID = db.Classes.Max(x => x.ClassID) + 1;
            classIDTB.Text = cID.ToString();
        }

        private void NewSubbtn_Click(object sender, EventArgs e)
        {
            frmNewSubject newsubj = new frmNewSubject();
            newsubj.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveClass();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            resetBtns();
        }

        private void NewTeacherbtn_Click(object sender, EventArgs e)
        {

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            resetBtns();
        }

        private void resetBtns()
        {
            classIDTB.Clear();
            newsubjCB.SelectedIndex = -1;
            lecCB.SelectedIndex = -1;
            acadyrCB.SelectedIndex = -1;
            TermCB.SelectedItem = -1;
            FormCB.SelectedIndex = -1;
        }

        private void readyOnly()
        {
            classIDTB.ReadOnly = true;
            newsubjCB.Enabled = false;
            lecCB.Enabled = false;
            acadyrCB.Enabled = false;
            TermCB.Enabled = false;
            FormCB.Enabled = false;



        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
