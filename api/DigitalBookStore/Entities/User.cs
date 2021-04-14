using System;
using System.Collections.Generic;

#nullable disable

namespace DigitalBookStore.Entities
{
    public partial class User
    {
        public User()
        {
            BookComments = new HashSet<BookComment>();
            UserBooks = new HashSet<UserBook>();
        }

        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public string UserAddress { get; set; }
        public string Password { get; set; }
        public int? IsOwner { get; set; }

        public virtual ICollection<BookComment> BookComments { get; set; }
        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}
