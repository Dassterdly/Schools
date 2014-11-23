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
    public partial class frmLogin : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        public frmLogin()
        {
            InitializeComponent();            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            fillcombobox();
        }

        private void fillcombobox()
        {
            accesstypeCB.DataSource = db.Users.Select(x => x.AccessType).Distinct().ToList();
            accesstypeCB.DisplayMember = "AccessType";
            accesstypeCB.SelectedIndex = -1;
        }

        private void reset()
        {
            usernameTB.Clear();
            passwordTB.Clear();
            usernameTB.Focus();
            accesstypeCB.SelectedIndex = -1;      

        }

        private void validateText(string username, string password, string accesstype)
        {
            var query = from u in db.Users
                        where u.Username == username && u.Password == password && u.AccessType == accesstype
                        select new { uName = u.Username, uType = accesstype, uID = u.UserID, pass = u.Password};


            User user = new User();

            foreach (var u in query)
            {
                user.uId = u.uID;
                user.uName = u.uName;
                user.uType = u.uType;
                user.uPass = u.pass;
            }
             
            //validate empty Text Boxes
            if (usernameTB.Text == "" || passwordTB.Text == "" || accesstypeCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter Correct Username, Password and/or AccessType");
                reset();
                fillcombobox();
            }

            //validate input with database value
            else if (usernameTB.Text != user.uName || passwordTB.Text != user.uPass || accesstypeCB.Text != user.uType)
            {
                MessageBox.Show("Please Enter Correct Username, Password and/or AccessType");
                reset();
                fillcombobox();
            }
            
            

            
        }

        private void LoadUserData(string username, string password, string accesstype)
        {
            var query = from u in db.Users
                        where u.Username == username && u.Password == password && u.AccessType == accesstype
                        select new { uName = u.FirstName + " " + u.LastName, uType = accesstype, uID = u.UserID };


            User user = new User();

            foreach (var u in query)
            {
                user.uId = u.uID;
                user.uName = u.uName;
                user.uType = u.uType;
            }




        }

        private void validateLogin(string username, string password, string accesstype)
        {

            validateText(usernameTB.Text, passwordTB.Text, accesstypeCB.Text);

            var query = from u in db.Users
                        where u.Username == username && u.Password == password && u.AccessType == accesstype
                        select new { uName = u.FirstName + " " + u.LastName, uType = accesstype, uID = u.UserID };


            User user = new User();

            foreach (var u in query)
            {
                user.uId = u.uID;
                user.uName = u.uName;
                user.uType = u.uType;
            }
            
            if (query != null && user.uType == "Administrator")
            {
                
                frmMainMenu MainMenu = new frmMainMenu();
                MainMenu.Show();
                this.Hide();
                MainMenu.uNamelbl.Text = user.uName;
                MainMenu.uTypelbl.Text = user.uType;
                MainMenu.uIDlbl.Text = user.uId.ToString();
             }

            if (query != null && user.uType == "Student")
            {

                frmMainMenu MainMenu = new frmMainMenu();
                MainMenu.Show();
                this.Hide();
                MainMenu.uNamelbl.Text = user.uName;
                MainMenu.uTypelbl.Text = user.uType;
                MainMenu.uIDlbl.Text = user.uId.ToString();
                MainMenu.parentToolStripMenuItem.Enabled = false;
                MainMenu.principalToolStripMenuItem.Enabled = false;
                MainMenu.teacherToolStripMenuItem.Enabled = false;
                MainMenu.administrativeStaffToolStripMenuItem.Enabled = false;
                MainMenu.administratorToolStripMenuItem.Visible = false;
            }

            if (query != null && user.uType == "Parent")
            {

                frmMainMenu MainMenu = new frmMainMenu();
                MainMenu.Show();
                this.Hide();
                MainMenu.uNamelbl.Text = user.uName;
                MainMenu.uTypelbl.Text = user.uType;
                MainMenu.uIDlbl.Text = user.uId.ToString();
                MainMenu.studentToolStripMenuItem.Enabled = false;
                MainMenu.principalToolStripMenuItem.Enabled = false;
                MainMenu.teacherToolStripMenuItem.Enabled = false;
                MainMenu.administrativeStaffToolStripMenuItem.Enabled = false;
                MainMenu.administratorToolStripMenuItem.Visible = false;
            }

            if (query != null && user.uType == "Principal")
            {

                frmMainMenu MainMenu = new frmMainMenu();
                MainMenu.Show();
                this.Hide();
                MainMenu.uNamelbl.Text = user.uName;
                MainMenu.uTypelbl.Text = user.uType;
                MainMenu.uIDlbl.Text = user.uId.ToString();
                MainMenu.parentToolStripMenuItem.Enabled = false;
                MainMenu.studentToolStripMenuItem.Enabled = false;
                MainMenu.teacherToolStripMenuItem.Enabled = false;
                MainMenu.administrativeStaffToolStripMenuItem.Enabled = false;
                MainMenu.administratorToolStripMenuItem.Visible = false;
            }

            if (query != null && user.uType == "Teacher")
            {

                frmMainMenu MainMenu = new frmMainMenu();
                MainMenu.Show();
                this.Hide();
                MainMenu.uNamelbl.Text = user.uName;
                MainMenu.uTypelbl.Text = user.uType;
                MainMenu.uIDlbl.Text = user.uId.ToString();
                MainMenu.parentToolStripMenuItem.Enabled = false;
                MainMenu.principalToolStripMenuItem.Enabled = false;
                MainMenu.studentToolStripMenuItem.Enabled = false;
                MainMenu.administrativeStaffToolStripMenuItem.Enabled = false;
                MainMenu.administratorToolStripMenuItem.Visible = false;
            }

            if (query != null && user.uType == "Administrative Staff")
            {

                frmMainMenu MainMenu = new frmMainMenu();
                MainMenu.Show();
                this.Hide();
                MainMenu.uNamelbl.Text = user.uName;
                MainMenu.uTypelbl.Text = user.uType;
                MainMenu.uIDlbl.Text = user.uId.ToString();
                MainMenu.parentToolStripMenuItem.Enabled = false;
                MainMenu.principalToolStripMenuItem.Enabled = false;
                MainMenu.teacherToolStripMenuItem.Enabled = false;
                MainMenu.studentToolStripMenuItem.Enabled = false;
                MainMenu.administratorToolStripMenuItem.Visible = false;
            }


        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            validateLogin(usernameTB.Text, passwordTB.Text, accesstypeCB.Text);

        }
    }
}
