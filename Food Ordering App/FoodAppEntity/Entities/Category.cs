using System;
using System.Collections.Generic;

#nullable disable

namespace FoodAppEntity.Entities
{
    public partial class Category
    {
        public Category()
        {
            Menus = new HashSet<Menu>();
        }

        public long CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
