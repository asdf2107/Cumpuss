using AutoMapper;
using Cumpuss.API.Authentication;
using Cumpuss.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace Cumpuss.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpGet("token")]
        public GetTokenResponse GetToken(string username, string password)
        {
            var identity = AuthManager.GetIdentity(username, password);
            
            if (identity == null)
            {
                return GetTokenResponse.FromError("Invalid username or password.");
            }

            var jwt = new JwtSecurityToken(
                    claims: identity.Claims,
                    expires: AuthOptions.GetExpires(),
                    signingCredentials: new SigningCredentials(AuthOptions.SecurityKey, SecurityAlgorithms.HmacSha256));
            
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return new GetTokenResponse(encodedJwt);
        }
    }
}
