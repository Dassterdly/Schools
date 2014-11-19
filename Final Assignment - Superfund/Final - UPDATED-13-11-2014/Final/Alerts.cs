using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Alerts
    {
        SchoolsEntities db = new SchoolsEntities();
        StudentClass sClass = new StudentClass();
        

        public delegate void UpdateClass(object sender, EventArgs e);

        public event UpdateClass listapproved;

        public void Change(string status)
        {
            if (this.listapproved != null)
            {
                this.listapproved(null, new EventArgs());
            }
        }
    }
}
