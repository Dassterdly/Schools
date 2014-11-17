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
    public partial class frmNewTeacher : Form
    {
        public frmNewTeacher()
        {
            InitializeComponent();
        }

        private void NewSubbtn_Click(object sender, EventArgs e)
        {
            frmNewSubject newSub = new frmNewSubject();
            newSub.Show();
        }

        private void newParBtn_Click(object sender, EventArgs e)
        {
            frmNewParish newPar = new frmNewParish();
            newPar.Show();
        }
    }
}
