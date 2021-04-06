using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAppEntities.Entities
{
    public partial class Teacher
    {
        public Teacher()
        {
            Student = new HashSet<Student>();
        }

        public long TeacherId { get; set; }
        public string TeacherFname { get; set; }
        public string TeacherLname { get; set; }
        public string TeacherEmail { get; set; }
        public string TeacherPhoneNo { get; set; }
        public DateTime HireDate { get; set; }
        public long DeptId { get; set; }
        public long LocId { get; set; }

        public virtual Department Dept { get; set; }
        public virtual Location Loc { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
