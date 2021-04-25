using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FoodAppEntity.Entities
{
    public partial class PaymentDetails
    {
        public long PaymentDetailsId { get; set; }
        public long UserId { get; set; }
        public string UserEmailAddress { get; set; }
        public string UserResidenceAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string PaymentMethod { get; set; }

        public virtual User Users { get; set; }
    }
}
