using Cumpuss.Application.Request;
using Cumpuss.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Cumpuss.API.Authentication
{
    internal static class AuthManager
    {
        public static ClaimsIdentity? GetIdentity(string username, string password)
        {
            string passwordHash = HashPassword(password);
            
            var user = new CumpussDBContext().Users.FirstOrDefault(x => x.Username == username && x.PasswordHash == passwordHash);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(CustomClaimTypes.Name, user.Username),
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Token");
                return claimsIdentity;
            }

            return null;
        }

        private static string HashPassword(string password)
        {
            return password; //!
        }
    }
}
