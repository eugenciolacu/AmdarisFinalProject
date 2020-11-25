using AmdarisInternship.API.Services.Interfaces;
using AmdarisInternship.Domain.Entities;
using AmdarisInternship.Domain.Entities.Authentication;
using AmdarisInternship.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AmdarisInternship.API.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        private readonly IRepository<User> _userRepository;

        public AuthenticateService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IRepository<User> userRepository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _userRepository = userRepository;
        }

        public async Task<JwtSecurityToken> Login(LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);

            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );
                return token;
            }

            return null;
        }

        public async Task<Response> Register(RegisterModel model)
        {
            Response response;

            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
            {
                response = new Response { Status = "Error", Message = "User already exists!" };
                return await Task.FromResult(response);
            }

            ApplicationUser applicationUser = new ApplicationUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(applicationUser, model.Password);
            if (!result.Succeeded)
            {
                response = new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." };
                return await Task.FromResult(response);
            }

            if (await _roleManager.RoleExistsAsync(model.UserRole))
            {
                await _userManager.AddToRoleAsync(applicationUser, model.UserRole);
            }

            string id = _userManager.FindByEmailAsync(model.Email).Result.Id;

            User user = new User()
            {
                IidentityId = id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Skype = model.Skype,
                AvatarExtension = model.AvatarExtension,
                AvatarName = model.AvatarName,
                Avatar = model.Avatar,
                MentroId = model.MentroId
            };

            _userRepository.Add(user);
            _userRepository.Save();

            return await Task.FromResult(new Response { Status = "Success", Message = "User created successfully!" });
        }
    }
}
