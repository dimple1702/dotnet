using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AssignmentEFEntities.Entities
{
    public partial class Designation
    {
        public Designation()
        {
            EmployeeTable = new HashSet<EmployeeTable>();
        }

        public long Id { get; set; }
        public string Type { get; set; }
        public int Yos { get; set; }

        public virtual ICollection<EmployeeTable> EmployeeTable { get; set; }
    }
}
