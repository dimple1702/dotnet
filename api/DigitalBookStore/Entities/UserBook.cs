using System;
using System.Collections.Generic;

#nullable disable

namespace DigitalBookStore.Entities
{
    public partial class UserBook
    {
        public long UserBookId { get; set; }
        public long UserId { get; set; }
        public long BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
