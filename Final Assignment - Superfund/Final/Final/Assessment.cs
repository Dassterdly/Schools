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
    
    public partial class Assessment
    {
        public int AssessmentID { get; set; }
        public int StudentClassesID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Score { get; set; }
    
        public virtual StudentClass StudentClass { get; set; }
    }
}