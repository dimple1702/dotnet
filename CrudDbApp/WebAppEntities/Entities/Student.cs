using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAppEntities.Entities
{
    public partial class Student
    {
        public long StudentId { get; set; }
        public string StudentFname { get; set; }
        public string StudentLname { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhoneNo { get; set; }
        public DateTime StudentDob { get; set; }
        public long? TeacherId { get; set; }
        public long? LocId { get; set; }

        public virtual Location Loc { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
