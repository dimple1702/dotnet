using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiPracticeEntities.Entities
{
    public partial class User
    {
        public User()
        {
            Ticket = new HashSet<Ticket>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public bool? IsActive { get; set; }
        public string RoleName { get; set; }

        public virtual Role Role { get; set; }      
        public virtual ICollection<Ticket> Ticket { get; set; }  
    }
}
