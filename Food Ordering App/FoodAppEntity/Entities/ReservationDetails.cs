using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FoodAppEntity.Entities
{
    public partial class ReservationDetails
    {
        public long ReservationId { get; set; }
        public string CustomerName { get; set; }
        public int NumberOfCustomers { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
