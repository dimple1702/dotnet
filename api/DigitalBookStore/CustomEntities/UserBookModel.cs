using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalBookStore.Entities
{
    public class UserBookModel
    {
        [Key]
        public long BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public byte[] BookImage { get; set; }
        public decimal BookPrice { get; set; }
    }
}
