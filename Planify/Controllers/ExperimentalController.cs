using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperimentalController : ControllerBase
    {
        [HttpGet("experiments")]
        [Authorize]
        public void get()
        {
            //check
            var x = this.HttpContext.User;
            var s = this.HttpContext.User.Identity?.Name;
        }
    }
}
