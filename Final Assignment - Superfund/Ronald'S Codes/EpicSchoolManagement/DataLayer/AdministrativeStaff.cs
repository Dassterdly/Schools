//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpicSchoolManagement.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdministrativeStaff
    {
        public int AdministrativeStaffID { get; set; }
        public string SFirstName { get; set; }
        public string SMiddleInitial { get; set; }
        public string SLastName { get; set; }
        public int SchoolCode { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public int VillageID { get; set; }
        public int ParishID { get; set; }
        public int UserID { get; set; }
    
        public virtual Parish Parish { get; set; }
        public virtual School School { get; set; }
        public virtual User User { get; set; }
        public virtual Village Village { get; set; }
    }
}