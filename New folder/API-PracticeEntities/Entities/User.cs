using System;
using System.Collections.Generic;

namespace API_PracticeEntities.Entities
{
    public partial class User
    {
        public User()
        {
            Ticket = new HashSet<Ticket>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public string UserGender { get; set; }

        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
