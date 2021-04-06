using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAppEntities.Entities
{
    public partial class Location
    {
        public Location()
        {
            Student = new HashSet<Student>();
            Teacher = new HashSet<Teacher>();
        }

        public long LocId { get; set; }
        public string Address { get; set; }
        public string PinCode { get; set; }
        public string City { get; set; }
        public long CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
