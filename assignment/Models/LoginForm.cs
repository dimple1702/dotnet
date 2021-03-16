using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment.Models
{
    public class LoginForm
    {

        [Required(ErrorMessage ="Enter Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Invalid Password")]
        public string Password { get; set; }

        public bool isMatch(string username, string password)
        {
            bool answer = false;
            if(username == "vermadimple@yopmail.com" && password == "Dimple@1234")
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }

    }
}
