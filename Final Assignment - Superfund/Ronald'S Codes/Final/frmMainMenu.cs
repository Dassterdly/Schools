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
            studentfrm.tabControl1.SelectedIndex = 0;
            studentfrm.Show();

           
            
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentAccount studentfrm = new frmStudentAccount();
            studentfrm.uIDlbl.Text = uIDlbl.Text;
            studentfrm.tabControl1.SelectedIndex=1;
            studentfrm.Show();
        }

        private void gradeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentAccount studentfrm = new frmStudentAccount();
            studentfrm.uIDlbl.Text = uIDlbl.Text;
            studentfrm.tabControl1.SelectedIndex = 2;
            studentfrm.Show();

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void classesTaughtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
