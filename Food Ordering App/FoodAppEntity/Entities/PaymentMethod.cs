using System;
using System.Collections.Generic;

#nullable disable

namespace FoodAppEntity.Entities
{
    public partial class PaymentMethod
    {
        public long MethodId { get; set; }
        public string MethodName { get; set; }
    }
}
