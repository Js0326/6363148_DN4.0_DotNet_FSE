using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("secure")]
        [Authorize]
        public IActionResult Secure()
        {
            return Ok($"You are authenticated as: {User.Identity?.Name}");
        }
    }
}
