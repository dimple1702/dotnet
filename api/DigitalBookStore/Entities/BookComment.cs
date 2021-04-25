using System;
using System.Collections.Generic;

#nullable disable

namespace DigitalBookStore.Entities
{
    public partial class BookComment
    {
        public long BookCommentId { get; set; }
        public long BookId { get; set; }
        public long UserId { get; set; }
        public string Comment { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
