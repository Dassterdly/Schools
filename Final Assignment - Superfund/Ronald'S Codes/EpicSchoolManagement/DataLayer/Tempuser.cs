using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpicSchoolManagement
{

    public class Tempuser
    {
        // the properties of the Tempuser class
        public int TmpuserID { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Accesstype { get; set; }
        public string School { get; set; }
    }
}


//public class Tempuser
//   {

//       public IEnumerable<Tempuser> tempuser { get; set; }
//   }

//   public class tempuser
//   {

//       public int UserID { get; set; }
//       public string Username { get; set; }                        
//       public string password { get; set; }
//       public string accesstype { get; set; }
//       //public int SchoolID { get; set; }
//       public string school { get; set; }
//public String district { get; set; }

//   }