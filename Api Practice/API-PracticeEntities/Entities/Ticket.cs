using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_PracticeEntities.Entities
{
    public partial class Ticket
    {
        public int TicketId { get; set; }
        public int UserId { get; set; }
        public string TicketSubject { get; set; }
        public string TicketDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual User User { get; set; }
    }
}
