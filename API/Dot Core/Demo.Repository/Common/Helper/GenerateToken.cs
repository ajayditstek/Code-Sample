using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Demo.Core.Model;

namespace Demo.Repository.Common.Helper
{
    public class GenerateToken
    {
        private IConfiguration _configuration;
        private UATDemoPortalContext _dbContext;
        public GenerateToken(IConfiguration configuration, UATDemoPortalContext dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }
        public (string, JwtSecurityToken) GenerateAccessToken(AspnetMembership user, bool RememberMe)
        {
            Claim[] claims = new[]
           {
                new Claim("Email", user.Email),
                new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
            };
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["AuthSettings:Key"]));
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _configuration["AuthSettings:Issuer"],
                audience: _configuration["AuthSettings:Audience"],
                claims: claims,
                expires: !RememberMe ? DateTime.Now.AddDays(7) : DateTime.Now.AddDays(30),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256));

            return (new JwtSecurityTokenHandler().WriteToken(token), token);
        }
    }
}

