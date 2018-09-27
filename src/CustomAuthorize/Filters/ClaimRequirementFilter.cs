
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CustomAuthorize {

    public class ClaimRequirementFilter : IAuthorizationFilter {
        readonly Claim claim;
        public ClaimRequirementFilter(Claim claim) {
            this.claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context) {
            var hasClaim = context.HttpContext.User.Claims.Any(c => c.Type == claim.Type && c.Value == claim.Value);
            if (!hasClaim) {
                context.Result = new ForbidResult();
            }
        }
    }

}