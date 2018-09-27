
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace CustomAuthorize {
    public class ClaimRequirementAttribute : TypeFilterAttribute {
        public ClaimRequirementAttribute(string claimType, string claimValue) :
            base(typeof(ClaimRequirementFilter)) {
            Arguments = new object[] { new Claim(claimType, claimValue) };
        }
    }

}