namespace Cumpuss.API.Models
{
    public record GetTokenResponse(string? Token, string? Error = null)
    {
        public static GetTokenResponse FromError(string error)
        {
            return new GetTokenResponse(null, error);
        }
    }
}
