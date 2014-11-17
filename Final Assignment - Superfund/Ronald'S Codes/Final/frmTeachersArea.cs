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
    public partial class teachersArea : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        public teachersArea()
        {
            InitializeComponent();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            if (studentRB.Checked == true)
            {
                AutoCompleteStringCollection Stud = new AutoCompleteStringCollection();

                var students = db.Students;
                foreach (var s in students)
                {
                    Stud.Add(s.SFirstName);
                }

                searchTB.AutoCompleteCustomSource = Stud;

                if (searchTB.Text != string.Empty)
                {
                    
                    var items = db.Students.Where(s =>
                                                        s.SFirstName.Contains(searchTB.Text) ||
                                                        s.SLastName.Contains(searchTB.Text) ||
                                                        s.Email.Contains(searchTB.Text) ||
                                                        s.HomePhone.Contains(searchTB.Text)
                                                  );
                    dataGridView1.DataSource = items.ToList();
                }
                else dataGridView1.DataSource = db.Students.ToList();

                return;

            }
            else if (classesRB.Checked == true)
            {
                AutoCompleteStringCollection Class = new AutoCompleteStringCollection();

                var classes = db.Classes;
                foreach (var c in classes)
                {
                    Class.Add(c.Subject.ToString());
                }

                searchTB.AutoCompleteCustomSource = Class;

                if (searchTB.Text != string.Empty)
                {
                    
                    var items = db.Classes.Where(c =>
                                                        c.ClassID.ToString().Contains(searchTB.Text)
                                                  );
                    dataGridView1.DataSource = items.ToList();
                }
                else dataGridView1.DataSource = db.Classes.ToList();

                return;
                }
                else if (radioButton3.Checked == true)
                {
                    MessageBox.Show("radioButton3 !! ");
                    return;
                }

            

        }

        private void teachersArea_Load(object sender, EventArgs e)
        {
            studentRB.Checked = true;
            groupBox1.Visible = true;
            dateTimePicker1.Visible = true;
        }

        private void searchBT_Click(object sender, EventArgs e)
        {

        }

        private void searchTB_MouseHover(object sender, EventArgs e)
        {
            if (studentRB.Checked == true)
            {

                ToolTip TP = new ToolTip();
                TP.ShowAlways = true;
                TP.SetToolTip(searchTB, "Search by Student: FirstName LastName or Email ");

                return;

            }
            else if (classesRB.Checked == true)
            {
                ToolTip TP = new ToolTip();
                TP.ShowAlways = true;
                TP.SetToolTip(searchTB, "Search by Student: FirstName LastName or Email ");

                return;

                
            }
            else if (radioButton3.Checked == true)
            {
                ToolTip TP = new ToolTip();
                TP.ShowAlways = true;
                TP.SetToolTip(searchTB, "Search by Student: FirstName LastName or Email ");

                return;

            }
        



        }
    }
}
