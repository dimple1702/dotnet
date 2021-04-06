using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAppEntities.Entities
{
    public partial class Department
    {
        public Department()
        {
            Teacher = new HashSet<Teacher>();
        }

        public long DeptId { get; set; }
        public string DeptName { get; set; }

        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
