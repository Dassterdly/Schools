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
    public partial class frmTeacherAccount : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int uID, sID, cID, aID, scID;

        Assessment newExam;
         

        public frmTeacherAccount()
        {
            InitializeComponent();
        }

        private void frmTeacherAccount_Load(object sender, EventArgs e)
        {
            uID = Convert.ToInt32(uIDlbl.Text);
            LoadTeacherProfile();
            fillcombobox();
            results(CTAcademicperiodCB.Text, Convert.ToInt32(CTTermCB.SelectedValue), Convert.ToInt32(ctSubjectCB.SelectedValue));
            LoadStudentList();
            hideAdd();
          

        }

        private void fillcombobox()
        {
            var subjects = (from t in db.Teachers
                            join c in db.Classes on t.TeacherID equals c.TeacherID
                            join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                            where t.UserID == uID
                            select sub).Distinct();

            var year = db.Classes.Select(x => x.AcademicYear).Distinct();
            var terms = db.Terms.Distinct();

            CTAcademicperiodCB.DataSource = year.ToList();
            CTAcademicperiodCB.DisplayMember = "AcademicYear";
            CTAcademicperiodCB.SelectedIndex = -1;

            CTTermCB.DataSource = terms.ToList();
            CTTermCB.DisplayMember = "TermName";
            CTTermCB.ValueMember = "TermID";
            CTTermCB.SelectedIndex = -1;

            ctSubjectCB.DataSource = subjects.ToList();
            ctSubjectCB.DisplayMember = "SubjectName";
            ctSubjectCB.ValueMember = "SubjectCode";
            ctSubjectCB.SelectedIndex = -1;


            scAcademicYrCB.DataSource = year.ToList();
            scAcademicYrCB.DisplayMember = "AcademicYear";
            scAcademicYrCB.SelectedIndex = -1;

            scTermCB.DataSource = terms.ToList();
            scTermCB.DisplayMember = "TermName";
            scTermCB.ValueMember = "TermID";
            scTermCB.SelectedIndex = -1;

            scSubjectCB.DataSource = subjects.ToList();
            scSubjectCB.DisplayMember = "SubjectName";
            scSubjectCB.ValueMember = "SubjectCode";
            scSubjectCB.SelectedIndex = -1;

            clAcademicYrCB.DataSource = year.ToList();
            clAcademicYrCB.DisplayMember = "AcademicYear";
            clAcademicYrCB.SelectedIndex = -1;

            clTermCB.DataSource = terms.ToList();
            clTermCB.DisplayMember = "TermName";
            clTermCB.ValueMember = "TermID";
            clTermCB.SelectedIndex = -1;


            clSubjectCB.DataSource = subjects.ToList();
            clSubjectCB.DisplayMember = "SubjectName";
            clSubjectCB.ValueMember = "SubjectCode";
            clSubjectCB.SelectedIndex = -1;
            
            gAcademicYrCB.DataSource = year.ToList();
            gAcademicYrCB.DisplayMember = "AcademicYear";
            gAcademicYrCB.SelectedIndex = -1;

            gTermCB.DataSource = terms.ToList();
            gTermCB.DisplayMember = "TermName";
            gTermCB.ValueMember = "TermID";
            gTermCB.SelectedIndex = -1;


            gSubjectCB.DataSource = subjects.ToList();
            gSubjectCB.DisplayMember = "SubjectName";
            gSubjectCB.ValueMember = "SubjectCode";
            gSubjectCB.SelectedIndex = -1;

                                                 
        }

        private void LoadTeacherProfile()
        {
           var qprofile = from t in db.Teachers
                           where t.UserID == uID
                           select t;

            foreach (var i in qprofile)
            {
                //loading data into student account tab
                TeacherIDTB.Text = i.TeacherID.ToString();
                TFirsnameTB.Text = i.FirstName;
                TMItb.Text = i.MiddleInitial;
                TLastnameTB.Text = i.LastName;
                tDOBtb.Text = i.DOB.ToShortDateString();
                TSchooltb.Text = i.School.ToString();
                TVillageTB.Text = i.Village.ToString();
                TParishTB.Text = i.Parish.ToString();
                THomeTB.Text = i.Homephone;
                TCellTB.Text = i.Cellphone;
                TEmailTB.Text = i.Email;

                string id = i.TeacherID.ToString();
                string name = i.FirstName + " " + i.LastName;
                string skl = i.School.ToString();
                
                //loading data in classes taught tab
                ctTeacherIDTB.Text = id;
                ctTeacherNameTB.Text = name;
                ctSchoolTB.Text = skl;
                
                //load data into student per class tab
                spTeacherIDtb.Text = id;
                spTeacherName.Text = name;
                spSchool.Text = skl;

                //load data into class approval list tab
                clTeacherIDTB.Text = id;
                clTeacherNameTB.Text = name;
                clSchoolTB.Text = skl;

                //load data into grading tab
                gTeacheridTB.Text = id;
                gTeacherNameTB.Text = name;
                gSchoolTB.Text = skl;

                

            }


        }

        
        private void CTAcademicperiodCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Term = (from t in db.Teachers
                           join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                           join c in db.Classes on t.TeacherID equals c.TeacherID
                           join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                           join trm in db.Terms on c.TermID equals trm.TermID
                           where t.UserID == uID && c.AcademicYear == CTAcademicperiodCB.Text
                           select trm).Distinct();

            var subject = (from t in db.Teachers
                           join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                           join c in db.Classes on t.TeacherID equals c.TeacherID
                           join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                           join trm in db.Terms on c.TermID equals trm.TermID
                           where t.UserID == uID && c.AcademicYear == CTAcademicperiodCB.Text && trm.TermName == CTTermCB.Text
                           select sub).Distinct();
            
            CTTermCB.DataSource = Term.ToList();
            CTTermCB.DisplayMember = "TermName";
            CTTermCB.ValueMember = "TermID";
            CTTermCB.SelectedIndex = -1;

            ctSubjectCB.DataSource = subject.ToList();
            ctSubjectCB.DisplayMember = "SubjectName";
            ctSubjectCB.ValueMember = "SubjectCode";
            ctSubjectCB.SelectedIndex = -1;
        }

        private void results(string yr, int trm, int sub)
        {
            var cbyID = from t in db.Teachers
                                  join c in db.Classes on t.TeacherID equals c.TeacherID
                                  join f in db.SchoolForms on c.FormID equals f.FormID
                                  join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                                  join tm in db.Terms on c.TermID equals tm.TermID
                                  where t.UserID == uID
                                  orderby c.AcademicYear descending, c.FormID descending
                                  select new
                                  {
                                      ID = c.ClassID,
                                      Subject = c.Subject,
                                      Form = f.FormName,
                                      AcademicTerm = c.Term,
                                      AcademicYear = c.AcademicYear
                                  };

            var cbyIDYR = from t in db.Teachers
                                  join c in db.Classes on t.TeacherID equals c.TeacherID
                                  join f in db.SchoolForms on c.FormID equals f.FormID
                                  join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                                  join tm in db.Terms on c.TermID equals tm.TermID
                                  where t.UserID == uID && c.AcademicYear == yr
                                  orderby c.AcademicYear descending, c.FormID descending
                                  select new
                                  {
                                      ID = c.ClassID,
                                      Subject = c.Subject,
                                      Form = f.FormName,
                                      AcademicTerm = c.Term,
                                      AcademicYear = c.AcademicYear
                                  };            

            var cbyIDYRTM = from t in db.Teachers
                                  join c in db.Classes on t.TeacherID equals c.TeacherID
                                  join f in db.SchoolForms on c.FormID equals f.FormID
                                  join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                                  join tm in db.Terms on c.TermID equals tm.TermID
                                  where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm
                                  orderby c.AcademicYear descending, c.FormID descending
                                  select new
                                  {
                                      ID = c.ClassID,
                                      Subject = c.Subject,
                                      Form = f.FormName,
                                      AcademicTerm = c.Term,
                                      AcademicYear = c.AcademicYear
                                  };            
            
            var cbyAll = from t in db.Teachers
                                  join c in db.Classes on t.TeacherID equals c.TeacherID
                                  join f in db.SchoolForms on c.FormID equals f.FormID
                                  join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                                  join tm in db.Terms on c.TermID equals tm.TermID
                                  where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm && c.SubjectCode == sub
                                  orderby c.AcademicYear descending, c.FormID descending
                                  select new
                                  {
                                      ID = c.ClassID,
                                      Subject = c.Subject,
                                      Form = f.FormName,
                                      AcademicTerm = c.Term,
                                      AcademicYear = c.AcademicYear
                                  };
            var SbyID = from s in db.Students
                          join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                          join c in db.Classes on sc.ClassID equals c.ClassID
                          join f in db.SchoolForms on c.FormID equals f.FormID
                          join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                          join tm in db.Terms on c.TermID equals tm.TermID
                          join t in db.Teachers on c.TeacherID equals t.TeacherID
                          where t.UserID == uID
                          orderby c.AcademicYear descending, c.FormID descending
                          select new
                          {
                              ID = sc.StudentClassesID,
                              CID = sc.ClassID,
                              SID = sc.StudentID,
                              Student = s.FirstName + " " + s.LastName,
                              Subject = c.Subject,
                              Form = f.FormName,
                              AcademicYear = c.AcademicYear,
                              AcademicTerm = c.Term
                          };
            var SbyIDYR = from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        join f in db.SchoolForms on c.FormID equals f.FormID
                        join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                        join tm in db.Terms on c.TermID equals tm.TermID
                        join t in db.Teachers on c.TeacherID equals t.TeacherID
                        where t.UserID == uID && c.AcademicYear == yr
                        orderby c.AcademicYear descending, c.FormID descending
                        select new
                        {
                            ID = sc.StudentClassesID,
                            CID = sc.ClassID,
                            SID = sc.StudentID,
                            Student = s.FirstName + " " + s.LastName,
                            Subject = c.Subject,
                            Form = f.FormName,
                            AcademicYear = c.AcademicYear,
                            AcademicTerm = c.Term
                        };

            var SbyIDYRTM = from s in db.Students
                          join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                          join c in db.Classes on sc.ClassID equals c.ClassID
                          join f in db.SchoolForms on c.FormID equals f.FormID
                          join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                          join tm in db.Terms on c.TermID equals tm.TermID
                          join t in db.Teachers on c.TeacherID equals t.TeacherID
                           where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm
                          orderby c.AcademicYear descending, c.FormID descending
                          select new
                          {
                              ID = sc.StudentClassesID,
                              CID = sc.ClassID,
                              SID = sc.StudentID,
                              Student = s.FirstName + " " + s.LastName,
                              Subject = c.Subject,
                              Form = f.FormName,
                              AcademicYear = c.AcademicYear,
                              AcademicTerm = c.Term
                          };

            var SbyAll = from s in db.Students
                           join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                           join c in db.Classes on sc.ClassID equals c.ClassID
                           join f in db.SchoolForms on c.FormID equals f.FormID
                           join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                           join tm in db.Terms on c.TermID equals tm.TermID
                           join t in db.Teachers on c.TeacherID equals t.TeacherID
                           where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm && c.SubjectCode == sub
                           orderby c.AcademicYear descending, c.FormID descending
                           select new
                           {
                               ID = sc.StudentClassesID,
                               CID = sc.ClassID,
                               SID = sc.StudentID,
                               Student = s.FirstName + " " + s.LastName,
                               Subject = c.Subject,
                               Form = f.FormName,
                               AcademicYear = c.AcademicYear,
                               AcademicTerm = c.Term
                           };

            if (TeacherTabs.SelectedTab == TeacherTabs.TabPages["TAccountTab"] || TeacherTabs.SelectedTab == TeacherTabs.TabPages["ClassTaughtTab"])
            {
                if (yr == "" & trm <= 0 & sub <= 0)
                {
                    teachercoursesGV.DataSource = cbyID.ToList();
                }

                if (yr != "" & trm <= 0 & sub <= 0)
                {
                    teachercoursesGV.DataSource = cbyIDYR.ToList();
                }

                if (yr != "" & trm != 0 & sub <= 0)
                {
                    teachercoursesGV.DataSource = cbyIDYRTM.ToList();
                }

                if (yr != "" & trm != 0 & sub != 0)
                {
                    teachercoursesGV.DataSource = cbyAll.ToList();
                }
            }


            if (TeacherTabs.SelectedTab == TeacherTabs.TabPages["StudentsPerClassTab"])
            {
                if (yr == "" & trm <= 0 & sub <= 0)
                {
                   studentclasslistGV.DataSource = SbyID.ToList();
                }

                if (yr != "" & trm <= 0 & sub <= 0)
                {
                    studentclasslistGV.DataSource = SbyIDYR.ToList();
                }

                if (yr != "" & trm != 0 & sub <= 0)
                {
                    studentclasslistGV.DataSource = SbyIDYRTM.ToList();
                }

                if (yr != "" & trm != 0 & sub != 0)
                {
                    studentclasslistGV.DataSource = SbyAll.ToList();
                }
            }


            if (TeacherTabs.SelectedTab == TeacherTabs.TabPages["ClassApprovalTab"])
            {
                if (yr == "" & trm <= 0 & sub <= 0)
                {
                    classapprovallistGV.DataSource = SbyID.ToList();
                }

                if (yr != "" & trm <= 0 & sub <= 0)
                {
                    classapprovallistGV.DataSource = SbyIDYR.ToList();
                }

                if (yr != "" & trm != 0 & sub <= 0)
                {
                    classapprovallistGV.DataSource = SbyIDYRTM.ToList();
                }

                if (yr != "" & trm != 0 & sub != 0)
                {
                    classapprovallistGV.DataSource = SbyAll.ToList();
                }
            }

            if (TeacherTabs.SelectedTab == TeacherTabs.TabPages["StudentGradesTab"])
            {
                if (yr == "" & trm <= 0 & sub <= 0)
                {
                   gStudentsGV.DataSource = SbyID.ToList();
                   hidecols();
                }

                if (yr != "" & trm <= 0 & sub <= 0)
                {
                    gStudentsGV.DataSource = SbyIDYR.ToList();
                    hidecols();
                }

                if (yr != "" & trm != 0 & sub <= 0)
                {
                    gStudentsGV.DataSource = SbyIDYRTM.ToList();
                    hidecols();
                }

                if (yr != "" & trm != 0 & sub != 0)
                {
                    gStudentsGV.DataSource = SbyAll.ToList();
                    hidecols();
                }
            }
        }
   
        private void CTTermCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var subject= (from t in db.Teachers
                            join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                            join c in db.Classes on t.TeacherID equals c.TeacherID
                            join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                            join trm in db.Terms on c.TermID equals trm.TermID
                            where t.UserID == uID && c.AcademicYear == CTAcademicperiodCB.Text && trm.TermName == CTTermCB.Text
                            select sub).Distinct();

            ctSubjectCB.DataSource = subject.ToList();
            ctSubjectCB.DisplayMember = "SubjectName";
            ctSubjectCB.ValueMember = "SubjectCode";
            ctSubjectCB.SelectedIndex = -1;

        }

        private void scAcademicYrCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Term = (from t in db.Teachers
                        join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                        join c in db.Classes on t.TeacherID equals c.TeacherID
                        join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                        join trm in db.Terms on c.TermID equals trm.TermID
                        where t.UserID == uID && c.AcademicYear == scAcademicYrCB.Text
                        select trm).Distinct();

            var subject = (from t in db.Teachers
                           join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                           join c in db.Classes on t.TeacherID equals c.TeacherID
                           join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                           join trm in db.Terms on c.TermID equals trm.TermID
                           where t.UserID == uID && c.AcademicYear == scAcademicYrCB.Text && trm.TermName == scTermCB.Text
                           select sub).Distinct();

            scTermCB.DataSource = Term.ToList();
            scTermCB.DisplayMember = "TermName";
            scTermCB.ValueMember = "TermID";
            scTermCB.SelectedIndex = -1;

            scSubjectCB.DataSource = subject.ToList();
            scSubjectCB.DisplayMember = "SubjectName";
            scSubjectCB.ValueMember = "SubjectCode";
            scSubjectCB.SelectedIndex = -1;
                  
            
            
        }

        private void scTermCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var subject = (from t in db.Teachers
                           join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                           join c in db.Classes on t.TeacherID equals c.TeacherID
                           join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                           join trm in db.Terms on c.TermID equals trm.TermID
                           where t.UserID == uID && c.AcademicYear == scAcademicYrCB.Text && trm.TermName == scTermCB.Text
                           select sub).Distinct();
                                
            scSubjectCB.DataSource = subject.ToList();
            scSubjectCB.DisplayMember = "SubjectName";
            scSubjectCB.ValueMember = "SubjectCode";
            scSubjectCB.SelectedIndex = -1;
        }

        private void clAcademicYrCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Term = (from t in db.Teachers
                        join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                        join c in db.Classes on t.TeacherID equals c.TeacherID
                        join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                        join trm in db.Terms on c.TermID equals trm.TermID
                        where t.UserID == uID && c.AcademicYear == clAcademicYrCB.Text
                        select trm).Distinct();

            var subject = (from t in db.Teachers
                           join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                           join c in db.Classes on t.TeacherID equals c.TeacherID
                           join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                           join trm in db.Terms on c.TermID equals trm.TermID
                           where t.UserID == uID && c.AcademicYear == clAcademicYrCB.Text && trm.TermName == clTermCB.Text
                           select sub).Distinct();

            clTermCB.DataSource = Term.ToList();
            clTermCB.DisplayMember = "TermName";
            clTermCB.ValueMember = "TermID";
            clTermCB.SelectedIndex = -1;

            clSubjectCB.DataSource = subject.ToList();
            clSubjectCB.DisplayMember = "SubjectName";
            clSubjectCB.ValueMember = "SubjectCode";
            clSubjectCB.SelectedIndex = -1;

            
        }

        private void clTermCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var subject = (from t in db.Teachers
                           join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                           join c in db.Classes on t.TeacherID equals c.TeacherID
                           join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                           join trm in db.Terms on c.TermID equals trm.TermID
                           where t.UserID == uID && c.AcademicYear == clAcademicYrCB.Text && trm.TermName == clTermCB.Text
                           select sub).Distinct();
            
            clSubjectCB.DataSource = subject.ToList();
            clSubjectCB.DisplayMember = "SubjectName";
            clSubjectCB.ValueMember = "SubjectCode";
            clSubjectCB.SelectedIndex = -1;
        }

        private void ctGetDatabtn_Click(object sender, EventArgs e)
        {
            results(CTAcademicperiodCB.Text, Convert.ToInt32(CTTermCB.SelectedValue), Convert.ToInt32(ctSubjectCB.SelectedValue));
        }

        private void ctResetbtn_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            fillcombobox();
            this.teachercoursesGV.DataSource = null;
            
            if (TeacherTabs.SelectedTab == TeacherTabs.TabPages["ClassTaughtTab"])
                {
                    results(CTAcademicperiodCB.Text, Convert.ToInt32(CTTermCB.SelectedValue), Convert.ToInt32(ctSubjectCB.SelectedValue));
                }
            
            if (TeacherTabs.SelectedTab == TeacherTabs.TabPages["StudentsPerClassTab"])
                {
                    results(scAcademicYrCB.Text, Convert.ToInt32(scTermCB.SelectedValue), Convert.ToInt32(scSubjectCB.SelectedValue));
                }

            if (TeacherTabs.SelectedTab == TeacherTabs.TabPages["ClassApprovalTab"])
                {
                    results(clAcademicYrCB.Text, Convert.ToInt32(clTermCB.SelectedValue), Convert.ToInt32(clSubjectCB.SelectedValue));
                }

            if (TeacherTabs.SelectedTab == TeacherTabs.TabPages["StudentGradesTab"])
                {
                    results(gAcademicYrCB.Text, Convert.ToInt32(gTermCB.SelectedValue), Convert.ToInt32(gSubjectCB.SelectedValue));
                }
        }
        private void LoadStudentList()
        {
           var ctquery = from s in db.Students
                          join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                          join c in db.Classes on sc.ClassID equals c.ClassID
                          join f in db.SchoolForms on c.FormID equals f.FormID
                          join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                          join tm in db.Terms on c.TermID equals tm.TermID
                          join t in db.Teachers on c.TeacherID equals t.TeacherID
                          where t.UserID == uID
                          orderby c.AcademicYear descending , c.FormID descending
                          select new
                          {
                              ID = sc.StudentClassesID,
                              CID = sc.ClassID,
                              SID = sc.StudentID,
                              Student = s.FirstName +" "+ s.LastName,
                              Subject = c.Subject,
                              Form = f.FormName,
                              AcademicYear = c.AcademicYear,
                              AcademicTerm = c.Term
                           };
            studentclasslistGV.DataSource = ctquery.ToList();

            gStudentsGV.DataSource = ctquery.ToList();

            hidecols();
            classlist();

        }

        private void hidecols()
        {
            gStudentsGV.Columns["AcademicYear"].Visible = false;
            gStudentsGV.Columns["AcademicTerm"].Visible = false;
            
        }
        private void classlist()
        {
            var clist = from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        //join f in db.SchoolForms on c.FormID equals f.FormID
                        //join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                        //join tm in db.Terms on c.TermID equals tm.TermID
                        join t in db.Teachers on c.TeacherID equals t.TeacherID
                        where t.UserID == uID
                        orderby c.AcademicYear descending, c.FormID descending
                        select new
                        {
                            ID = sc.StudentClassesID,
                            CID = sc.ClassID,
                            SID = sc.StudentID,
                            Student = s.FirstName + " " + s.LastName,
                            Subject = c.Subject,
                            Form = c.SchoolForm.FormName,
                            //AcademicYear = c.AcademicYear,
                           // AcademicTerm = c.Term
                            //Status = "Pending"
                        };
            classapprovallistGV.DataSource = clist.ToList();

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Status";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 2;
            cmb.Items.Add("Approved");
            cmb.Items.Add("Deferred");
            classapprovallistGV.Columns.Add(cmb);
           
        }

        private void sresults(string yr, int trm, int sub)
        {
            var clist = from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        join t in db.Teachers on c.TeacherID equals t.TeacherID
                        where t.UserID == uID
                        orderby c.AcademicYear descending, c.FormID descending
                        select new
                        {
                            ID = sc.StudentClassesID,
                            CID = sc.ClassID,
                            SID = sc.StudentID,
                            Student = s.FirstName + " " + s.LastName,
                            Subject = c.Subject,
                            Form = c.SchoolForm.FormName,
                         };
            var clist2 = from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        join t in db.Teachers on c.TeacherID equals t.TeacherID
                        where t.UserID == uID && c.AcademicYear == yr
                        orderby c.AcademicYear descending, c.FormID descending
                        select new
                        {
                            ID = sc.StudentClassesID,
                            CID = sc.ClassID,
                            SID = sc.StudentID,
                            Student = s.FirstName + " " + s.LastName,
                            Subject = c.Subject,
                            Form = c.SchoolForm.FormName,
                        };
            var clist3 = from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        join t in db.Teachers on c.TeacherID equals t.TeacherID
                        where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm
                        orderby c.AcademicYear descending, c.FormID descending
                        select new
                        {
                            ID = sc.StudentClassesID,
                            CID = sc.ClassID,
                            SID = sc.StudentID,
                            Student = s.FirstName + " " + s.LastName,
                            Subject = c.Subject,
                            Form = c.SchoolForm.FormName,
                        };
            var clist4 = from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        join t in db.Teachers on c.TeacherID equals t.TeacherID
                         where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm && c.SchoolCode==sub
                        orderby c.AcademicYear descending, c.FormID descending
                        select new
                        {
                            ID = sc.StudentClassesID,
                            CID = sc.ClassID,
                            SID = sc.StudentID,
                            Student = s.FirstName + " " + s.LastName,
                            Subject = c.Subject,
                            Form = c.SchoolForm.FormName,
                        };

            if (yr == "" & trm <= 0 & sub <= 0)
            {
                classapprovallistGV.DataSource = clist.ToList();
            }
            if (yr != "" & trm <= 0 & sub <= 0)
            {
                classapprovallistGV.DataSource = clist2.ToList();
            }
            if (yr != "" & trm != 0 & sub <= 0)
            {
                classapprovallistGV.DataSource = clist3.ToList();
            }

            if (yr != "" & trm != 0 & sub != 0)
            {
                classapprovallistGV.DataSource = clist4.ToList();
            }

        }
        private void PrintReport()
        {



        }

        private void loadAssessment(int s, int c)
        {
            gStudentAssGV.DataSource = null; 

            var Aquery = from S in db.Students
                         join sC in db.StudentClasses on S.StudentID equals sC.StudentID
                         join C in db.Classes on sC.ClassID equals C.ClassID
                         join aS in db.Assessments on sC.StudentClassesID equals aS.StudentClassesID
                         where sC.StudentID == s && sC.ClassID == c
                         orderby aS.Date descending
                         select new
                         {
                            ExamDate = aS.Date,
                            Score = aS.Score
                         };
            
                
            if (Aquery.Count() == 0)
            {
                gStudentAssGV.DataSource = Aquery.ToList();
                MessageBox.Show("No Recorded Assessment(s)");
                
            }
            else
            {
                gStudentAssGV.DataSource = Aquery.ToList();

            }

        }

        private void gStudentsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sID = Int32.Parse(gStudentsGV.Rows[e.RowIndex].Cells["SID"].Value.ToString());
            cID = Int32.Parse(gStudentsGV.Rows[e.RowIndex].Cells["CID"].Value.ToString());
            scID = Int32.Parse(gStudentsGV.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            loadAssessment(sID, cID);
            hidecols();
        }

        private void scGetDataBtn_Click(object sender, EventArgs e)
        {
            results(scAcademicYrCB.Text, Convert.ToInt32(scTermCB.SelectedValue), Convert.ToInt32(scSubjectCB.SelectedValue));
        }

        private void scResetBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void hideAdd()
        {
            NewAssessmentGB.Visible = false;
        }

        private void SaveABtn_Click(object sender, EventArgs e)
        {
            saveAssess();
            hideAdd();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            NewAssessmentGB.Visible = true;
            aID = db.Assessments.Max(x=> x.AssessmentID)+1;
        }

        private void saveAssess ()
        {
            try
            {
                newExam = new Assessment()
                {
                    AssessmentID = aID,
                    StudentClassesID = scID,
                    Date = Convert.ToDateTime(AssesDatePicker.Text),
                    Score = Convert.ToDecimal(ScoreTB.Text)

                };

                db.Assessments.Add(newExam);
               db.SaveChanges();
                MessageBox.Show("Assessment Successfully Added");
                //loadAssessment(sID, cID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Be Saved, {0}" + ex);
            }
            finally
            {
                loadAssessment(sID, cID);

            }
        }

        private void clRefreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void clGetDataBtn_Click(object sender, EventArgs e)
        {
            sresults(clAcademicYrCB.Text, Convert.ToInt32(clTermCB.SelectedValue), Convert.ToInt32(clSubjectCB.SelectedValue));

        }

        private void gRefreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void gGetDataBtn_Click(object sender, EventArgs e)
        {
            results(gAcademicYrCB.Text, Convert.ToInt32(gTermCB.SelectedValue), Convert.ToInt32(gSubjectCB.SelectedValue));

        }

        private void gAcademicYrCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Term = (from t in db.Teachers
                        join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                        join c in db.Classes on t.TeacherID equals c.TeacherID
                        join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                        join trm in db.Terms on c.TermID equals trm.TermID
                        where t.UserID == uID && c.AcademicYear == gAcademicYrCB.Text
                        select trm).Distinct();

            var subject = (from t in db.Teachers
                           join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                           join c in db.Classes on t.TeacherID equals c.TeacherID
                           join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                           join trm in db.Terms on c.TermID equals trm.TermID
                           where t.UserID == uID && c.AcademicYear == gAcademicYrCB.Text && trm.TermName == gTermCB.Text
                           select sub).Distinct();

            gTermCB.DataSource = Term.ToList();
            gTermCB.DisplayMember = "TermName";
            gTermCB.ValueMember = "TermID";
            gTermCB.SelectedIndex = -1;

            gSubjectCB.DataSource = subject.ToList();
            gSubjectCB.DisplayMember = "SubjectName";
            gSubjectCB.ValueMember = "SubjectCode";
            gSubjectCB.SelectedIndex = -1;
        }

        private void gTermCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var subject = (from t in db.Teachers
                           join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                           join c in db.Classes on t.TeacherID equals c.TeacherID
                           join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                           join trm in db.Terms on c.TermID equals trm.TermID
                           where t.UserID == uID && c.AcademicYear == gAcademicYrCB.Text && trm.TermName == gTermCB.Text
                           select sub).Distinct();

            gSubjectCB.DataSource = subject.ToList();
            gSubjectCB.DisplayMember = "SubjectName";
            gSubjectCB.ValueMember = "SubjectCode";
            gSubjectCB.SelectedIndex = -1;
        }

        private void gCancelBtn_Click(object sender, EventArgs e)
        {
            ScoreTB.Clear();
            hideAdd();
        }



        
     }
}
