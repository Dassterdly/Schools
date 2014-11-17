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
    public partial class frmMainMenu : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentAccount studentfrm = new frmStudentAccount();
            studentfrm.uIDlbl.Text = uIDlbl.Text;
            studentfrm.StudentScheduleTab.SelectedIndex = 0;
            studentfrm.Show();
            
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentAccount studentfrm = new frmStudentAccount();
            studentfrm.uIDlbl.Text = uIDlbl.Text;
            studentfrm.StudentScheduleTab.SelectedIndex=1;
            studentfrm.Show();
        }

        private void gradeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentAccount studentfrm = new frmStudentAccount();
            studentfrm.uIDlbl.Text = uIDlbl.Text;
            studentfrm.StudentScheduleTab.SelectedIndex = 2;
            studentfrm.Show();

        }

        private void accountToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmTeacherAccount teacherfrm = new frmTeacherAccount();
            teacherfrm.uIDlbl.Text = uIDlbl.Text;
            teacherfrm.Show();


            
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmParentAccount parentfrm = new frmParentAccount();
            parentfrm.uIDlbl.Text = uIDlbl.Text;
            parentfrm.Show();
        }
    }
}
