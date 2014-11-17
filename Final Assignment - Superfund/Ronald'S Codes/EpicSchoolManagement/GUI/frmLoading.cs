using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicSchoolManagement
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void progressCounterTimer_Tick(object sender, EventArgs e)
        {
            loadingProgressBar.Increment(1);
            if (loadingProgressBar.Value == 1000)
                progressCounterTimer.Stop();
        }
    }
}
