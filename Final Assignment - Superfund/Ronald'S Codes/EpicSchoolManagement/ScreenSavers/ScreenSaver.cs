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
    public partial class ScreenSaver : Form
    {
        
       
        public ScreenSaver()
        {
            InitializeComponent();
            LockParentForm();
        }

        private void LockParentForm()
        {
            
            reLogin REL = new reLogin();
            REL.Enabled = true;
            REL.TopMost = true;
            REL.Show();
            
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            //When the form loads, want to hide the cursor and raise 
            //the form in front of all other visible windows.
                        
            TopMost = true;
            Cursor.Hide();
            positionTimer.Interval = 3000;
            positionTimer.Tick += new EventHandler(positionTimer_Tick);
            positionTimer.Start();
        }


        private void FormClose()
        {
            Cursor.Show();
            this.Close();
        }

        private void ScreenSaver_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormClose();
        }

        private Point mouseLocation;

        private void ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocation.X - e.X) > 5 || Math.Abs(mouseLocation.Y - e.Y) > 5)

                    FormClose();
            }

            // Update current mouse location
            mouseLocation = e.Location; 
        }

        private void ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {

            FormClose();
        }


        #region Text Random Re-position timer

        private Random rand = new Random();

       private void positionTimer_Tick(object sender, EventArgs e)
        {
            // Move text to new random locations
            displayLabel.Left = rand.Next(Math.Max(1, Bounds.Width - displayLabel.Width));
            displayLabel.Top = rand.Next(Math.Max(1, Bounds.Height - displayLabel.Height));
        }

        #endregion

        

        
    }
}
