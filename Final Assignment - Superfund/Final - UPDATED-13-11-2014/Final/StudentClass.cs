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
    
    public partial class StudentClass
    {
        public StudentClass()
        {
            this.Assessments = new HashSet<Assessment>();
        }
    
        public int StudentClassesID { get; set; }
        public int StudentID { get; set; }
        public int ClassID { get; set; }
        public Nullable<decimal> Grade { get; set; }
        public string Status { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public Nullable<int> SignOffBy { get; set; }
    
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual Class Class { get; set; }
        public virtual Student Student { get; set; }
    }
}
