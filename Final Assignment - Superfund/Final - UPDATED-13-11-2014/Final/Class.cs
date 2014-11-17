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
    
    public partial class Class
    {
        public Class()
        {
            this.ClassesSchedules = new HashSet<ClassesSchedule>();
            this.StudentClasses = new HashSet<StudentClass>();
        }
    
        public int ClassID { get; set; }
        public int SchoolCode { get; set; }
        public int SubjectCode { get; set; }
        public int TeacherID { get; set; }
        public int FormID { get; set; }
        public int TermID { get; set; }
        public string AcademicYear { get; set; }
    
        public virtual School School { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Term Term { get; set; }
        public virtual ICollection<ClassesSchedule> ClassesSchedules { get; set; }
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
        public virtual SchoolForm SchoolForm { get; set; }
    }
}