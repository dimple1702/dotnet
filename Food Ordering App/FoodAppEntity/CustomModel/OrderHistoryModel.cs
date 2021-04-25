using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAppEntity.CustomModel
{
    public class OrderHistoryModel
    {
        [Key]  
        public long MenuId { get; set; }        
        public long UserId { get; set; }        
        public string ItemName { get; set; }
        public string ItemImage { get; set; }
        public decimal Price { get; set; }
        public string ItemDescription { get; set; }
        public string CategoryName { get; set; }

        public DateTime OrderDateTime { get; set; }

    }
}
