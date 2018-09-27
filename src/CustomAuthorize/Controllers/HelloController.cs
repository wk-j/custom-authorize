using Microsoft.AspNetCore.Mvc;

namespace CustomAuthorize {
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HelloController : ControllerBase {

        [HttpPost]
        [ClaimRequirement("Permission", "CanRead")]
        public ActionResult<object> Hi() {
            return Ok();
        }

        [HttpGet]
        public ActionResult<object> Go() {
            return new {
                Go = "Go"
            };
        }
    }

}