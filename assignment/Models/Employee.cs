using System;
using System.ComponentModel.DataAnnotations;

namespace assignment.Models
{
    public class Employee
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Name is required!!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required!!")]
        [Range(1, 120, ErrorMessage = "Age must be between 1-120 in years.")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Gender is required!!")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Date of Birth is required!!")]
        [DataType(DataType.DateTime)]
        public string Dob { get; set; }

        [Required(ErrorMessage = "City is required!!")]
        [StringLength(30, MinimumLength = 3)]
        public string City { get; set; }

        [Required(ErrorMessage = "Designation is required!!")]
        [StringLength(30, MinimumLength = 3)]
        public string Designation { get; set; }
    }
}
