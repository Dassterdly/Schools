using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Final
{
    public partial class frmNewVillage : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int vID;
        string result;
        Village newVillage;
        public const string spattern = @"^([a-zA-Z'.\s]{1,50})$";

        public frmNewVillage()
        {
            InitializeComponent();
        }

        private void frmNewVillage_Load(object sender, EventArgs e)
        {
            loadfrm();
        }

        private void loadfrm()
        {
            vID = db.Villages.Max(v => v.VillageID) + 1;
            vidTB.Text = vID.ToString();
            listbind();
            
        }

        private void listbind()
        {
            villageLB.DataSource = null;
            villageLB.DataSource = db.Villages.Select(x => x.VillageName).Distinct().ToList();
            villageLB.DisplayMember = "VillageName";
            

        }

        private void SaveSubjbtn_Click(object sender, EventArgs e)
        {
            try
            {
                saveVillage();
                loadfrm();
                VillageTB.Clear();
                
                MessageBox.Show("Contact Successfully Added to Villages!");

                VillageTB.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Village entered - Cannot Be Saved");
            }
        }

        private void ValidData()
        {
            MessageBox.Show("Please enter Valid Data");
        }

        public string ValidateName(string input)
        {

            if (input != null)
            {

                if (Regex.IsMatch(input, spattern) == true)
                {
                    result = input;
                }
                else
                {
                    ValidData();
                    VillageTB.Clear();
                    VillageTB.Focus();
                }
            }
            else
            {
                ValidData();
                VillageTB.Clear();
                VillageTB.Focus();

            }
            return result;
        }


        private void saveVillage()
        {
            newVillage = new Village()
            {
                VillageID = Convert.ToInt32(vidTB.Text),
                VillageName = ValidateName(VillageTB.Text)         
            };

            db.Villages.Add(newVillage);
            db.SaveChanges();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.VillageTB.Clear();
            this.VillageTB.Clear();
            this.Close();
        }
    }
}
