using System;
using System.Collections.Generic;

#nullable disable

namespace FoodAppEntity.Entities
{
    public partial class User
    {
        public User()
        {
            OrderHistories = new HashSet<OrderHistory>();
            PaymentDetails = new HashSet<PaymentDetails>();
        }

        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public int? UserRole { get; set; }

        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
        public virtual ICollection<PaymentDetails> PaymentDetails { get; set; }
    }
}
