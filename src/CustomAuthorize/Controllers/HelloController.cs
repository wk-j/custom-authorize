using Microsoft.AspNetCore.Mvc;

namespace CustomAuthorize {
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HelloController : ControllerBase {

        [HttpGet]
        [ClaimRequirement("Permission", "CanRead")]
        public ActionResult<object> Hi() {
            return Ok();
        }
    }
}