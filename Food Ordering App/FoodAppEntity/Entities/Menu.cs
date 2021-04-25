using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FoodAppEntity.Entities
{
    public partial class Menu
    {
        public Menu()
        {
            OrderHistories = new HashSet<OrderHistory>();
        }

        public long MenuId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public string ItemDescription { get; set; }
        public long CategoryId { get; set; }
        public string ItemImage { get; set; }

        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImageUploader { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
