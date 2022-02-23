using Cumpuss.Application.Holders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace Cumpuss.API.Authentication
{
    internal static class AuthOptions
    {
        private static readonly string Key = ConfigHolder.GetValue("tokenKey")!;
        public static readonly int Lifetime = ConfigHolder.GetIntValue("tokenLifetime");
        public static readonly SymmetricSecurityKey SecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));

        internal static DateTime GetExpires()
        {
            return DateTime.UtcNow.Add(TimeSpan.FromMinutes(Lifetime));
        }
    }
}
