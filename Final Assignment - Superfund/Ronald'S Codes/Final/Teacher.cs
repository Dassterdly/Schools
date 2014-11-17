//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        public Teacher()
        {
            this.Classes = new HashSet<Class>();
        }
    
        public int TeacherID { get; set; }
        public string TFirstName { get; set; }
        public string TMiddleInitial { get; set; }
        public string TLastName { get; set; }
        public string Homephone { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public int VillageID { get; set; }
        public int ParishID { get; set; }
        public int SchoolCode { get; set; }
        public System.DateTime DOB { get; set; }
        public int UserID { get; set; }
    
        public virtual ICollection<Class> Classes { get; set; }
        public virtual Parish Parish { get; set; }
        public virtual School School { get; set; }
        public virtual User User { get; set; }
        public virtual Village Village { get; set; }
    }
}