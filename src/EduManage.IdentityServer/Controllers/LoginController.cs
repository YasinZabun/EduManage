using EduManage.Api.Domain;
using EduManage.Api.Domain.Entites;
using EduManage.Api.Domain.Interfaces;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EduManage.IdentityServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public LoginController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            // Find the user by email
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null) return BadRequest("User does not exist.");

            // Check the password
            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if (!result.Succeeded) return BadRequest("Invalid password.");

            // Get user roles
            var roles = await _userManager.GetRolesAsync(user);

            // Generate a token
            var token = await GenerateJwtToken(user, roles);

            // Return the token
            return Ok(new { access_token = token });
        }

        [HttpGet]
        [Route("init")]
        public async Task<IActionResult> Init()
        {
            // Seed Users with Passwords
            var student1 = new Student
            {
                UserName = "yasin@gmail.com",
                Email = "yasin@gmail.com",
                FirstName = "yasin",
                LastName = "zabun",
                DateOfBirth = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            var student2 = new Student
            {
                UserName = "ali.veli@example.com",
                Email = "ali.veli@example.com",
                FirstName = "Ali",
                LastName = "Veli",
                DateOfBirth = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            };
            var instructor1 = new Instructor
            {
                UserName = "ahmet.mehmet@example.com",
                Email = "ahmet.mehmet@example.com",
                FirstName = "Ahmet",
                LastName = "Mehmet",
                HireDate = DateTime.UtcNow,
            };

            if (_userManager.Users.All(u => u.UserName != student1.UserName))
            {
                await _userManager.CreateAsync(student1, "123456789aA.");
                await _userManager.AddToRoleAsync(student1, "Student");
            }
            if (_userManager.Users.All(u => u.UserName != student2.UserName))
            {
                await _userManager.CreateAsync(student2, "123456789aAaA.");
                await _userManager.AddToRoleAsync(student2, "Student");
            }
            if (_userManager.Users.All(u => u.UserName != instructor1.UserName))
            {
                await _userManager.CreateAsync(instructor1, "123456789aAaAaA.");
                await _userManager.AddToRoleAsync(instructor1, "Instructor");
            }
            return Ok();
        }


        private async Task<string> GenerateJwtToken(ApplicationUser user, IList<string> roles)
        {
            var claims = new List<Claim>{
                new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                // Add other claims as needed
            };

            // Add role claims
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            // Normally you'd obtain these from the configuration
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your-256-bit-secret"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "https://localhost:5001",
                audience: "EduManage.Api",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30), // Set the token expiry as needed
                signingCredentials: creds
            );

            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }

        public class LoginDto
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

    }
}