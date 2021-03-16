using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Models
{
    public class LoginViewModel
    {

        public LoginViewModel()
        {
            this.RememberMe = true;
        }


        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage ="Invalid Password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }

}
