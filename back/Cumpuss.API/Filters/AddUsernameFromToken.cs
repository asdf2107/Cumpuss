using Cumpuss.Application.Request;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Cumpuss.API.Filters
{
    public class AddUsernameFromToken : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Items[CustomClaimTypes.Name] = context.HttpContext.User.FindFirst(CustomClaimTypes.Name)?.Value;
        }
    }
}
