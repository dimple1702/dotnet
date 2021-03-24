using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AssignmentEFEntities.Entities
{
    public partial class EmployeeTable
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Age { get; set; }
        public long DesignationId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Designation Designation { get; set; }
    }
}
