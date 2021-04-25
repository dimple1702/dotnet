using System;
using System.Collections.Generic;

#nullable disable

namespace FoodAppEntity.Entities
{
    public partial class OrderHistory
    {
        public long OrderHistoryId { get; set; }
        public long UserId { get; set; }
        public long MenuId { get; set; }
        public DateTime? OrderDateTime { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual User User { get; set; }
    }
}
