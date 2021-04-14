using System;
using System.Collections.Generic;

#nullable disable

namespace DigitalBookStore.Entities
{
    public partial class Book
    {
        public Book()
        {
            BookComments = new HashSet<BookComment>();
            UserBooks = new HashSet<UserBook>();
        }

        public long BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookSummary { get; set; }
        public byte[] BookImage { get; set; }
        public decimal BookPrice { get; set; }

        public virtual ICollection<BookComment> BookComments { get; set; }
        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}
