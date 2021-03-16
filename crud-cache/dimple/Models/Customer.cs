using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dimple.Models
{
    public class Customer
    {
        public string Id { get; set; }

        [Required(ErrorMessage ="Name is required.")]
        [DisplayName("Enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [DisplayName("Enter your Age.")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Date of Birth is required!!")]
        [DataType(DataType.DateTime)]
        public string Dob { get; set; }

        public string PhoneNumber { get; set; }
    }
}