using Microsoft.IdentityModel.Tokens;
using Planify.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Planify.Services
{
    public class AuthService
    {
        public static string GenerateToken(User user, JWTConfig jwt)
        {
            List<Claim> claims = GetDefaultClaims(user);

            foreach (var role in user.Roles)
                claims.Add(new Claim(ClaimTypes.Role, role.Name));

            foreach (var permision in user.Permisions)
                claims.Add(new Claim(permision.Name, "true"));

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
            SigningCredentials signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            JwtSecurityToken Token = new JwtSecurityToken(
                    jwt.Issuer,
                    jwt.Audience,
                    claims,
                    expires: DateTime.UtcNow.AddDays(1),
                    signingCredentials: signIn
            );
            return new JwtSecurityTokenHandler().WriteToken(Token);
        }

        private static List<Claim> GetDefaultClaims(User user)
        {
            return new List<Claim>()
            {
                new Claim("UserId", user.Id.ToString()),
                //new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, EpochTime.GetIntDate(DateTime.UtcNow).ToString()),
            };
        }
        public static string EncrypBySHA256(string password)
        {
            SHA256 sha256 = SHA256.Create();
            UTF8Encoding encoding = new UTF8Encoding();
            StringBuilder sb = new StringBuilder();

            byte[] stream = sha256.ComputeHash(encoding.GetBytes(password));

            //bytes to hex
            for (int i = 0; i < stream.Length; i++)
                sb.AppendFormat("{0:x2}", stream[i]);

            return sb.ToString();
        }
    }

    public partial class JWTConfig
    {
        public required string Key { get; set; }
        public required string Issuer { get; set; }
        public required string Audience { get; set; }
    }
}
