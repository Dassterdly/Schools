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
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            ClockConfig();
        }

        private void ClockConfig()
        {
            analogClock1.Enabled = !analogClock1.Enabled;
            analogClock1.ClockStyle = AnalogClock.ClockStyles.Standard;
            analogClock1.HandStyle = AnalogClock.HandStyles.Uniform;
            analogClock1.TickStyle = AnalogClock.TickStyles.All;
            analogClock1.DateStyle = AnalogClock.DateStyles.None;
            analogClock1.NumberStyle = AnalogClock.NumberStyles.All;                 
            
        }
    }
}
