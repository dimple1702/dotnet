using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalBookStore.CustomEntities
{
    public class BookCommentModel
    {
        [Key]
        public long BookCommentId { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public string BookName { get; set; }
        public string Comment { get; set; }
    }
}
