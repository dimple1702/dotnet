using ApiPractice.Models;
using ApiPracticeBusinessLayer.Interface;
using ApiPracticeEntities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApiPractice.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {
        private readonly IApiPracticeBusinessComponent _context;
        private readonly IConfiguration _config;
        
        public AccountController(IApiPracticeBusinessComponent context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login([FromQuery] LoginModel loginModel)
        {
            var userInfo = _context.GetUsers().Where(x => x.UserName == loginModel.Username && x.Password == loginModel.Password).FirstOrDefault();
            var token = GenerateJSONWebToken(userInfo);
            return Ok(token);
        }
        
        private string GenerateJSONWebToken(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] {
                new Claim(ClaimTypes.Name, userInfo.UserName),
                new Claim(ClaimTypes.Role, userInfo.RoleName)
            }; 
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(30),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}